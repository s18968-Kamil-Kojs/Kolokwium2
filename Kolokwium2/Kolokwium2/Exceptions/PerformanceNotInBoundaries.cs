using System;
namespace Kolokwium2.Exceptions {
    public class PerformanceNotInBoundaries : Exception{
        public PerformanceNotInBoundaries() {
        }

        public PerformanceNotInBoundaries(string message) : base(message) {
        }

        public PerformanceNotInBoundaries(string message, Exception innerException) : base(message, innerException) {
        }
    }
}
