using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddressBook.Models
{
    public class AddressBook
    {
        public virtual List<Contact> Contacts { get; set; }
    }
}