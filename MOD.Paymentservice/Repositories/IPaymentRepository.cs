using MOD.Paymentservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MOD.Paymentservice.Repositories
{
    public interface IPaymentRepository
    {
        void Add(Payment item);
        public List<Payment> GetAll();
    }
}
