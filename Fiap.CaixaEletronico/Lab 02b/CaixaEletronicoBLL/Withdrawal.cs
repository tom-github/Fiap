using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoBLL
{
    public class Withdrawal
    {

        public enum enumMoneyValue
        {
            fifty = 50, Twenty = 20, Ten = 10, fife = 5, Two = 2
        }

        /// <summary>
        /// Calculate the amount of paper money to withdraw
        /// </summary>
        /// <param name="valueDrawee"></param>
        /// <param name="moneyValue"></param>
        /// <param name="amoutMoneyValue"></param>
        /// <returns>tuple containing amount paper money and value remainder value drawee to re-calculate if necessary</returns>
        public Tuple<int, int> Calculate(int valueDrawee, enumMoneyValue moneyValue, int? amoutMoneyValue)
        {
            int amountPaperMoney = 0;
            int remaindervalueDrawee = 0;

            switch (moneyValue)
            {
                case enumMoneyValue.fifty:
                    amountPaperMoney = amoutMoneyValue == null ? valueDrawee / 50 : (int)amoutMoneyValue;
                    remaindervalueDrawee = valueDrawee - amountPaperMoney * 50;
                    break;
                case enumMoneyValue.Twenty:
                    amountPaperMoney = amoutMoneyValue == null ? valueDrawee / 20 : (int)amoutMoneyValue;
                    remaindervalueDrawee = valueDrawee - amountPaperMoney * 20;
                    break;
                case enumMoneyValue.Ten:
                    amountPaperMoney = amoutMoneyValue == null ? valueDrawee / 10 : (int)amoutMoneyValue;
                    remaindervalueDrawee = valueDrawee - amountPaperMoney * 10;
                    break;
                case enumMoneyValue.fife:
                    amountPaperMoney = amoutMoneyValue == null ? valueDrawee / 5 : (int)amoutMoneyValue;
                    remaindervalueDrawee = valueDrawee - amountPaperMoney * 5;
                    break;
                case enumMoneyValue.Two:
                    amountPaperMoney = valueDrawee / 2;
                    remaindervalueDrawee = valueDrawee - amountPaperMoney * 2;
                    break;
            }

            if (remaindervalueDrawee < 0)
            {
                throw new Exception("Valor acima do esperado");
            }

            if (remaindervalueDrawee == 1)
            {
                throw new Exception("Valor não permitido para saque, não há cédulas de R$ 1,00");
            }

            return new Tuple<int, int>(amountPaperMoney, remaindervalueDrawee);
        }
    }
}
