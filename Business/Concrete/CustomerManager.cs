using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerdal;

        public CustomerManager(ICustomerDal customerdal)
        {
            _customerdal = customerdal;
        }

        public IResult TAdd(Customer customer)
        {
            _customerdal.Add(customer);
            return new SuccessResult("Müşteri başarıyla eklendi.");
        }

        public IResult TDelete(Customer customer)
        {
            _customerdal.Delete(customer);
            return new SuccessResult("Müşteri başarıyla silindi.");
        }

        public IDataResult<List<Customer>> TGetAllCustomers()
        {
            return new SuccessDataResult<List<Customer>>(_customerdal.GetAll(), "Tüm müşteriler listelendi");
        }

        public IDataResult<Customer> TGetBy(int id)
        {
            return new SuccessDataResult<Customer>(_customerdal.GetBy(x => x.Id == id));
        }

        public IResult TUpdate(Customer customer)
        {
            _customerdal.Update(customer);
            return new SuccessResult();
        }
    }
}
