using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalInformations
{
    public class Data
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PESEL { get; set; }
        public string Gender { get; }
        public DateTime DateOfBirth { get; }
        public string Email { get; set; }
        public string NIP { get; set; }


        public Data(string pesel)
        {
            //Set gender and date of birth from pesel number
        }

    }
}
