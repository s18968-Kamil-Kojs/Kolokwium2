using System;
namespace Kolokwium2.Models {

    public class Artist_Event {
        public int IdEvent { get; set; }
        public int IdArtist { get; set; }
        public DateTime PerformanceDate { get; set; }
        public virtual Artist ArtistNav { get; set; }
        public virtual Event EventNav { get; set; }

        public Artist_Event() {
        }
    }
}
