using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public class ClientesPJController : ControllerBase
    {
        private readonly IClientePJService _clientePjService;
        public ClientesPJController(IClientePJService clientePjService)
        {
            _clientePjService = clientePjService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientePJDTO>>> Get()
        {
            var clientePjs = await _clientePjService.GetAll();
            return Ok(clientePjs);
        }

        [HttpGet("{id}", Name = "GetClientePJ")]
        public async Task<ActionResult<ClientePJ>> Get(int id)
        {
            var clientePj = await _clientePjService.GetById(id);

            if (clientePj == null)
            {
                return NotFound();
            }
            return Ok(clientePj);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ClientePJDTO clientePjDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _clientePjService.Create(clientePjDTO);

            return new CreatedAtRouteResult("GetClientePJ",
                new { id = clientePjDTO.Id }, clientePjDTO);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ClientePJDTO clientePjDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != clientePjDto.Id)
            {
                return BadRequest();
            }
            await _clientePjService.Update(clientePjDto);
            return Ok(clientePjDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ClientePJ>> Delete(int id)
        {
            var clientePjDto = await _clientePjService.GetById(id);
            if (clientePjDto == null)
            {
                return NotFound();
            }
            await _clientePjService.Remove(id);
            return Ok(clientePjDto);
        }
    }
}
