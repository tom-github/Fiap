using Fiap.CalculoImpostos.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fiap.CalculoImpostos.UnitTests
{
    [TestClass]
    public class UnitTestCalculoImpostos
    {
        [TestMethod]
        public void EvaluateINSS()
        {
            INSS calc = new INSS();

            Assert.AreEqual(110M, calc.EvaluateINSS(new decimal(1000)));
            Assert.AreEqual(220M, calc.EvaluateINSS(new decimal(2000)));
            Assert.AreEqual(275M, calc.EvaluateINSS(new decimal(2500)));
            Assert.AreEqual(330M, calc.EvaluateINSS(new decimal(3000)));
            Assert.AreEqual(385M, calc.EvaluateINSS(new decimal(3500)));
            Assert.AreEqual(440M, calc.EvaluateINSS(new decimal(4000)));
            Assert.AreEqual(495M, calc.EvaluateINSS(new decimal(4500)));
            Assert.AreEqual(550M, calc.EvaluateINSS(new decimal(5000)));
        }

        [TestMethod]
        public void EvaluateIRPF()
        {
            IRPF calc = new IRPF();

            Assert.AreEqual(0M, calc.EvaluateIRPF(new decimal(1000)));
            Assert.AreEqual(21.69M, calc.EvaluateIRPF(new decimal(2000)));
            Assert.AreEqual(59.19M, calc.EvaluateIRPF(new decimal(2500)));
            Assert.AreEqual(129.39M, calc.EvaluateIRPF(new decimal(3000)));
            Assert.AreEqual(210.49M, calc.EvaluateIRPF(new decimal(3500)));
            Assert.AreEqual(322.99M, calc.EvaluateIRPF(new decimal(4000)));
            Assert.AreEqual(446.90M, calc.EvaluateIRPF(new decimal(4500)));
            Assert.AreEqual(584.40M, calc.EvaluateIRPF(new decimal(5000)));
        }
    }
}
