namespace Fiap.CalculoImpostos.BLL
{
    public class INSS
    {
        public decimal EvaluateINSS(decimal salary)
        {
            return salary * 11 / 100;
        }
    }
}
