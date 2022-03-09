using System;
using System.Collections.Generic;
using System.Text;

namespace automaçãoDeContrato.Service
{
    interface IOnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
