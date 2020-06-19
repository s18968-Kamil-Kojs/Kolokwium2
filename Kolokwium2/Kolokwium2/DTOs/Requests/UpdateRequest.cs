using System;
namespace Kolokwium2.DTOs.Requests {

    public class UpdateRequest {
        public int idArtist { get; set; }
        public int idEvent { get; set; }
        public DateTime performanceDate { get; set; }

        public UpdateRequest() {
        }
    }
}
