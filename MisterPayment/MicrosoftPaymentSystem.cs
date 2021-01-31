using System.Threading.Tasks;

namespace MisterPayment
{
    public class MicrosoftPaymentSystem
    {
        private FileSystemLogger _logger;

        public MicrosoftPaymentSystem(FileSystemLogger logger)
        {
            _logger = logger;
        }

        public async Task SendPayment(MicrosoftAccountModel accountModel)
        {
            /*
                тут логика по авторизации в аккаунте,
                просто представь, что она уже реализована
             */

            await _logger.Log($"Payment was sending by {accountModel.PaymentSystemName}.");
        }
    }
}