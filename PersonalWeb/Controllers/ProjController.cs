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
    public class ProjController : Controller
    {

        private readonly AppDbContext context_;

        public ProjController(AppDbContext context)
        {
            context_ = context;

        }


        // GET: api/Edu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Project>>> GetAllProjs()
        {
            return await context_.projects.ToListAsync();
        }

        // GET api/Edu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Project>> GetProj(int id)
        {
            var projItem = await context_.projects.FirstOrDefaultAsync((e) => e.ProjectId == id);

            if (projItem == null)
            {
                return NotFound();
            }
            return projItem;
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<Project>> PostEduItemAsync(Project projItem)
        {
            context_.projects.Add(projItem);
            await context_.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProj),
                                   new { id = projItem.ProjectId },
                                   projItem);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Project projItem)
        {
            if (id != projItem.ProjectId)
            {
                return BadRequest();
            }

            context_.projects.Update(projItem);
            await context_.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Project>> Delete(int id)
        {
            var projItem = await context_.projects.FirstOrDefaultAsync((e) => e.ProjectId == id);

            if (projItem == null)
            {
                return NotFound();
            }

            context_.projects.Remove(projItem);
            await context_.SaveChangesAsync();
            return NoContent();
        }
    }
}
