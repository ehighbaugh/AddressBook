using AddressBook.Data;
using AddressBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AddressBook
{
    public class DbInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<AddressBookContext>
    {
        protected override void Seed(AddressBookContext context)
        {
            var Contacts = new List<Contact>
            {
            new Contact{FirstName="Carson",LastName="Alexander",Email="abc@gmail.com",Mobile="5025551212",Landline="5025551414",Notes="work friend"},
            new Contact{FirstName="Meredith",LastName="Alonso",Email="abc@gmail.com",Mobile="5025551212",Landline="5025551414",Notes="work friend"},
            new Contact{FirstName="Arturo",LastName="Anand",Email="abc@gmail.com",Mobile="5025551212",Landline="5025551414",Notes="work friend"},
            new Contact{FirstName="Gytis",LastName="Barzdukas",Email="abc@gmail.com",Mobile="5025551212",Landline="5025551414",Notes="work friend"},
            new Contact{FirstName="Yan",LastName="Li",Email="abc@gmail.com",Mobile="5025551212",Landline="5025551414",Notes="work friend"},
            new Contact{FirstName="Peggy",LastName="Justice",Email="abc@gmail.com",Mobile="5025551212",Landline="5025551414",Notes="work friend"},
            new Contact{FirstName="Laura",LastName="Norman",Email="abc@gmail.com",Mobile="5025551212",Landline="5025551414",Notes="work friend"},
            new Contact{FirstName="Nino",LastName="Olivetto",Email="abc@gmail.com",Mobile="5025551212",Landline="5025551414",Notes="work friend"}
            };

        }
    }
}