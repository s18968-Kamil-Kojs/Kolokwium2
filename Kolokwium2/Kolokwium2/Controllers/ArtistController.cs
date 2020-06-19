using System;
using System.Threading.Tasks;
using Kolokwium2.DTOs.Requests;
using Kolokwium2.Exceptions;
using Kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kolokwium2.Controllers {

    [Route("api/artists")]
    [ApiController]
    public class ArtistController : ControllerBase{
        private readonly IDbService _service;

        public ArtistController(IDbService service) {
            _service = service;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetArtist(int id) {
            try {
                return Ok(await _service.GetArtist(id));
            } catch (ArtistDoesntExistException exc) {
                return NotFound(exc.Message);
            }
        }

        [HttpPost("{idArtist:int}/events/{idEvent:int}")]
        public IActionResult UpdatePerformance(UpdateRequest updateRequest, int idArtist, int idEvent) {
            try {
                _service.UpdatePerformanceDate(updateRequest, idArtist, idEvent);
                return Ok("Performance date updated");
            } catch (ArtistDoesntExistException e1) {
                return NotFound(e1.Message);
            } catch(ArtistDoesNotPerformInEvent e2) {
                return BadRequest(e2.Message);
            } catch (EventAlreadyStaratedException e3) {
                return BadRequest(e3.Message);
            } catch (EventDoesNotExistException e4) {
                return BadRequest(e4.Message);
            } catch (PerformanceNotInBoundaries e5) {
                return BadRequest(e5.Message);
            }
        }
    }
}
