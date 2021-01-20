using System;

namespace PersonalInformations
{
    class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            int choice;
            DataManager dataManager = new DataManager();
            //Add new data
            //Get person data
            //Edit data
            //delete data
            while (!end)
            {
                Console.Clear();
                Console.WriteLine("1)Dodaj nową osobę");
                Console.WriteLine("2)Usuń dane");
                Console.WriteLine("3)Edytuj dane");
                Console.WriteLine("4)Pobierz dane...");
                Console.WriteLine("5)Zamknij program");
                int.TryParse(Console.ReadKey().ToString(), out choice);
                switch (choice)
                {
                    case 1:
                        dataManager.AddData();
                        break;
                    case 2:
                        dataManager.DeleteData();
                        break;
                    case 3:
                        dataManager.EditData();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("1)Wszystkie");
                        Console.WriteLine("2)Danej osoby");
                        Console.WriteLine("3)Mężczyzn");
                        Console.WriteLine("4)Kobiet");
                        Console.WriteLine("5)Z danego roku");
                        Console.WriteLine("6)Powrót");
                        int.TryParse(Console.ReadKey().ToString(), out choice);
                        switch (choice)
                        {
                            case 1:
                                dataManager.GetAllData();
                                break;
                            case 2:
                                dataManager.GetDataByPESEL();
                                break;
                            case 3:
                                dataManager.GetAllDataMale();
                                break;
                            case 4:
                                dataManager.GetAllDataFemale();
                                break;
                            case 5:
                                dataManager.GetAllDataByYear();
                                break;
                            default:
                                break;
                        }
                        choice = 4;
                        break;
                    case 5:
                        end = true;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
