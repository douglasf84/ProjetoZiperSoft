using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoZiperSoft
{
    public class EnderecoService : IEnderecoService
    {
        private IEnderecoRepoitory _enderecoRepoitory;
        private readonly Mapper _mapper;

        public EnderecoService(IEnderecoRepoitory enderecoRepoitory, Mapper mapper)
        {
            _enderecoRepoitory = enderecoRepoitory;
            _mapper = mapper;
        }

        public async Task Create(EnderecoDTO enderecoDTO)
        {
            var enderecoEntiy = _mapper.Map<Endereco>(enderecoDTO);
            await _enderecoRepoitory.CreateAsync(enderecoEntiy);
        }

        public async Task<EnderecoDTO> GetById(int? id)
        {
            var enderecoEntity = await _enderecoRepoitory.GetByIdAsync(id);
            return _mapper.Map<EnderecoDTO>(enderecoEntity);
        }

        public async Task<IEnumerable<EnderecoDTO>> GetEnderecos()
        {
            var enderecoEntity = await _enderecoRepoitory.GetEnderecoAsync();
            return _mapper.Map<IEnumerable<EnderecoDTO>>(enderecoEntity);
        }

        public async Task Remove(int? id)
        {
            var enderecoEntity = await _enderecoRepoitory.GetByIdAsync(id);
            _mapper.Map<Endereco>(enderecoEntity);
        }

        public async Task Update(EnderecoDTO enderecoDTO)
        {
            var enderecoEntiy = _mapper.Map<Endereco>(enderecoDTO);
            await _enderecoRepoitory.UpdateAsync(enderecoEntiy);
        }
    }
}
