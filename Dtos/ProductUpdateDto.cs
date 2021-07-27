using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueWebAPI.Dtos
{
    public class ProductUpdateDto
    {
        [Required]
        [MaxLength(250)]
        public string Name { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [MaxLength(250)]
        public string Manufacturer { get; set; }

    }
}
