﻿using System;
using System.Collections.Generic;

namespace Kolokwium2.Models {

    public class Organiser {
        public int IdOrganiser { get; set; }
        public string Name { get; set; }
        public ICollection<Event_Organiser> Event_Organisers { get; set; }

        public Organiser() {
        }
    }
}
