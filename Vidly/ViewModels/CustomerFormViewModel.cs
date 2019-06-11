using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vitty.Models;

namespace Vitty.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}