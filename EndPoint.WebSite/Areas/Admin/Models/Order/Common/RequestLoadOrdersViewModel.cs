using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.WebSite.Areas.Admin.Models.Order.Common
{
    public class RequestLoadOrdersViewModel
    {
        public int Page { get; set; } = 1;
        public int Take { get; set; } = 10;
        public string Searchkey { get; set; }

        public int? UserId { get; set; } = null;
        public int? OrderId { get; set; } = null;
        public OrderStatesViewModel? State { get; set; }
        public DateTime? FromDateOrder { get; set; }
        public DateTime? ToDateOrder { get; set; }
        public DateTime? FromDatePay { get; set; }
        public DateTime? ToDatePay { get; set; }


        public void BindSearchValuesToFields()
        {

            string[] filters = new string[6];
            filters = Searchkey?.Split(',');

            if (filters != null && !string.IsNullOrEmpty(filters[0]))
                OrderId = int.Parse(filters[0]);

            if (filters != null && !string.IsNullOrEmpty(filters[1]))
                UserId = int.Parse(filters[1]);

            if (filters != null && !string.IsNullOrEmpty(filters[3]))
                FromDateOrder = DateTime.Parse(filters[3]);

            if (filters != null && !string.IsNullOrEmpty(filters[4]))
                ToDateOrder = DateTime.Parse(filters[4]);

            if (filters != null && !string.IsNullOrEmpty(filters[5]))
                FromDatePay = DateTime.Parse(filters[5]);

            if (filters != null && !string.IsNullOrEmpty(filters[6]))
                ToDatePay = DateTime.Parse(filters[6]);

            switch (filters?[2])
            {
                case "0":
                    State = OrderStatesViewModel.NotFinally;
                    break;
                case "1":
                    State = OrderStatesViewModel.WaitingForPay;
                    break;
                case "2":
                    State = OrderStatesViewModel.Canceled;
                    break;
                case "3":
                    State = OrderStatesViewModel.Delivered;
                    break;
                case "4":
                    State = OrderStatesViewModel.Processing;
                    break;
                case "5":
                    State = OrderStatesViewModel.Processing;
                    break;
            }
        }
    }
}
