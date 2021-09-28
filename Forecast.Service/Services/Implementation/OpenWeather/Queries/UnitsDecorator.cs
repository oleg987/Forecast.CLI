using Forecast.Service.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Service.Services.Implementation.OpenWeather.Queries
{
    public class UnitsDecorator : BaseQueryDecorator
    {
        public string Units { get; }
        public UnitsDecorator(IWeatherQuery baseQuery, string units) : base(baseQuery)
        {
            Units = units;
        }

        public override string GetQueryString()
        {
            return base.GetQueryString() + $"&units={Units}";
        }
    }
}
