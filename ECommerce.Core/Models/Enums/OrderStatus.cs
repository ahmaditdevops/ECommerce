using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Core.Models.Enums
{

    public enum OrderStatus
    {
        [Display(Name = "Pending")]
        Pending,
        [Display(Name = "Processing")]
        Processing,
        [Display(Name = "Shipped")]
        Shipped,
        [Display(Name = "Delivered")]
        Delivered
    }
}
