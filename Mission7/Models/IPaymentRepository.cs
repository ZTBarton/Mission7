using System;
using System.Linq;

namespace Mission7.Models
{
    public interface IPaymentRepository
    {
        IQueryable<Payment> Payments { get; }

        void SavePayment(Payment payment);
    }
}
