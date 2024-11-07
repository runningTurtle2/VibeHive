﻿namespace MusicRentalAPI.Models
{
    public class Music
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public bool Available { get; set; }
    }
}