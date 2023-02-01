using System;

namespace KsiazkaTelefoniczna
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Witamy w książce telefonicznej");

            Console.WriteLine("1. Dodaj Kontakt");
            Console.WriteLine("2.Wyświetl kontakt numer");
            Console.WriteLine("3.Wyświetl wszystkie kontatky");
            Console.WriteLine("4.Znajdź kontakt");
            Console.WriteLine("X żeby zamknąć");

            var userInput = Console.ReadLine();
            var phoneBook = new Phonebook();

            while(true)
            {

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Wpisz numer");
                        var numer = Console.ReadLine();
                        Console.WriteLine("Wpisz imie");
                        var name = Console.ReadLine();

                        var newContact = new Contact(name, numer);

                        phoneBook.AddContact(newContact);

                        break;
                    case "2":
                        Console.WriteLine("Wpisz numer");
                        var numerToSearch = Console.ReadLine();

                        phoneBook.DisplayContact(numerToSearch);

                        break;
                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Wyszukaj nazwę: ");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "x":
                        return;
                    
                    default:
                        Console.WriteLine("Niepoprawna operacja");
                        break;
                }
                Console.WriteLine("Wybierz operacje: ");
                userInput = Console.ReadLine();



            }






        
        }
    }
}