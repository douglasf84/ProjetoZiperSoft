using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public class ClientesPFController : Controller
    {
        private readonly IClientePFService _clientePFService;
        public ClientesPFController(IClientePFService clientePFService)
        {
            _clientePFService = clientePFService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientePFDTO>>> Get()
        {
            var clientePFs = await _clientePFService.GetAll();
            return Ok(clientePFs);
        }

        public async Task<IActionResult> Index()
        {
            return View(await _clientePFService.GetAll());
        }

        [HttpGet("{id}", Name = "GetClientePF")]
        public async Task<ActionResult<ClientePFDTO>> Get(int id)
        {
            var clientePF = await _clientePFService.GetById(id);

            if (clientePF == null)
            {
                return NotFound();
            }
            return Ok(clientePF);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ClientePFDTO clientePFDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _clientePFService.Create(clientePFDTO);

            return new CreatedAtRouteResult("GetClientePF",
                new { id = clientePFDTO.Id }, clientePFDTO);
        }


        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ClientePFDTO clientePFDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != clientePFDto.Id)
            {
                return BadRequest();
            }
            await _clientePFService.Update(clientePFDto);
            return Ok(clientePFDto);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ClientePF>> Delete(int id)
        {
            var clientePFDto = await _clientePFService.GetById(id);
            if (clientePFDto == null)
            {
                return NotFound();
            }
            await _clientePFService.Remove(id);
            return Ok(clientePFDto);
        }
    }
}
