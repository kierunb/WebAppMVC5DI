using AutoMapper;
using AutoMapper.QueryableExtensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppMVC5DI.Models;

namespace WebAppMVC5DI.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IMapper _mapper;

        public CustomerRepository(IMapper mapper)
        {
            _mapper = mapper;
        }
        
        public string GetAll()
        {
            var customer = new Customer { Name = "Zenek", Age = 12 };
            var customerViewModel = _mapper.Map<CustomerViewModel>(customer);

            return $"{customerViewModel.Name} {customerViewModel.Age}";
        }
        //using AutoMapper.QueryableExtensions;
        public void Test(IQueryable list)
        {
            list.ProjectTo<CustomerViewModel>(_mapper.ConfigurationProvider);
        }
    }
}
