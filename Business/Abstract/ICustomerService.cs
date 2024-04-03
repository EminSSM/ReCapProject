using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IDataResult<List<Customer>> TGetAllCustomers();
        IDataResult<Customer> TGetBy(int id);
        IResult TAdd(Customer customer);
        IResult TUpdate(Customer customer);
        IResult TDelete(Customer customer);
    }
}
