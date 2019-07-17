namespace AutinoConnect.Utility.Interfaces
{
    public interface IModelToQueryStringService
    {
        T Deserialize<T>(string input) where T : class;

        string Serialize<T>(T input) where T : class;
    }
}
