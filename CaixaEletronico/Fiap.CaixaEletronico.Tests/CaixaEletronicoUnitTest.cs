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

            Tuple<int, int> tupleRemainder = calc.Calculate(219, Withdrawal.enumCashValue.fifty);

            Assert.AreEqual(4, tupleRemainder.Item1);

            tupleRemainder = calc.Calculate(tupleRemainder.Item2, Withdrawal.enumCashValue.Twenty);

            Assert.AreEqual(0, tupleRemainder.Item1);

            tupleRemainder = calc.Calculate(tupleRemainder.Item2, Withdrawal.enumCashValue.Ten);
            Assert.AreEqual(1, tupleRemainder.Item1);

            tupleRemainder = calc.Calculate(tupleRemainder.Item2, Withdrawal.enumCashValue.fife);
            Assert.AreEqual(1, tupleRemainder.Item1);

            tupleRemainder = calc.Calculate(tupleRemainder.Item2, Withdrawal.enumCashValue.Two);

            Assert.AreEqual(2, tupleRemainder.Item1);

        }
    }
}
