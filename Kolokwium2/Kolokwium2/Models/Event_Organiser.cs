using System;
using System.Collections.Generic;

namespace Kolokwium2.Models {

    public class Event_Organiser {
        public int IdEvent { get; set; }
        public int IdOrganiser { get; set; }
        public virtual Event EventNav { get; set; }
        public virtual Organiser OrganiserNav { get; set; }

        public Event_Organiser() {
        }
    }
}
