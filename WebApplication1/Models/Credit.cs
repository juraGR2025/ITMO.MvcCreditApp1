using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Credit
    {
        // ID кредита
        public virtual int CreditId { get; set; }
        // Название
        [DisplayName("Название")]
        public virtual string Head { get; set; }
        // Период, на который выдается кредит
        [DisplayName("Период")]
        public virtual int Period { get; set; }
        // Максимальная сумма кредита
        [DisplayName("Максимальная сумма")]
        public virtual int Sum { get; set; }
        // Процентная ставка
        [Required]
        [DisplayName("Процентная ставка")]
        public virtual int Procent { get; set; }
    }
}