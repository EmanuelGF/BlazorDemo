using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DataModels
{

    public class WeatherForecastModel
    {
        public DayForecastModel[] Consolidated_weather { get; set; }
        public DateTime Sun_rise { get; set; }
        public DateTime Sun_set { get; set; }
        public string Title { get; set; }
        public string Timezone { get; set; }
    }
}
