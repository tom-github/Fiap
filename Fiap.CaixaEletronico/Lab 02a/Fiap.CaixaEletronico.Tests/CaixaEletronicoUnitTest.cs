using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CaixaEletronicoBLL;

namespace Fiap.CaixaEletronico.Tests
{
    [TestClass]
    public class CaixaEletronicoUnitTest
    {
        [TestMethod]
        public void Calculate()
        {
            Withdrawal calc = new Withdrawal();

            Tuple<int, int> tupleRemainder = calc.Calculate(219, Withdrawal.enumMoneyValue.fifty, null);

            Assert.AreEqual(4, tupleRemainder.Item1);

            tupleRemainder = calc.Calculate(tupleRemainder.Item2, Withdrawal.enumMoneyValue.Twenty, null);

            Assert.AreEqual(0, tupleRemainder.Item1);

            tupleRemainder = calc.Calculate(tupleRemainder.Item2, Withdrawal.enumMoneyValue.Ten, null);
            Assert.AreEqual(1, tupleRemainder.Item1);

            tupleRemainder = calc.Calculate(tupleRemainder.Item2, Withdrawal.enumMoneyValue.fife, null);
            Assert.AreEqual(1, tupleRemainder.Item1);

            tupleRemainder = calc.Calculate(tupleRemainder.Item2, Withdrawal.enumMoneyValue.Two, null);

            Assert.AreEqual(2, tupleRemainder.Item1);

        }
    }
}
