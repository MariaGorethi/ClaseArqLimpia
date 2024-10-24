﻿using System.Text.Json.Serialization;

namespace ReservacionesRestFul.Bussines.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string RoomId { get; set; }
        public bool Available { get; set; }
        [JsonIgnore]
        public ICollection<Reservation> Reservations { get;set; }
    }
}
