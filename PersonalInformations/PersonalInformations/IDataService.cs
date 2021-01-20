using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalInformations
{
    public interface IDataService
    {
        void SaveData(Data data);
        void DeleteData(string path);
        Data GetDataByPESEL(string pesel);
        ICollection<Data> GetAllData();
        ICollection<Data> GetDataByFullName(string name);
        ICollection<Data> GetAllDataMale();
        ICollection<Data> GetAllDataFemale();
        ICollection<Data> GetAllDataByYear();
    }
}
