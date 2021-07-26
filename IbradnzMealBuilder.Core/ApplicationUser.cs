using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;    
using System.Text;


namespace IbradnzMealBuilder.Core
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base() { }
        public bool IsAccountSetUpComplete { get; set; }
        //public bool IsBasicAccountSetupComplete { get; set; }
    }
}
