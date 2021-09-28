using Forecast.Service.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Service.Services.Implementation.OpenWeather.Queries
{
    public class QueryByCityId : IWeatherQuery
    {
        public int CityId { get; }

        public QueryByCityId(int cityId)
        {
            CityId = cityId;
        }

        public string GetQueryString()
        {
            return $"&id={CityId}";
        }
    }
}
