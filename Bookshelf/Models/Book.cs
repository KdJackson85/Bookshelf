using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;


namespace Bookshelf.Models
{
    public class Book
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime PublishedDate { get; set; }
        public int Description { get; set; }
        public string ISBN { get; set; }


        [ForeignKey("Catagory")]
        public int CatagoryID { get; set; }
        public virtual Catagory Catagory { get; set; }
    }
}