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
    public class CustomerAccountProcessManager : ICustomerAccountProcessService
    {
        private readonly ICustomerAccountProcessDal _customerAccountProcessDal;

        public CustomerAccountProcessManager(ICustomerAccountProcessDal customerAccountProcessDal)
        {
            _customerAccountProcessDal = customerAccountProcessDal;
        }

        public void TDelete(CustommerAccountProcess t)
        {
            _customerAccountProcessDal.Delete(t);
        }

        public CustommerAccountProcess TGetById(int id)
        {
            return _customerAccountProcessDal.GetById(id);
        }

        public List<CustommerAccountProcess> TGetist()
        {
            return _customerAccountProcessDal.Getist();
        }

        public void TInsert(CustommerAccountProcess t)
        {
            _customerAccountProcessDal.Insert(t);
        }

        public void TUpdate(CustommerAccountProcess t)
        {
            _customerAccountProcessDal.Update(t);
        }
    }
}
