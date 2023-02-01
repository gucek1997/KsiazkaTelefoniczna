using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KsiazkaTelefoniczna
{
    class Phonebook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();




        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        
        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name},{contact.Number}");

        }






        public void DisplayContact(string number)
        {
            var contact =Contacts.FirstOrDefault(c => c.Number == number);  
            if(contact == null)
            {
                Console.WriteLine("Kontakt nieznaleziony");

            }
            else
            {
                DisplayContactDetails(contact); 
            
            }
        }


        public void DisplayAllContacts()
        {

            foreach (var contact in Contacts)
            {
                DisplayContactDetails(contact);

            }

        }


        public void DisplayMatchingContacts(string searchPharse)
        {

            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPharse)).ToList();
            foreach (var contact in matchingContacts)
            {
                DisplayContactDetails(contact);

            }


        }





    }
}
