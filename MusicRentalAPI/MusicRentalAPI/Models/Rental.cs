namespace MusicRentalAPI.Models
{
    public class Rental
    {
        public int UserId { get; set; }
        public int AlbumId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}