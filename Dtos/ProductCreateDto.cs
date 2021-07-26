using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EstoqueWebAPI.Dtos
{
    public class ProductCreateDto
    {

        public string Name { get; set; }

        public int Quantity { get; set; }
        
        public string Manufacturer { get; set; }

    }
}
