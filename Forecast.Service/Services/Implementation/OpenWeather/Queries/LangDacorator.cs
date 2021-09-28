using Forecast.Service.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Service.Services.Implementation.OpenWeather.Queries
{
    public class LangDacorator : BaseQueryDecorator
    {
        public string Lang { get; }

        public LangDacorator(IWeatherQuery baseQuery, string lang) : base(baseQuery)
        {
            Lang = lang;
        }

        public override string GetQueryString()
        {
            return base.GetQueryString() + $"&lang={Lang}";
        }

    }
}
