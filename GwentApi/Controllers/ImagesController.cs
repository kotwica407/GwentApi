using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GwentApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GwentApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ImagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Cards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhysicalFileResult>>> GetImages()
        {
            var cards =  await _context.Cards.ToListAsync();
            var images = new List<PhysicalFileResult>();
            foreach(Card card in cards)
            {
                images.Add(new PhysicalFileResult(@"D:\gwentcards\images\" + card.ArtUrl, "image/jpeg"));
            }
            return images;
        }
        // GET: api/Images/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetImage(int id)
        {
            var card = await _context.Cards.FindAsync(id);

            if (card == null)
            {
                return NotFound();
            }
            return new PhysicalFileResult(@"D:\gwentcards\images\" + card.ArtUrl, "image/jpeg");
        }
    }
}
