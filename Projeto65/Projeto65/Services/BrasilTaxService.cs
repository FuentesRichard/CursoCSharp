using System;


namespace Projeto65.Services
{
    class BrasilTaxService
    {
        public double Tax(double amount)
        {
            if (amount <= 100.00)
            {
                return 0.2 * amount;
            }
            else
            {
                return 0.15 * amount;
            }
        }
    }
}
