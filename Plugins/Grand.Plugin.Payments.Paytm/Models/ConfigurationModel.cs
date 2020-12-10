using Grand.Framework.Localization;
using Grand.Framework.Mvc.ModelBinding;
using Grand.Framework.Mvc.Models;
using System.Collections.Generic;

namespace Grand.Plugin.Payments.Paytm.Models
{
    public class ConfigurationModel : BaseGrandModel, ILocalizedModel<ConfigurationModel.ConfigurationLocalizedModel>
    {
        public ConfigurationModel()
        {
            Locales = new List<ConfigurationLocalizedModel>();
        }

        public string ActiveStoreScopeConfiguration { get; set; }
        
        [GrandResourceDisplayName("Plugins.Payment.Paytm.DescriptionText")]
        public bool UseDefaultCallBack { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Paytm.MerchantId")]
        public string MerchantId { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Paytm.MerchantKey")] //Encryption Key
        public string MerchantKey { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Paytm.Website")]
        public string Website { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Paytm.IndustryTypeId")]//Payment URI
        public string IndustryTypeId { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Paytm.PaymentUrl")]
        public string PaymentUrl { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Paytm.CallBackUrl")]
        public string CallBackUrl { get; set; }

        [GrandResourceDisplayName("Plugins.Payments.Paytm.TxnStatusUrl")]
        public string TxnStatusUrl { get; set; }

        public IList<ConfigurationLocalizedModel> Locales { get; set; }

        #region Nested class

        public partial class ConfigurationLocalizedModel : ILocalizedModelLocal
        {
            public string LanguageId { get; set; }
            
            [GrandResourceDisplayName("Plugins.Payment.Paytm.DescriptionText")]
            public string DescriptionText { get; set; }
        }

        #endregion
    }
}