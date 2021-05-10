using System;
using System.Linq;
using System.Threading.Tasks;
using BVS.Repository.Model;
using Microsoft.EntityFrameworkCore;

namespace BVS.Repository
{
    public interface ICustomerRepository
    {
        Task<Customer> Get(int Id);
        IQueryable<Customer> GetAll();
        Task<Customer> Add(Customer customer);
        Task<Customer> Update(Customer customer);
    }
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BVSContext _context;
        public CustomerRepository(BVSContext context)
        {
            _context = context;
        }
        public async Task<Customer> Add(Customer customer)
        {
            await _context.Customers.AddAsync(customer).ConfigureAwait(false);
            await _context.SaveChangesAsync().ConfigureAwait(false);
            return customer;
        }

        public async Task<Customer> Update(Customer customer)
        {
            _context.Update(customer);
            await _context.SaveChangesAsync().ConfigureAwait(false);

            return customer;
        }

        public async Task<Customer> Get(int id)
        {
            return await _context.Customers.SingleOrDefaultAsync(x => x.Id == id);
        }

        public IQueryable<Customer> GetAll()
        {
            return _context.Customers.AsQueryable();
        }
    }
}