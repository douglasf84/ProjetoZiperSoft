using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public class ClientePFService : IClientePFService
    {
        private IClientePFRepository _clientePFRepository;
        private readonly IMapper _mapper;

        public ClientePFService(IClientePFRepository clientePFRepository, IMapper mapper)
        {
            _clientePFRepository = clientePFRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ClientePFDTO>> GetAll()
        {
            var clientesPFEntity = await _clientePFRepository.GetClientePFsAsync();
            return _mapper.Map<IEnumerable<ClientePFDTO>>(clientesPFEntity);
        }

        public async Task<ClientePFDTO> GetById(int? id)
        {
            var clientesPFEntity = await _clientePFRepository.GetByIdAsync(id);
            return _mapper.Map<ClientePFDTO>(clientesPFEntity);
        }

        public async Task Create(ClientePFDTO clientePFDTO)
        {
            var clientesPFEntity = _mapper.Map<ClientePF>(clientePFDTO);
            await _clientePFRepository.CreateAsync(clientesPFEntity);
        }

        public async Task Update(ClientePFDTO clientePFDTO)
        {
            var clientesPFEntity = _mapper.Map<ClientePF>(clientePFDTO);
            await _clientePFRepository.UpdateAsync(clientesPFEntity);
        }

        public async Task Remove(int? id)
        {
            var clientesPFEntity = _mapper.Map<ClientePF>(id);
            await _clientePFRepository.RemoveAsync(clientesPFEntity);
        }
    }
}
