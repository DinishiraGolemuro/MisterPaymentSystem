namespace MisterPayment
{
    public class GoogleAccountModel
    {
        public string PaymentSystemName => "GooglePayment";

        public string ApiKey { get; set; }
        public double Value { get; set; }
    }
}