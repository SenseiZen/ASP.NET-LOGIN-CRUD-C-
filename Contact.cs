namespace MVCLogin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contact
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
    }
}
