using System;
namespace Kolokwium2.Exceptions {
    public class ArtistDoesNotPerformInEvent : Exception{
        public ArtistDoesNotPerformInEvent() {
        }

        public ArtistDoesNotPerformInEvent(string message) : base(message) {
        }

        public ArtistDoesNotPerformInEvent(string message, Exception innerException) : base(message, innerException) {
        }
    }
}
