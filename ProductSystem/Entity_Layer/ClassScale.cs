using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity_Layer
{
    public class ClassScale
    {
        [Key]
        public Guid Id { get; set; }
       

        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        

        [ForeignKey("Color")]
        public Guid ColorId { get; set; }
        

    }
}
