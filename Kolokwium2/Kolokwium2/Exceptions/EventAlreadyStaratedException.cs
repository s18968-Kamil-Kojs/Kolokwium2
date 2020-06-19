using System;
namespace Kolokwium2.Exceptions {
    public class EventAlreadyStaratedException : Exception {
        public EventAlreadyStaratedException() {
        }

        public EventAlreadyStaratedException(string message) : base(message) {
        }

        public EventAlreadyStaratedException(string message, Exception innerException) : base(message, innerException) {
        }
    }
}
