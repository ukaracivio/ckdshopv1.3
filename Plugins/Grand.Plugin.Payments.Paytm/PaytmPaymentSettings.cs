using Grand.Core.Configuration;

namespace Grand.Plugin.Payments.Paytm
{
    public class PaytmPaymentSettings : ISettings
    {
        public string MerchantId { get; set; }
        public string MerchantKey { get; set; }
        public string Website { get; set; }
        public string IndustryTypeId { get; set; }
        public string PaymentUrl { get; set; }
        public string CallBackUrl { get; set; }
        public string TxnStatusUrl { get; set; }
        public bool UseDefaultCallBack { get; set; }
        public string PdtToken { get; set; }
        public decimal AdditionalFee { get; set; }

        public bool AdditionalFeePercentage { get; set; }
    }
}
