using System.Threading.Tasks;

namespace MisterPayment
{
    public class GooglePaymentSystem
    {
        private FileSystemLogger _logger;

        public GooglePaymentSystem(FileSystemLogger logger)
        {
            _logger = logger;
        }

        public async Task SendPayment(GoogleAccountModel accountModel)
        {
            /*
                тут логика по авторизации в аккаунте,
                просто представь, что она уже реализована
             */

            await _logger.Log($"Payment was sending by {accountModel.PaymentSystemName}.");
        }
    }
}