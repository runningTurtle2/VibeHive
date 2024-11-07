using Microsoft.AspNetCore.Mvc;
using MusicRentalAPI.Models;

namespace MusicRentalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        // In-memory lists to hold rentals and music data
        private static List<Rental> _rentals = new List<Rental>();
        private static List<Music> _musicLibrary = new List<Music>();

        // Seed data to simulate a music library
        static RentalController()
        {
            // Adding some sample music for testing
            _musicLibrary.Add(new Music { Id = 1, Title = "Album 1", Artist = "Artist A", Genre = "Rock", Year = 2020, Available = true });
            _musicLibrary.Add(new Music { Id = 2, Title = "Album 2", Artist = "Artist B", Genre = "Pop", Year = 2021, Available = true });
            _musicLibrary.Add(new Music { Id = 3, Title = "Album 3", Artist = "Artist C", Genre = "Jazz", Year = 2019, Available = true });
        }

        // POST: api/rentals
        [HttpPost]
        public ActionResult<Rental> RentAlbum(Rental rental)
        {
            var music = _musicLibrary.FirstOrDefault(m => m.Id == rental.AlbumId && m.Available);
            if (music == null)
                return BadRequest("Album is not available for rent.");

            music.Available = false; // Mark the album as rented
            rental.RentalDate = DateTime.Now; // Record the rental date
            _rentals.Add(rental); // Add to the rentals list
            return Ok(rental); // Return the rental data
        }

        // POST: api/rentals/{id}/return
        [HttpPost("{id}/return")]
        public ActionResult ReturnAlbum(int id)
        {
            var rental = _rentals.FirstOrDefault(r => r.AlbumId == id && r.ReturnDate == null);
            if (rental == null)
                return NotFound("Rental not found.");

            rental.ReturnDate = DateTime.Now; // Set the return date
            var music = _musicLibrary.FirstOrDefault(m => m.Id == id);
            if (music != null)
            {
                music.Available = true; // Mark the album as available again
            }
            return NoContent(); // Return success
        }

        // GET: api/rentals
        [HttpGet]
        public ActionResult<List<Rental>> GetActiveRentals()
        {
            // Return only active rentals (those with no return date)
            return _rentals.Where(r => r.ReturnDate == null).ToList();
        }
    }
}
