using System;
using System.Collections.Generic;

namespace Cedris.Restaurant.Domain.Entities
{
    public class Appointment
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public string CustomerName { get; set; }
    }
}