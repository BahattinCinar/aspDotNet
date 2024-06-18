using aspDotNet.BusiniessLayer.Abstract;
using aspDotNet.DataAccsessLayer.Abstract;
using aspDotNet.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aspDotNet.BusiniessLayer.Concrate
{
    public class CustomerAccountManager : ICustomerAccountService
    {
        private readonly ICustomerAccountDal _customerAccountDal;

        public CustomerAccountManager(ICustomerAccountDal customerAccountDal)
        {
            _customerAccountDal = customerAccountDal;
        }

        public void TDelete(CustommerAccount t)
        {
            _customerAccountDal.Delete(t);
        }

        public CustommerAccount TGetById(int id)
        {
            return _customerAccountDal.GetById(id);
        }

        public List<CustommerAccount> TGetist()
        {
            return _customerAccountDal.Getist();
        }

        public void TInsert(CustommerAccount t)
        {
            _customerAccountDal.Insert(t);
        }

        public void TUpdate(CustommerAccount t)
        {
            _customerAccountDal.Update(t);
        }
    }
}
