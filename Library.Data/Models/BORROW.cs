using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Models
{
    [Table("BORROW")]
    public partial class BORROW
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Barcode { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(13)]
        public string PersonId { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime BorrowDate { get; set; }

        public DateTime? ToBeReturnedDate { get; set; }

        public DateTime? ReturnDate { get; set; }

        public virtual BORROWER BORROWER { get; set; }

        public virtual COPY COPY { get; set; }
    }
}
