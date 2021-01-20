using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace PersonalInformations
{
    public class DataService : IDataService
    {
        List<Data> dataList = new List<Data>();
        private readonly string Path =@"C:\Users\User\source\GitHub\PersonalInformations\PersonalInformations\PersonalInformations\PersonData\DataStorage.json" ;

        public DataService()
        {
            UpdateList();
        }
        
        public void SaveData(Data data)
        {
            dataList.Add(data);

            var strResultJson = JsonConvert.SerializeObject(dataList);
            File.WriteAllText(Path, strResultJson);
            
        }

        public void DeleteData(Data data)
        {
            dataList.Remove(data);
            SaveData();

        }

        public List<Data> GetAllData()
        {

            UpdateList();

            return (dataList);
        }

        public List<Data> GetAllDataByYear(string year)
        {
            UpdateList();

            List<Data> datas = dataList.Where(i => i.YearOfBirth == year).ToList();

            return datas;                   
        }

        public List<Data> GetAllDataFemale()
        {
            UpdateList();

            List<Data> datas = dataList.Where(i => i.Gender == "Kobieta").ToList();

            return datas;
        }

        public List<Data> GetAllDataMale()
        {
            UpdateList();

            List<Data> datas = dataList.Where(i => i.Gender == "Mężczyzna").ToList();

            return datas;
        }
        
        public List<Data> GetDataByFullName(string name)
        {
            UpdateList();

            List<Data> datas = dataList.Where(i => i.FirstName + " " + i.LastName == name).ToList();

            return datas;
        }

        public Data GetDataByPESEL(string pesel)
        {
            UpdateList();

            Data data = dataList.Where(i => i.PESEL == pesel).FirstOrDefault();

            return data;
        }

        private void UpdateList()
        {
            string JsonString = File.ReadAllText(Path);
            dataList = JsonConvert.DeserializeObject<List<Data>>(JsonString);
        }

        private void SaveData()
        {
            var strResultJson = JsonConvert.SerializeObject(dataList);
            File.WriteAllText(Path, strResultJson);
        }
    }
}
