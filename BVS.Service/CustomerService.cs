using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BVS.DTO;
using BVS.Repository;
using BVS.Repository.Model;
using Microsoft.EntityFrameworkCore;

namespace BVS.Service
{
    public interface ICustomerService
    {
        Task<CustomerDTO> Get(int Id);
        Task<IEnumerable<CustomerDTO>> GetAll();
        Task<CustomerDTO> Add(CustomerDTO customer);
        Task<CustomerDTO> Update(CustomerDTO customer);
    }
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<CustomerDTO> Add(CustomerDTO customer)
        {
            var result = await _repository.Add(_mapper.Map<Customer>(customer)).ConfigureAwait(false);
            return _mapper.Map<CustomerDTO>(result);
        }

        public async Task<CustomerDTO> Get(int Id)
        {
            var result = await _repository.Get(Id).ConfigureAwait(false);
            return _mapper.Map<CustomerDTO>(result);
        }

        public async Task<IEnumerable<CustomerDTO>> GetAll()
        {
            var result = await _repository.GetAll().ToListAsync().ConfigureAwait(false);
            return _mapper.Map<IEnumerable<CustomerDTO>>(result);
        }

        public async Task<CustomerDTO> Update(CustomerDTO customer)
        {
            var result = await _repository.Update(_mapper.Map<Customer>(customer)).ConfigureAwait(false);
            return _mapper.Map<CustomerDTO>(result);
        }
    }
}