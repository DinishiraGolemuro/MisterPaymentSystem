namespace MisterPayment
{
    public class MicrosoftAccountModel
    {
        public string PaymentSystemName => "MicrosoftPayment";

        public string Login { get; set; }
        public string Password { get; set; }
        public double Value { get; set; }
    }
}