using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DomainEntities
{
    [Table("Payment")]
    public class Payment
    {
        [Key]
        public int? PaymentId { get; set; }
        //Id = Reservation Id
        public int Id { get; set; }
        public double TotalAmount { get; set; }
        public DateTime PaymentDate { get; set; }

        public virtual Receipt Receipt { get; set; }
        public virtual Reservation Reservation { get; set; }

    }
}
