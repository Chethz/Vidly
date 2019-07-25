using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; }

        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }
    }
}