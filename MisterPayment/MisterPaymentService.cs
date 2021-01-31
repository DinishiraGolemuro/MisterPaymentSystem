using System.Threading.Tasks;

namespace MisterPayment
{
    public class MisterPaymentService
    {
        public async Task SendPayment(PaymentSystemType paymentSystemType, double value)
        {
            var fileLogger = new FileSystemLogger(@"C:\MisterPaymentLogger.txt");

            switch (paymentSystemType)
            {
                case PaymentSystemType.Microsoft:

                    var microsoftPaymentSystem = new MicrosoftPaymentSystem(fileLogger);

                    var microsoftAccount = new MicrosoftAccountModel
                    {
                        Login = "myTestLogin@microsoft.com",
                        Password = "myVerySecretPassword",
                        Value = 666,
                    };

                    await microsoftPaymentSystem.SendPayment(microsoftAccount);

                    break;

                case PaymentSystemType.Google:

                    var googlePaymentSystem = new GooglePaymentSystem(fileLogger);

                    var googleAccount = new GoogleAccountModel
                    {
                        ApiKey = "my api key",
                        Value = value,
                    };

                    await googlePaymentSystem.SendPayment(googleAccount);

                    break;

                case PaymentSystemType.Facebook:

                    var facebookPaymentSystem = new FacebookPaymentSystem(fileLogger);

                    var facebookAccount = new FacebookAccountModel
                    {
                        Ip = "127.0.0.1",
                        Port = 666,
                        Password = "myVerySecretPassword",
                        Value = value,
                    };

                    await facebookPaymentSystem.SendPayment(facebookAccount);

                    break;

                default: break;
            }
        }
    }
}