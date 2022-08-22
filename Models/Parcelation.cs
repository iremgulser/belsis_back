using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace tst.Models
{
    public class Parcelation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public long Id { get; set; }
        public string City { get; set; }
        public string Town { get; set; }
        public string Neighbourhood { get; set; }
        public string WktString { get; set; }
    }
}


