using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public class ClientePJService : IClientePJService
    {
        private IClientePJRepository _clientePJRepository;
        private readonly IMapper _mapper;

        public ClientePJService(IClientePJRepository clientePJRepository, IMapper mapper)
        {
            _clientePJRepository = clientePJRepository;
            _mapper = mapper;
        }

        public async Task Create(ClientePJDTO clientePJDTO)
        {
            var clientePJEntity = _mapper.Map<ClientePJ>(clientePJDTO);
            await _clientePJRepository.CreateAsync(clientePJEntity);
        }

        public async Task<ClientePJDTO> GetById(int? id)
        {
            var clientePJEntity = await _clientePJRepository.GetByIdAsync(id);
            return _mapper.Map<ClientePJDTO>(clientePJEntity);
        }

        public async Task<IEnumerable<ClientePJDTO>> GetClientesPJ()
        {
            var clientePJEntity = await _clientePJRepository.GetClientePJsAsync();
            return _mapper.Map<IEnumerable<ClientePJDTO>>(clientePJEntity);
        }

        public async Task Remove(int? id)
        {
            var clientePJEntity = _mapper.Map<ClientePJ>(id);
            await _clientePJRepository.RemoveAsync(clientePJEntity);

        }

        public Task Update(ClientePJDTO clientePJDTO)
        {
            throw new NotImplementedException();
        }
    }
}
