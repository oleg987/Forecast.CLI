using Forecast.Service.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Service.Services.Implementation.OpenWeather.Queries
{
    public abstract class BaseQueryDecorator : IWeatherQuery
    {
        protected IWeatherQuery _baseQuery;

        protected BaseQueryDecorator(IWeatherQuery baseQuery)
        {
            _baseQuery = baseQuery;
        }

        public virtual string GetQueryString()
        {
            return _baseQuery.GetQueryString();
        }
    }
}
