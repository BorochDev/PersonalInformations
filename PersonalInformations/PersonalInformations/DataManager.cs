using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalInformations
{
    public class DataManager
    {
        private readonly DataService dataService;
        private string pesel,name;
        private int index, choice;
        public DataManager()
        {
            dataService = new DataService();
        }

        public void AddData()
        {
            dataService.SaveData(DataCreating());
        }

        public void DeleteData()
        {
            Console.Clear();
            Console.WriteLine("Podaj PESEL osoby, którą chcesz usunąć");
            pesel = Console.ReadLine();
            dataService.DeleteData(pesel);
        }

        public void EditData()
        {
            Console.Clear();
            Console.WriteLine("Podaj PESEL osoby, którą chcesz edytować");
            pesel = Console.ReadLine();
            dataService.DeleteData(pesel);
            dataService.SaveData(DataCreating());
        }

        public void ShowAllDataByYear()
        {
            Data[] datas = dataService.GetAllDataByYear().ToArray();
            Console.Clear();
            index = 1;
            foreach (var data in datas)
            {
                Console.WriteLine($"{index}){data.FirstName} {data.LastName}");
                index++;
            }
            if(int.TryParse(Console.ReadKey().ToString(), out choice))
            {
                if (choice<index)
                {
                    PrintData(datas[choice - 1]);
                }
            }
            
        }

        public void ShowAllDataFemale()
        {
            Data[] datas = dataService.GetAllDataFemale().ToArray();
            Console.Clear();
            index = 1;
            foreach (var data in datas)
            {
                Console.WriteLine($"{index}){data.FirstName} {data.LastName}");
                index++;
            }
            if (int.TryParse(Console.ReadKey().ToString(), out choice))
            {
                if (choice < index)
                {
                    PrintData(datas[choice - 1]);
                }
            }
        }

        public void ShowAllDataMale()
        {
            Data[] datas = dataService.GetAllDataMale().ToArray();
            Console.Clear();
            index = 1;
            foreach (var data in datas)
            {
                Console.WriteLine($"{index}){data.FirstName} {data.LastName}");
                index++;
            }
            if (int.TryParse(Console.ReadKey().ToString(), out choice))
            {
                if (choice < index)
                {
                    PrintData(datas[choice - 1]);
                }
            }
        }

        public void ShowAllData()
        {
            Data[] datas = dataService.GetAllData().ToArray();
            Console.Clear();
            index = 1;
            foreach (var data in datas)
            {
                Console.WriteLine($"{index}){data.FirstName} {data.LastName}");
                index++;
            }
            if (int.TryParse(Console.ReadKey().ToString(), out choice))
            {
                if (choice < index)
                {
                    PrintData(datas[choice - 1]);
                }
            }
        }

        public void ShowDataByFullName()
        {
            Console.Clear();
            Console.WriteLine("Podaj imie i nazwisko");
            name = Console.ReadLine();
            Data[] datas = dataService.GetDataByFullName(name).ToArray();
            Console.Clear();
            index = 1;
            foreach (var data in datas)
            {
                Console.WriteLine($"{index}) {data.PESEL}");
                index++;
            }
            if (int.TryParse(Console.ReadKey().ToString(), out choice))
            {
                if (choice < index)
                {
                    PrintData(datas[choice - 1]);
                }
            }
        }

        public void ShowDataByPESEL()
        {
            Console.Clear();
            Console.WriteLine("Podaj PESEL");
            pesel = Console.ReadLine();
            if (PESELCheck(pesel))
            {
                Data data = dataService.GetDataByPESEL(pesel);
                PrintData(data);
            }
            else
            {
                Console.WriteLine("Wprowadziłeś zły pesel");
            }
            
        }


        private Data DataCreating()
        {
            string email,nip;
            Console.Clear();
            Console.WriteLine("Podaj PESEL:");
            while (true)
            {
                pesel = Console.ReadLine();
                if (PESELCheck(pesel))
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Błędny pesel. Spróbuj ponownie:");
                }
            }
            Data data = new Data(pesel);

            Console.WriteLine("Podaj swoje imie:");
            data.FirstName = Console.ReadLine();

            Console.WriteLine("Podaj swoje nazwisko");
            data.LastName = Console.ReadLine();

            Console.WriteLine("Wprowadź email:");
            while (true)
            {
                email = Console.ReadLine();
                if (EmailCheck(email))
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Błędny Email. Wprowadź go ponownie:");
                }
            }

            Console.WriteLine("Wprowadź NIP:");
            while (true)
            {
                nip = Console.ReadLine();
                if (NIPCheck(nip))
                {
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Błędny NIP. Wprowadź go ponownie:");
                }
            }

            Console.WriteLine();
            return data;
        }

        private bool PESELCheck(string pesel)
        {
            
            if(pesel.Length != 11)
            {
                return false;
            }
            foreach (var number in pesel)
            {
                if (!int.TryParse(number.ToString(),out int result))
                {
                    return false;
                }
            }
            return true;
        }
        private bool EmailCheck(string email)
        {
            
            string[] parts = email.Split('@');
            if (parts.Length==2)
            {
                if (!parts[1].Contains('.'))
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
            return true;
        }

        private bool NIPCheck(string nip)
        {
            int overall = 0;
            int number;
            index = 0;
            int[] multipliers = { 6, 5, 7, 2, 3, 4, 5, 6, 7 };
            int[] NIPnumber = new int[10];
            if (nip.Length!=10)
            {
                return false;
            }
            if (!int.TryParse(nip,out number))
            {
                return false;
            }
            foreach (var numb in nip)
            {
                if (index<9)
                {
                    overall += int.Parse(numb.ToString()) * multipliers[index];
                    index++;
                }
                else
                {
                    if (overall%11!=numb)
                    {
                        return false;
                    }
                }
                
            }
            return true;
        }

        private void PrintData(Data data)
        {
            Console.Clear();
            if (data.PESEL.Length==11)
            {
                Console.WriteLine($"PESEL: {data.PESEL}");
                Console.WriteLine($"Imie i nazwisko: {data.FirstName} {data.LastName}");
                Console.WriteLine($"Data urodzenia: {data.DateOfBirth.Day}.{data.DateOfBirth.Month}." +
                    $"{data.DateOfBirth.Year}");
                Console.WriteLine($"Płeć: {data.Gender}");
                Console.WriteLine($"Email: {data.Email}");
                Console.WriteLine($"NIP: {data.NIP}");
            }
            else
            {
                Console.WriteLine("Nie ma w bazie kogoś takiego");
            }
        }

    }
}
