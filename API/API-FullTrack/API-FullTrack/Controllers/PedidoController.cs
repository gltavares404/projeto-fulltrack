using API_FullTrack.Context;
using API_FullTrack.DTO;
using API_FullTrack.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace API_FullTrack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public PedidoController()
        {
            _dataContext = new DataContext();
        }

        // GET: api/<PedidoController>
        [HttpGet]
        public ActionResult<List<Pedido>> Get()
        {
            var pedidos = _dataContext.Pedido.ToList();
            return pedidos;
        }

        // GET api/<PedidoController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PedidoController>
        [HttpPost]
        public ActionResult<Pedido> Post([FromBody] PedidoRequest pedidoRequest)
        {
            if (ModelState.IsValid)
            {
                var pedido = clienteRequest.toModel();
                _dataContext.Cliente.Add(pedido);
                _dataContext.SaveChanges();
                return pedido;
            }
            return BadRequest(ModelState);
        }

        // PUT api/<PedidoController>/5
        [HttpPut]
        public ActionResult<Pedido> Put([FromBody] Pedido pedido)
        {
            var pedidoENulo = _dataContext.Pedido.FirstOrDefault(pedido) == null;
            if (pedidoENulo)
                ModelState.AddModelError("PedidoId", "Id do Pedido não encontrado!");

            if (ModelState.IsValid)
            {
                _dataContext.Pedido.Update(pedido);
                _dataContext.SaveChanges();
                return pedido;
            }
            return BadRequest(ModelState);

        }

        // DELETE api/PedidoController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var pedido = _dataContext.Pedido.Find(id);
            if (pedido == null)
                ModelState.AddModelError("PedidoId", "Id do Pedido não encontrado!");

            if (ModelState.IsValid)
            {
                _dataContext.Pedido.Remove(pedido);
                _dataContext.SaveChanges();
                return Ok();
            }
            return BadRequest(ModelState);
        }
    }
}
