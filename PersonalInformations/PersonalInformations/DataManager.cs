using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalInformations
{
    public class DataManager
    {
        private DataService dataService;

        public DataManager()
        {
            dataService = new DataService();
        }

        public void AddData()
        {
            throw new NotImplementedException();
        }

        public void DeleteData()
        {
            throw new NotImplementedException();
        }

        public void EditData()
        {
            throw new NotImplementedException();
        }

        public ICollection<Data> GetAllDataByYear()
        {
            throw new NotImplementedException();
        }

        public ICollection<Data> GetAllDataFemale()
        {
            throw new NotImplementedException();
        }

        public ICollection<Data> GetAllDataMale()
        {
            throw new NotImplementedException();
        }

        public Data GetAllData()
        {
            throw new NotImplementedException();
        }

        public ICollection<Data> GetDataByFullName()
        {
            throw new NotImplementedException();
        }

        public Data GetDataByPESEL()
        {
            throw new NotImplementedException();
        }

    }
}
