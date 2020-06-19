using System;
namespace Kolokwium2.Exceptions {
    public class EventDoesNotExistException : Exception{
        public EventDoesNotExistException() {
        }

        public EventDoesNotExistException(string message) : base(message) {
        }

        public EventDoesNotExistException(string message, Exception innerException) : base(message, innerException) {
        }
    }
}
