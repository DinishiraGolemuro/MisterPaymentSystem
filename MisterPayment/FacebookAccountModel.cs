namespace MisterPayment
{
    public class FacebookAccountModel
    {
        public string PaymentSystemName => "FacebookPayment";

        public string Ip { get; set; }
        public int Port { get; set; }
        public string Password { get; set; }
        public double Value { get; set; }
    }
}