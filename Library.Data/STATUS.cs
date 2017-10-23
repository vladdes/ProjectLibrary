using Library.Data.Models;

namespace Library.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class STATUS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STATUS()
        {
            COPY = new HashSet<COPY>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int statusid { get; set; }

        [Column("status")]
        [StringLength(50)]
        public string status1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COPY> COPY { get; set; }
    }
}
