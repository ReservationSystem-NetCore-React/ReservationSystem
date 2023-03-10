using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DomainEntities
{
    [Table("Reservation")]
    public class Reservation
    {
        //[Key]
        //Id = Reservation Id
        public int? Id { get; set; }
        public DateTime Starting { get; set; }
        public DateTime Ending { get; set; }
        public string Title { get; set; }
        //public int? FieldId { get; set; }
        public double Total { get; set; }
        public string PrimaryColor { get; set; }
        public string SecondaryColor { get; set; }
        public int CustomerId { get; set; }

        //public virtual Payment? Payment { get; set; }
        //public virtual Field? Field { get; set; }
        //public virtual Receipt? Receipt { get; set; }
    }
}
