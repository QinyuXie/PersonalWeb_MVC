using System;
using System.ComponentModel.DataAnnotations;


namespace PersonalWeb.Models.Entities
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentContent { get; set; }

        public string FromUserNm { get; set; }
    }
}
