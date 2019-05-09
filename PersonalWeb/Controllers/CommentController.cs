using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalWeb.Data;
using PersonalWeb.Models.Entities;
using Microsoft.EntityFrameworkCore;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PersonalWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CommentController : Controller
    {
        private readonly AppDbContext context_;

        public CommentController(AppDbContext context)
        {
            context_ = context;

        }


        // GET: api/comment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Comment>>> GetAllComments()
        {
            return await context_.comments.ToListAsync();
        }

        // GET api/Edu/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Comment>> GetComment(int id)
        {
            var comItem = await context_.comments.FirstOrDefaultAsync((e) => e.CommentId == id);

            if (comItem == null)
            {
                return NotFound();
            }
            return comItem;
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult<Comment>> PostCommentItemAsync(Comment comItem)
        {
            context_.comments.Add(comItem);
            await context_.SaveChangesAsync();

            return CreatedAtAction(nameof(GetComment),
                                   new { id = comItem.CommentId },
                                   comItem);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, Comment comItem)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Comment>> Delete(int id)
        {
            var comItem = await context_.comments.FirstOrDefaultAsync((e) => e.CommentId == id);

            if (comItem == null)
            {
                return NotFound();
            }

            context_.comments.Remove(comItem);
            await context_.SaveChangesAsync();
            return NoContent();
        }
    }
}
