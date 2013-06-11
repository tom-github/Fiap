using System;

namespace Fiap.CalculoImpostos.BLL
{
    public class IRPF
    {
        private decimal amount;

        public decimal EvaluateIRPF(decimal salary)
        {

            amount = 0;

            if (salary >= new decimal(1710.79) && salary <= new decimal(2563.92))
            {
                decimal diff = salary - new decimal(1710.80);
                decimal diffAliquotApplied = (diff * new decimal(7.5)) / 100;
                amount += Math.Round(diffAliquotApplied, 2);

            }
            else if (salary >= new decimal(2563.93) && salary <= new decimal(3418.61))
            {
                decimal diff = new decimal(2563.92) - new decimal(1710.79);
                decimal diffAliquotApplied = (diff * new decimal(7.5)) / 100;
                amount += Math.Round(diffAliquotApplied, 2);

                diff = salary - new decimal(2563.93);
                diffAliquotApplied = (diff * new decimal(15)) / 100;
                amount += Math.Round(diffAliquotApplied, 2);
            }

            else if (salary >= new decimal(3418.62) && salary <= new decimal(4271.62))
            {
                decimal diff = new decimal(2563.92) - new decimal(1710.79);
                decimal diffAliquotApplied = (diff * new decimal(7.5)) / 100;
                amount += Math.Round(diffAliquotApplied, 2);

                diff = new decimal(3418.61) - new decimal(2563.93);
                diffAliquotApplied = (diff * new decimal(15)) / 100;
                amount += Math.Round(diffAliquotApplied, 2);

                diff = salary - new decimal(3418.63);
                diffAliquotApplied = (diff * new decimal(22.5)) / 100;
                amount += Math.Round(diffAliquotApplied, 2);
            }


            else if (salary > new decimal(4271.62))
            {
                decimal diff = new decimal(2563.92) - new decimal(1710.79);
                decimal diffAliquotApplied = (diff * new decimal(7.5)) / 100;
                amount += Math.Round(diffAliquotApplied, 2);

                diff = new decimal(3418.61) - new decimal(2563.93);
                diffAliquotApplied = (diff * new decimal(15)) / 100;
                amount += Math.Round(diffAliquotApplied, 2);

                diff = new decimal(4271.62) - new decimal(3418.62);
                diffAliquotApplied = (diff * new decimal(22.5)) / 100;
                amount += Math.Round(diffAliquotApplied, 2);

                diff = salary - new decimal(4271.63);
                diffAliquotApplied = (diff * new decimal(27.5)) / 100;
                amount += Math.Round(diffAliquotApplied, 2);
            }

            return Math.Round(amount, 2);
        }
    }
}