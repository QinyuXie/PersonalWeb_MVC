using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalWeb.Models.Entities;
using PersonalWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin")]
    public class EduController : Controller
    {

        private readonly AppDbContext context_;
        //private readonly UserManager<ApplicationUser> _userManager;


        public EduController(AppDbContext context)
        {
            context_ = context;

        }


        // GET: api/Edu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Edu>>> GetAllEdus()
        {
            return await context_.edus.ToListAsync();
        }

        // GET api/Edu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Edu>> GetEdu(int id)
        {
            var eduItem = await context_.edus.FirstOrDefaultAsync((e) => e.EduId == id);

            if(eduItem == null)
            {
                return NotFound();
            }
            return eduItem;
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<Edu>> PostEduItemAsync(Edu eduItem)
        {
            context_.edus.Add(eduItem);
            await context_.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEdu),
                                   new { id = eduItem.EduId },
                                   eduItem);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Edu eduItem)
        {
            if(id != eduItem.EduId)
            {
                return BadRequest();
            }

            context_.edus.Update(eduItem);
            await context_.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Edu>> Delete(int id)
        {
            var eduItem = await context_.edus.FirstOrDefaultAsync((e) => e.EduId == id);

            if (eduItem == null)
            {
                return NotFound();
            }

            context_.edus.Remove(eduItem);
            await context_.SaveChangesAsync();
            return NoContent();
        }
    }
}
