using Microsoft.AspNetCore.Mvc;
using MusicRentalAPI.Models;

namespace MusicRentalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        private static List<Music> _musicLibrary = new List<Music>();

        // POST: api/music
        [HttpPost]
        public ActionResult<Music> AddMusic(Music music)
        {
            music.Id = _musicLibrary.Count + 1;
            _musicLibrary.Add(music);
            return CreatedAtAction(nameof(GetMusic), new { id = music.Id }, music);
        }

        // GET: api/music
        [HttpGet]
        public ActionResult<List<Music>> GetMusic()
        {
            return _musicLibrary.Where(m => m.Available).ToList();
        }

        // DELETE: api/music/
        [HttpDelete("{id}")]
        public ActionResult DeleteMusic(int id)
        {
            var music = _musicLibrary.FirstOrDefault(m => m.Id == id);
            if (music == null)
                return NotFound();

            _musicLibrary.Remove(music);
            return NoContent();
        }
    }
}
