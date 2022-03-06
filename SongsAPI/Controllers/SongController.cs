using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SongsAPI.Data.Models;
using SongsAPI.Data.Models.Services;

namespace SongsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongController : ControllerBase
    {
        public SongService _songservice;

        public SongController(SongService songservice)
        {
            _songservice = songservice;
        }

        [HttpPost("add-song")]
        public IActionResult AddSong([FromBody] SongVM song)
        {
            _songservice.AddSong(song);
            return Ok();
        }
        [HttpGet("get-all-song-data")]
        public IActionResult GetAllSongData()
        {
            var list = _songservice.GetAllSongData();
            return Ok(list);
        }
       /* [HttpGet("get-song-by-name/{name}")]
        public IActionResult GetSongByName(string name)
        {
            var song = _songservice.GetSongByName(name);
            return Ok(song);
        }*/
        [HttpGet("get-song-by-id/{id}")]
        public IActionResult GetSongById(int id)
        {
            var song = _songservice.GetSongByID(id);
            return Ok(song);
        }
        [HttpPut("update-song-details-by-id/{id}")]
        public IActionResult UpdateSongDetails([FromBody] SongVMEdit song,int id)
        {
            var _song = _songservice.UpdateSongDetails(song, id);
            return Ok(_song);
        }

        [HttpDelete("delet-song-by-id/{id}")]
        public IActionResult DeleteSongById(int id)
        {
            _songservice.DeletSongById(id);
            return Ok();
        }
        
        

     }
}
