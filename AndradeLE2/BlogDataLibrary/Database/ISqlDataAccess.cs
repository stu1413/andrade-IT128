namespace BlogDataLibrary.Database
{
    public interface ISqlDataAccess
    {
        List<T> LoadData<T, U>(string sqlSatement, U parameters, string connectionStringName, bool isStoredProcedure);
        void SaveData<T, U>(string sqlSatement, U parameters, string connectionStringName, bool isStoredProcedure);
    }
}