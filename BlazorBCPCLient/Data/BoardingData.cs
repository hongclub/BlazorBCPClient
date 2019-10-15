using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorBCPCLient.Data
{
    public class BoardingData
    {
        [Required]
        [MaxLength(50)]
        public string bankId { get; set; }

        [Required]

        public string bankName { get; set; }

        public string bankDescription { get; set; }
    }
}
