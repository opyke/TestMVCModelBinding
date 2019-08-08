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

        [NotEmpty(ErrorMessage = "Please select a card to use for payment")]
        public Guid SelectedCard { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(3)]
        public string Cvv { get; set; }
    }
}
