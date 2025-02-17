using SOLIDTask.Calculating;

namespace SOLIDTask.Models
{
    public class SalaryCalculator : ICalculateInterest
    {
        private readonly Account account;

        public SalaryCalculator(Account account)
        {
            this.account = account;
        }

        /// <summary>
        /// расчет процентной ставк зарплатного аккаунта по правилам банка
        /// </summary>
        public void CalculateInterest()
        {
            account.Interest = account.Balance * 0.5;
        }
    }
}
