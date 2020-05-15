using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DataFormXamarin
{
    public class ContactInfo: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(String Name)
        {
            if (PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(Name));
        }
        public ContactInfo()
        {

        }
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                this.name = value;
                this.RaisePropertyChanged("Name");
            }
        }
        private int? number;
        public int? Number
        {
            get { return this.number; }
            set
            {
                this.number = value;
                this.RaisePropertyChanged("Number");
            }
        }
        private string cardNumber;
        [Display(ShortName = "Card Number")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Card number should not be empty")]
        [StringLength(19, ErrorMessage = "Card number should not exceed 16 digits")]
        [DataType(DataType.PhoneNumber)]
        public string CardNumber
        {
            get
            { return cardNumber; }
            set
            {cardNumber = value;
                this.RaisePropertyChanged("CardNumber");
            }
        }
    }
}
