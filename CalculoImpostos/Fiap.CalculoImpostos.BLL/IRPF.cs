using System;
using System.Linq;

namespace Fiap.CalculoImpostos.BLL
{
    public class IRPF
    {
        private decimal amoununt;

        public decimal EvaluateIRPF(decimal salary)
        {

            amoununt = 0;

            if (salary >= new decimal(1710.79) && salary <= new decimal(2563.92))
            {
                decimal diff = salary - new decimal(1710.79);
                decimal diffAiquotaApplied = (diff * new decimal(7.5)) / 100;
                amoununt += diffAiquotaApplied;

            }
            else if (salary >= new decimal(2563.93) && salary <= new decimal(3418.61))
            {
                decimal diff = salary - new decimal(2563.93);
                decimal diffAiquotaApplied = (diff * new decimal(15)) / 100;
                amoununt += diffAiquotaApplied;

                diff = salary - new decimal(3418.62);
                diffAiquotaApplied = (diff * new decimal(22.5)) / 100;
                amoununt += diffAiquotaApplied;
            }

            else if (salary >= new decimal(3418.62) && salary <= new decimal(4271.62))
            {
                decimal diff = new decimal(2563.92) - new decimal(1710.79);
                decimal diffAiquotaApplied = (diff * new decimal(7.5)) / 100;
                amoununt += diffAiquotaApplied;

                diff = new decimal(3418.61) - new decimal(2563.93);
                diffAiquotaApplied = (diff * new decimal(15)) / 100;
                amoununt += diffAiquotaApplied;

                diff = salary - new decimal(3418.62);
                diffAiquotaApplied = (diff * new decimal(22.5)) / 100;
                amoununt += diffAiquotaApplied;
            }


            else if (salary > new decimal(4271.62))
            {
                decimal diff = new decimal(2563.92) - new decimal(1710.79);
                decimal diffAiquotaApplied = (diff * new decimal(7.5)) / 100;
                amoununt += diffAiquotaApplied;

                diff = new decimal(3418.61) - new decimal(2563.93);
                diffAiquotaApplied = (diff * new decimal(15)) / 100;
                amoununt += diffAiquotaApplied;

                diff = new decimal(4271.62) - new decimal(3418.62);
                diffAiquotaApplied = (diff * new decimal(22.5)) / 100;
                amoununt += diffAiquotaApplied;

                diff = new decimal(4271.63);
                diffAiquotaApplied = (diff * new decimal(27.5)) / 100;
                amoununt += diffAiquotaApplied;
            }

            return System.Math.Round(amoununt, 2);
        }
    }
}