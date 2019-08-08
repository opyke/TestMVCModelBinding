using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestMVCModelBinding.Models
{
    public class Payment
    {
        [Required]
        [Display(Name = "Client Code")]
        public string ClientCode { get; set; }

        [Display(Name = "Client Name")]
        public string Name { get; set; }
        public IList<Card> Cards { get; set; }

        [Required]
        public Guid SelectedCard { get; set; }
    }
}
