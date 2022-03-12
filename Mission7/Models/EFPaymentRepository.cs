﻿using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Mission7.Models
{
    public class EFPaymentRepository : IPaymentRepository
    {

        private BookstoreContext context;

        public EFPaymentRepository (BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Payment> Payments => context.Payments.Include(x => x.Lines).ThenInclude(x => x.Book);

        public void SavePayment(Payment payment)
        {
            context.AttachRange(payment.Lines.Select(x => x.Book));

            if (payment.PaymentId == 0)
            {
                context.Payments.Add(payment);
            }

            context.SaveChanges();
        }
    }
}