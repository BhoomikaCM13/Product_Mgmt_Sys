using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entity_Layer
{
    public class Product
    {
        [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductId { get; set; }
        [Required]
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int ProductYear { get; set; }
        public int ChannelId { get; set; }
     
       public List<ClassScale> Class { get; set; }

        //[ForeignKey("Size")]
        //public Guid SizeId { get; set; }
       
        //public Size sizes { get; set; }
    }
}
