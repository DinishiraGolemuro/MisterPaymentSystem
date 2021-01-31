using System.Threading.Tasks;

namespace MisterPayment
{
    public class FacebookPaymentSystem
    {
        private FileSystemLogger _logger;

        public FacebookPaymentSystem(FileSystemLogger logger)
        {
            _logger = logger;
        }

        public async Task SendPayment(FacebookAccountModel accountModel)
        {
            /*
                тут логика по авторизации в аккаунте,
                просто представь, что она уже реализована
             */

            await _logger.Log($"Payment was sending by {accountModel.PaymentSystemName}.");
        }
    }
}