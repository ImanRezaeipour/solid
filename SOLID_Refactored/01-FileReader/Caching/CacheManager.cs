namespace _01_FileReader.Caching
{
    public class CacheManager : ICacheManager
    {
        public void AddOrUpdate(string key, string value)
        {
        }

        public bool Contains(string key)
        {
            return false;
        }

        public string Get(string key)
        {
            return "....";
        }
    }
}