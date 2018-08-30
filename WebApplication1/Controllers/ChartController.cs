using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication1
{
    public class PieChartSerie
    {
        public string category { get; set; }
        public object value { get; set; }
    }
    public class PieChartData
    {
        public List<PieChartSerie> Series { get; set; }
    }
    public class PieController : ApiController
    {
        public PieChartData Get(int id)
        {
            return new PieChartData()
            {
                Series = new List<PieChartSerie>()
                {
                    new PieChartSerie() { category = "category1", value= 100},
                    new PieChartSerie() { category = "category2", value= 200}
                }
            };
        }
    }
    public class ChartController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public BarChartData Get(int id)
        {
            var res = new BarChartData()
            {
                Categories = new[] { "Mayo", "Junio", "Julio" },
                Series = new List<BarChartSerie>
                {
                    new BarChartSerie
                    { name="Bimbo", data = new object[] { 10, 20, 30} },
                    new BarChartSerie
                    {
                        name="Breddy",
                        data = new object[] { 100, 200, 300}
                    }
                }
            };
            return res;
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}