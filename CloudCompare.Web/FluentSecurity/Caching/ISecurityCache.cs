using CloudCompare.Web.FluentSecurity.ServiceLocation;

namespace CloudCompare.Web.FluentSecurity.Caching
{
    public interface ISecurityCache
    {
        T Get<T>(string cacheKey, Lifecycle lifecycle);
        void Store<T>(T item, string cacheKey, Lifecycle lifecycle);
        void Clear(Lifecycle lifecycle);
    }
}