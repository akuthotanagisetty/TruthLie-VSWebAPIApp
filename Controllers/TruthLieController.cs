using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using VSWebAPI.Model;

namespace VSWebAPIApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TruthLieController : ControllerBase
    {
        //public var = new string[] { "Nagi Setty Akuthota", "Nagalakshmi Batchu", "Moksheet Sriram Akuthota", "Soumith Kumar Akuthota","Vijayamma Akuthota" };
        
         // GET: api/TruthLie
        [HttpGet]
        public string Get()
        {
            try
            {
                //return new string[] { "Nagi Setty Akuthota", "Nagalakshmi Batchu", "Moksheet Sriram Akuthota", "Soumith Kumar Akuthota","Vijayamma Akuthota" };
                Family family = new Family();
                var result = JsonConvert.SerializeObject(family.GetFamilyData());
                return result;
            }
            catch(Exception ee)
            {
                
                return  ee.Message ;
            }
        }

        // GET: api/TruthLie/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            Family family = new Family();
            var result = JsonConvert.SerializeObject(family.GetFamilyData(id));
            return result;
            //var members = new string[] { "Nagi Setty Akuthota", "Nagalakshmi Batchu", "Moksheet Sriram Akuthota", "Soumith Kumar Akuthota", "Vijayamma Akuthota" };
            //return members[id];
        }

        // POST: api/TruthLie
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/TruthLie/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
