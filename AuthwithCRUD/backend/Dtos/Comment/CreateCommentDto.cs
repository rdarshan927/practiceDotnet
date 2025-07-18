using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos.Comment
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Title must be 5 characters")]
        [MaxLength(50, ErrorMessage = "Title cannot be over 50 characters")]
        public string Title { get; set; } = string.Empty;
        [Required]
        [MinLength(20, ErrorMessage = "Content must be 20 characters")]
        [MaxLength(400, ErrorMessage = "Title cannot be over 400 characters")]
        public string Content { get; set; } = string.Empty;
    }
}