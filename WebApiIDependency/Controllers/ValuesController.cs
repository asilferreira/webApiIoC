﻿using System.Web.Http;
using Unity.Attributes;

namespace WebApiIDependency.Controllers
{
    public class ValuesController : ApiController
    {
        [Dependency]
        public ITeste Teste { get; set; }

        // GET api/values
        
        public IHttpActionResult Get()
        {
            var texto = Teste.MeuTeste();
            return Ok(texto);
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
