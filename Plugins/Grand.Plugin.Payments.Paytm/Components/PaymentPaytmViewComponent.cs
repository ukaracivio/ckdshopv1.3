using Grand.Core;
using Grand.Plugin.Payments.Paytm.Models;
using Grand.Services.Configuration;
using Grand.Services.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Grand.Plugin.Payments.Paytm.Components
{
    [ViewComponent(Name = "PaymentPaytm")]
    public class PaymentPaytmViewComponent : ViewComponent
    {
        private readonly IWorkContext _workContext;
        private readonly ISettingService _settingService;
        private readonly IStoreContext _storeContext;

        public PaymentPaytmViewComponent(IWorkContext workContext,   
            ISettingService settingService,
            IStoreContext storeContext)
        {
            this._workContext = workContext;
            this._settingService = settingService;
            this._storeContext = storeContext;

        }

        public IViewComponentResult Invoke()
        {
            var model = new PaymentInfoModel()
            {

            };

            return View("~/Plugins/Payments.Paytm/Views/PaymentInfo.cshtml", model);
        }
    }
}