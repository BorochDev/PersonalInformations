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
        public string Gender { get; set; }
        public string YearOfBirth { get; set; }
        public string MonthOfBirth { get; set; }
        public string DayOfBirth { get; set; }
        public string Email { get; set; }
        public string NIP { get; set; }


        public Data(string pesel)
        {
            //Set gender and date of birth from pesel number
            PESEL = pesel;

            if (pesel[2] =='2' || pesel[2] =='3')
            {
                YearOfBirth = "20";
                YearOfBirth += pesel[0];
                YearOfBirth += pesel[1];
                if (pesel[2] == '2')
                {
                    MonthOfBirth = "0";
                    MonthOfBirth += pesel[3];
                }
                else
                {
                    MonthOfBirth = "1";
                    MonthOfBirth += pesel[3];
                }
                DayOfBirth = "";
                DayOfBirth += pesel[4];
                DayOfBirth += pesel[5];

            }
            else
            {
                YearOfBirth = "19";
                YearOfBirth += pesel[0];
                YearOfBirth += pesel[1];
                MonthOfBirth = "";
                MonthOfBirth += pesel[2];
                MonthOfBirth += pesel[3];
                DayOfBirth = "";
                DayOfBirth += pesel[4];
                DayOfBirth += pesel[5];
            }

            if ((int.Parse(pesel[9].ToString())%2 == 1))
            {
                Gender = "Mężczyzna";
            }
            else
            {
                Gender = "Kobieta";
            }

        }

    }
}
