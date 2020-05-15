using System;
using System.Collections.Generic;
using System.Text;

namespace DataFormXamarin
{
    public class ViewModel
    {
        public ContactInfo ContactInfo
        {
            get; set;
        }
        public ViewModel()
        {
            this.ContactInfo = new ContactInfo();
        }
    }
}
