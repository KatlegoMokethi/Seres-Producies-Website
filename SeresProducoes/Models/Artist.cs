using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes.Models
{
    public class Artist
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Image { get; set; }
        public string FacebookLink { get; set; }
        public string TwitterLink { get; set; }
        public string SoundCloudLink { get; set; }
        public string Tracks { get; set; }
    }
}
//DANYKAS DJ
//bio
//fb: https://www.facebook.com/danykasdj/
//tw: https://twitter.com/danykasdj
//sc: https://soundcloud.com/danykasdj
//gm: seresproducoes @gmail.com