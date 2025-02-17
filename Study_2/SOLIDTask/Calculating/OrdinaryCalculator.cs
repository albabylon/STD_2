using SOLIDTask.Calculating;

namespace SOLIDTask.Models
{
    public class OrdinaryCalculator : ICalculateInterest
    {
        private readonly Account account;

        public OrdinaryCalculator(Account account)
        {
            this.account = account;
        }

        /// <summary>
        /// расчет процентной ставки обычного аккаунта по правилам банка
        /// </summary>
        public void CalculateInterest()
        {
            account.Interest = account.Balance * 0.4;
            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance >= 1000)
                account.Interest -= account.Balance * 0.4;
        }
    }
}
