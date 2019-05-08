using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalWeb.Models.Entities;
using PersonalWeb.Data;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkController : Controller
    {

        private readonly AppDbContext context_;

        public WorkController(AppDbContext context)
        {
            context_ = context;

        }


        // GET: api/Edu
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Work>>> GetAllWorks()
        {
            return await context_.works.ToListAsync();
        }

        // GET api/Edu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Work>> GetWork(int id)
        {
            var workItem = await context_.works.FirstOrDefaultAsync((w) => w.WorkId == id);

            if (workItem == null)
            {
                return NotFound();
            }
            return workItem;
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<Work>> PostWorkItemAsync(Work workItem)
        {
            context_.works.Add(workItem);
            await context_.SaveChangesAsync();

            return CreatedAtAction(nameof(GetWork),
                                   new { id = workItem.WorkId },
                                   workItem);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Work workItem)
        {
            if (id != workItem.WorkId)
            {
                return BadRequest();
            }

            context_.works.Update(workItem);
            await context_.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Work>> Delete(int id)
        {
            var workItem = await context_.works.FirstOrDefaultAsync((e) => e.WorkId == id);

            if (workItem == null)
            {
                return NotFound();
            }

            context_.works.Remove(workItem);
            await context_.SaveChangesAsync();
            return NoContent();
        }
    }
}
