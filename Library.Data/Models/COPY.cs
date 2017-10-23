using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Models
{
    [Table("COPY")]
    public partial class COPY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COPY()
        {
            BORROW = new HashSet<BORROW>();
        }

        [Key]
        [StringLength(20)]
        public string Barcode { get; set; }

        [StringLength(50)]
        public string Location { get; set; }

        public int? StatusId { get; set; }

        [StringLength(15)]
        public string ISBN { get; set; }

        [StringLength(50)]
        public string library { get; set; }

        public virtual BOOK BOOK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BORROW> BORROW { get; set; }

        public virtual STATUS STATUS { get; set; }
    }
}
