using System;
namespace Kolokwium2.Exceptions {
    public class ArtistDoesntExistException : Exception{
        public ArtistDoesntExistException(string message) : base(message) {
        }

        public ArtistDoesntExistException(string message, Exception innerException) : base(message, innerException) {
        }

        public ArtistDoesntExistException() {
        }
    }
}
