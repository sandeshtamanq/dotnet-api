using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Comment
{
    public class CreateCommentDto
    {
        [Required]
        [MinLength(3, ErrorMessage = "Title must be at least 3 characters.")]
        [MaxLength(250, ErrorMessage = "Title must be at most 250 characters.")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MinLength(3, ErrorMessage = "Content must be at least 3 characters.")]
        [MaxLength(250, ErrorMessage = "Content must be at most 250 characters.")]
        public string Body { get; set; } = string.Empty;

        [Required(ErrorMessage = "StockId is required.")]
        public int? StockId { get; set; }
    }
}