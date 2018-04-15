using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Book
    {
        public Book()
        {
            AuthorList = new List<Author>();
        }
        public int Id { get; set; }
        [Required]
        public String Title { get; set; }
        [Required]
        public String ISBN { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public String Year { get; set; }

        public List<Author> AuthorList { get; set; }
    }
}
