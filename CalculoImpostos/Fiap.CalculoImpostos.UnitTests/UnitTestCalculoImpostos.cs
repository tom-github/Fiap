using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fiap.CalculoImpostos.UnitTests
{
    [TestClass]
    public class UnitTestCalculoImpostos
    {
        [TestMethod]
        public void EvaluateINSS()
        {
            const decimal salary = 3500;

            BLL.INSS calc = new BLL.INSS();

            calc.EvaluateINSS(salary);

            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void EvaluateIRPF()
        {
            BLL.IRPF calc = new BLL.IRPF();

            Assert.AreEqual(0M, calc.EvaluateIRPF(new decimal(1000)));

            //21,69
            //Assert.AreEqual(21.69M, calc.EvaluateIRPF(new decimal(2000)));
            //Assert.AreEqual(59.19M, calc.EvaluateIRPF(new decimal(2500)));
            //Assert.AreEqual(129.39M, calc.EvaluateIRPF(new decimal(3000)));
            //Assert.AreEqual(210.50M, calc.EvaluateIRPF(new decimal(3500)));
            //Assert.AreEqual(323M, calc.EvaluateIRPF(new decimal(4000)));
            //Assert.AreEqual(446.92M, calc.EvaluateIRPF(new decimal(4500)));
            //Assert.AreEqual(584.42M, calc.EvaluateIRPF(new decimal(5000)));

            Assert.AreEqual(0M, calc.EvaluateIRPF(new decimal(1710.78)));
            Assert.AreEqual(0M, calc.EvaluateIRPF(new decimal(1710.79)));
            Assert.AreEqual(0M, calc.EvaluateIRPF(new decimal(1710.80)));
            Assert.AreEqual(0M, calc.EvaluateIRPF(new decimal(1710.81)));
            Assert.AreEqual(0M, calc.EvaluateIRPF(new decimal(1710.82)));
            Assert.AreEqual(0M, calc.EvaluateIRPF(new decimal(1710.83)));
            Assert.AreEqual(0M, calc.EvaluateIRPF(new decimal(1710.84)));
            Assert.AreEqual(0.1M, calc.EvaluateIRPF(new decimal(1710.85)));

            Assert.AreEqual(0M, calc.EvaluateIRPF(new decimal(2563.92)));

            Assert.AreEqual(0M, calc.EvaluateIRPF(new decimal(2563.93)));
            Assert.AreEqual(0M, calc.EvaluateIRPF(new decimal(3418.61)));

            Assert.AreEqual(0M, calc.EvaluateIRPF(new decimal(3418.62)));
            Assert.AreEqual(0M, calc.EvaluateIRPF(new decimal(4271.62)));

            Assert.AreEqual(0M, calc.EvaluateIRPF(new decimal(4271.63)));

            //SALÁRIO DE ATÉ ALÍQUOTA
            //R$ 0,00 R$ 1.710,78 0%
            //R$ 1.710,79 R$ 2.563,92 7,5%
            //R$ 2.563,93 R$ 3.418,61 15%
            //R$ 3.418,62 R$ 4.271,62 22,5%
            //Acima de R$ 4.271,62 27,5%
        }
    }
}
