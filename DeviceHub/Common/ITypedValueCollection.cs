namespace Alkl.DeviceHub.Common
{
    public interface ITypedValueCollection
    {
        bool GetBool(string key);

        int GetInt(string key);

        double GetDouble(string key);

        string GetString(string key);
    }
}
