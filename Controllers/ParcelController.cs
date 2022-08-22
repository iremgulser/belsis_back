using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace tst.Controllers
{
    [Route("api/[controller]")]
    public class ParcelController : Controller
    {
        public ParcelationContext _ParcelationContext;
        public ParcelController(ParcelationContext ParcelationContext)
        {
            _ParcelationContext = ParcelationContext;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<Models.Parcelation> Get()
        {
            return _ParcelationContext.Parcelation.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Models.Parcelation Get(int id)

        {
            return _ParcelationContext.Parcelation.SingleOrDefault(p => p.Id == id);


        }

        // POST api/values
        [HttpPost]
        public long Post([FromBody] Models.Parcelation value)
        {
            _ParcelationContext.Parcelation.Add(value);
            _ParcelationContext.SaveChanges();

            return value.Id;

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Models.Parcelation value)
        {
            var ent = _ParcelationContext.Parcelation.SingleOrDefault(p => p.Id == id);
            if (ent != null)
            {
                ent.City = value.City;
                ent.Town = value.Town;
                ent.Neighbourhood = value.Neighbourhood;

                _ParcelationContext.SaveChanges();
            }

        }


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var ent = _ParcelationContext.Parcelation.SingleOrDefault(p => p.Id == id);
            if (ent != null)
            {
                _ParcelationContext.Parcelation.Remove(ent);
                _ParcelationContext.SaveChanges();
            }
        }
    }
}
