using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewsLetterMVCApp.ViewModels
{
    using System;
    using System.Collections.Generic;
    public partial class SignupVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

    }
}