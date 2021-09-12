using System.ComponentModel.DataAnnotations;

namespace Store_Application.Domain.Enums

{
    public enum OrderState
    {
        [Display(Name = "نهایی نشده")]
        NotFinally = 0,
        [Display(Name = "در انتظار پرداخت")]
        WaitingForPay = 1,
        [Display(Name ="لغو شده")]
        Canceled = 2,
        [Display(Name ="تحویل شده")]
        Delivered = 3,
        [Display(Name = "در حال پردازش")]
        Processing = 4,
    }

}
