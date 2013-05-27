using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaEletronicoBLL
{
    public class Withdrawal
    {
        public enum enumCashValue
        {
            fifty = 50, Twenty = 20, Ten = 10, fife = 5, Two = 2
        }

        public Tuple<int, int> Calculate(int valueDrawee, enumCashValue cashValue)
        {


            int remainder = 0;
            int remaindervalueDrawee = 0;

            switch (cashValue)
            {
                case enumCashValue.fifty:
                    remainder = valueDrawee / 50;
                    remaindervalueDrawee = valueDrawee - remainder * 50;
                    break;
                case enumCashValue.Twenty:
                    remainder = valueDrawee / 20;
                    remaindervalueDrawee = valueDrawee - remainder * 20;
                    break;
                case enumCashValue.Ten:
                    remainder = valueDrawee / 10;
                    remaindervalueDrawee = valueDrawee - remainder * 10;
                    break;
                case enumCashValue.fife:
                    remainder = valueDrawee / 5;
                    remaindervalueDrawee = valueDrawee - remainder * 5;
                    break;
                case enumCashValue.Two:
                    remainder = valueDrawee / 2;
                    remaindervalueDrawee = valueDrawee - remainder * 2;
                    break;
            }

            Tuple<int, int> tupleRemainder = new Tuple<int, int>(remainder, remaindervalueDrawee);

            return tupleRemainder;
        }
    }
}
