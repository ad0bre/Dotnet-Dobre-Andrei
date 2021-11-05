using System;
using System.Collections.Generic;
using System.Text;

namespace Dobre_Andrei
{
    public class Person
    {
        public string FirstName { get; set; } // proprietate care se poate citi/scrie
        public string LastName { get; set; }
        public string GetFullName() //functie care returneaza un sir de caractere
        {
            return FirstName + " " + LastName;
        }

    }
}
