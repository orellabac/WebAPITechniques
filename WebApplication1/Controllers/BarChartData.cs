using System.Collections.Generic;

namespace WebApplication1
{
    public class BarChartData
    {
        public string[] Categories { get; set; }

        public List<BarChartSerie> Series { get; set; }
    }
}