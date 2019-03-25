using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chimerical.Conversions.Api.Services
{
    public interface ITimeExpiryDataCacheService<T>
    {
        T GetData(string key, Func<T> getter);

        Task<T> GetDataAsync(string key, Func<Task<T>> asyncGetter);
    }

    public class TimeExpiryDataCacheService<T> : ITimeExpiryDataCacheService<T>
    {
        private class Data<TD>
        {
            public Data(TimeSpan lifeTime, TD value)
            {
                _expiry = DateTime.Now.Add(lifeTime);
                Value = value;
            }

            private readonly DateTime _expiry;

            public TD Value { get; }

            public bool IsExpired => DateTime.Now > _expiry;
        }

        private readonly Dictionary<string, Data<T>> _dataDictionary;

        public TimeSpan LifeTime { get; }

        public TimeExpiryDataCacheService(TimeSpan lifeTime)
        {
            LifeTime = lifeTime;
            _dataDictionary = new Dictionary<string, Data<T>>();
        }

        public T GetData(string key, Func<T> getter)
        {
            var data = _dataDictionary[key];
            if (data == null || data.IsExpired)
            {
                _dataDictionary[key] = new Data<T>(LifeTime, getter());
            }

            return data != null ? data.Value : default(T);
        }

        public async Task<T> GetDataAsync(string key, Func<Task<T>> asyncGetter)
        {
            var data = _dataDictionary[key];
            if (data == null || data.IsExpired)
            {
                _dataDictionary[key] = new Data<T>(LifeTime, await asyncGetter());
            }

            return data != null ? data.Value : default(T);
        }
    }
}
