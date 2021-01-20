using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalInformations
{
    public interface IDataService
    {
        void SaveData(Data data);
        void DeleteData(Data data);
        Data GetDataByPESEL(string pesel);
        List<Data> GetAllData();
        List<Data> GetDataByFullName(string name);
        List<Data> GetAllDataMale();
        List<Data> GetAllDataFemale();
        List<Data> GetAllDataByYear(string year);
    }
}
