using System.ComponentModel.DataAnnotations;

namespace EndPoint.WebSite.Areas.Admin.Models.Order.Common
{
    public enum OrderStatesViewModel
    {
        [Display(Name ="نهایی نشده")]
        NotFinally = 0,
        [Display(Name ="در انتظار پرداخت")]
        WaitingForPay = 1,
        [Display(Name ="لغو شده")]
        Canceled = 2,
        [Display(Name ="تحویل داده شده")]
        Delivered = 3,
        [Display(Name ="درحال بررسی")]
        Processing = 4,
        [Display(Name = "وضعیت")]
        None = 5,
    }
}
