using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PersonalInformations
{
    public class DataService : IDataService
    {
        List<Data> dataList = new List<Data>();
        private string Path =@"C:\Users\User\source\GitHub\PersonalInformations\PersonalInformations\PersonalInformations\PersonData\DataStorage.json" ;
        public void SaveData(Data data)
        {
            var strResultJson = JsonConvert.SerializeObject(data);
            Console.WriteLine(strResultJson);
        }

        public void DeleteData(string path)
        {
            throw new NotImplementedException();
        }

        public List<Data> GetAllData()
        {

            throw new NotImplementedException();
            
        }

        public List<Data> GetAllDataByYear()
        {
            throw new NotImplementedException();
        }

        public List<Data> GetAllDataFemale()
        {
            throw new NotImplementedException();
        }

        public List<Data> GetAllDataMale()
        {
            throw new NotImplementedException();
        }

        public List<Data> GetDataByFullName(string name)
        {
            throw new NotImplementedException();
        }

        public Data GetDataByPESEL(string pesel)
        {
            throw new NotImplementedException();
        }

        
    }
}
