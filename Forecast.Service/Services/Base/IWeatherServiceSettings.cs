using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forecast.Service.Services.Base
{
    public interface IWeatherServiceSettings
    {
        string Key { get; }
        string BaseUrl { get; }
    }
}
