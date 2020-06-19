using System;
using System.Linq;
using System.Threading.Tasks;
using Kolokwium2.DTOs.Requests;
using Kolokwium2.Exceptions;
using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Services {

    public class EFArtistsDbService : IDbService{
        private readonly DataBaseContext _context;

        public EFArtistsDbService(DataBaseContext context) {
            _context = context;
        }

        public async Task<Artist> GetArtist(int id) {
            var artist = await _context.Artist.Include(e => e.Artist_Events).SingleOrDefaultAsync(e => e.IdArtist == id);
            if(artist == null) {
                throw new ArtistDoesntExistException($"Artist with an id={id} doesn't exist");
            }
            artist.Artist_Events = artist.Artist_Events.OrderByDescending(e => e.PerformanceDate).ToList();
            return artist;
        }

        public void UpdatePerformanceDate(UpdateRequest updateRequest, int idArtist, int idEvent) {
            var artist = _context.Artist.SingleOrDefault(e => e.IdArtist == idArtist);

            if(artist == null) {
                throw new ArtistDoesntExistException($"Artist with an id={idArtist} doesn't exist");
            }

            var searchedEvent = _context.Event.SingleOrDefault(e => e.IdEvent == idEvent);

            if(searchedEvent == null) {
                throw new EventDoesNotExistException($"Event with an id={idEvent} doesn't exist");
            }

            var artist_event = _context.Artist_Event.SingleOrDefault(e => e.IdArtist == idArtist && e.IdEvent == idEvent);

            if (artist_event == null) {
                throw new ArtistDoesNotPerformInEvent($"Artist with an id={idArtist} doesn't perform in event with an id={idEvent}");
            }

            if(searchedEvent.StartDate <= DateTime.Now) {
                throw new EventAlreadyStaratedException($"Event with an id={idEvent} has already started");
            }

            if(updateRequest.performanceDate < searchedEvent.StartDate && updateRequest.performanceDate > searchedEvent.EndDate) {
                throw new PerformanceNotInBoundaries("Performance not in the event time boundaries");
            }

            artist_event.PerformanceDate = updateRequest.performanceDate;
            _context.Artist_Event.Update(artist_event);
            _context.SaveChanges();
        }
    }
}
