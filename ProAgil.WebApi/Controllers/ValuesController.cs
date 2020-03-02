using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProAgil.WebApi.Data;
using ProAgil.WebApi.Model;

namespace ProAgil.WebApi.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public readonly DataContext _context;

        public ValuesController(DataContext context)
        {
            _context = context;

        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                 return Ok( _context.Clientes.ToList());
            }
            catch (System.Exception)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError,"Banco de dados falhou!");
            }
            
            
           
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Cliente> Get(int id)
        {
            return _context.Clientes.FirstOrDefault(x => x.ClienteId == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
