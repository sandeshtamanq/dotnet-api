using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos
{
    public class CreateStockDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol must be at most 10 characters.")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MinLength(3, ErrorMessage = "Company Name must be at least 3 characters.")]
        [MaxLength(250, ErrorMessage = "Company Name must be at most 250 characters.")]
        public string CompanyName { get; set; } = string.Empty;

        [Required]
        [Range(1, 1000000)]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.001, 100)]
        public decimal LastDiv { get; set; }

        [Required]
        [MinLength(3, ErrorMessage = "Industry must be at least 3 characters.")]
        [MaxLength(250, ErrorMessage = "Industry must be at most 250 characters.")]
        public string Industry { get; set; } = string.Empty;

        [Required]
        [Range(1, 5000000000)]
        public long MarketCap { get; set; }
    }
}