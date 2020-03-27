using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes.Models
{
    public class Article
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Headline { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        //~/images/articles/n01.jpeg
        public string Image{ get; set; }
        public string Link { get; set; }
    }
}
