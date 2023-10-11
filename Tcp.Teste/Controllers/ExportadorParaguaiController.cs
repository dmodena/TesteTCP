using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Tcp.Teste.Api.Models;
using Tcp.Teste.Api.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tcp.Teste.Api.Controllers
{
    [Route("api/pr/exportador")]
    [ApiController]
    public class ExportadorParaguaiController : ControllerBase
    {
        private ExportadorParaguaiRepository _repository;

        public ExportadorParaguaiController()
        {
            _repository = new ExportadorParaguaiRepository();
        }

        // GET: api/pr/exportador
        [HttpGet]
        public ActionResult<ICollection<ExportadorParaguai>> Get()
        {
            var collection = _repository.GetAll();

            return Ok(collection);
        }

        // GET api/pr/exportador/5
        [HttpGet("{id}")]
        public ActionResult<ExportadorParaguai> Get(int id)
        {
            var exportador = _repository.GetById(id);

            return Ok(exportador);
        }

        // POST api/pr/exportador
        [HttpPost]
        public ActionResult Post([FromBody] ExportadorParaguai item)
        {
            try
            {
                // TODO validate item
                _repository.Add(item);
                return Created($"api/br/exportador/{item.Id}", item);
            }
            catch (Exception ex)
            {
                // TODO log error
                return BadRequest(ex.Message);
            }
        }

        // PUT api/pr/exportador/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ExportadorParaguai item)
        {
            try
            {
                // TODO validate item
                _repository.Update(id, item);
                return Ok(item);
            }
            catch (Exception ex)
            {
                // TODO log error
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/pr/exportador/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _repository.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                // TODO log error
                return BadRequest(ex.Message);
            }
        }
    }
}
