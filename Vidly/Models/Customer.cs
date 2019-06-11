using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vitty.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Tipo de Membro")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}