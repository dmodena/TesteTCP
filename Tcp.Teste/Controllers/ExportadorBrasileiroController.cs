using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Tcp.Teste.Api.Data;
using Tcp.Teste.Api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Tcp.Teste.Api.Controllers
{
    [Route("api/br/exportador")]
    [ApiController]
    public class ExportadorBrasileiroController : ControllerBase
    {
        private TestDb _db;

        public ExportadorBrasileiroController()
        {
            _db = TestDb.GetInstance();
        }

        // GET: api/br/exportador
        [HttpGet]
        public ActionResult<ICollection<ExportadorBrasileiro>> Get()
        {
            var collection = _db.GetAllExportadorBrasileiro();

            return Ok(collection);
        }

        // GET api/br/exportador/5
        [HttpGet("{id}")]
        public ActionResult<ExportadorBrasileiro> Get(int id)
        {
            var exportador = _db.GetExportadorBrasileiroById(id);

            return Ok(exportador);
        }

        // POST api/br/exportador
        [HttpPost]
        public ActionResult Post([FromBody] ExportadorBrasileiro item)
        {
            try
            {
                // TODO validate item
                _db.AddExportadorBrasileiro(item);
                return Created($"api/br/exportador/{item.Id}", item);
            }
            catch (Exception ex)
            {
                // TODO log error
                return BadRequest(ex.Message);
            }
        }

        // PUT api/br/exportador/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] ExportadorBrasileiro item)
        {
            try
            {
                // TODO validate item
                _db.UpdateExportadorBrasileiro(id, item);
                return Ok(item);
            }
            catch (Exception ex)
            {
                // TODO log error
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/br/exportador/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _db.DeleteExportadorBrasileiro(id);
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
