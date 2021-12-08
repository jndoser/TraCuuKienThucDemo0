namespace TraCuuKienThucDemo0.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DataAI")]
    public partial class DataAI
    {
        public int ID { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        public string Content { get; set; }
    }
}
