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
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string NIP { get; set; }


        public Data(string pesel)
        {
            //Set gender and date of birth from pesel number
            string year,month,day;

            if (pesel[2] ==2 || pesel[2] ==3)
            {
                year = "20";
                year += pesel[0];
                year += pesel[1];
                if (pesel[2] == 2)
                {
                    month = "0";
                    month += pesel[3];
                }
                else
                {
                    month = "1";
                    month += pesel[3];
                }
                day = "";
                day += pesel[4];
                day += pesel[5];

            }
            else
            {
                year = "19";
                year += pesel[0];
                year += pesel[1];
                month = "";
                month += pesel[2];
                month += pesel[3];
                day = "";
                day += pesel[4];
                day += pesel[5];
            }

            DateOfBirth = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
            if (int.Parse(pesel[9].ToString())%2 == 1)
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
