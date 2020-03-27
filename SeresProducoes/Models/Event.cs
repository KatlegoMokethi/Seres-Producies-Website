using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeresProducoes.Models
{
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        //WeekDay, Month+Day, Year, at [timeframe] timezone
        public string DescriptiveDate { get; set; }
        public DateTime Date { get; set; }
        public string Host { get; set; }
        public string Image { get; set; }
        public string Link { get; set; }
    }
}
//DJ Satelite + Danykas DJ
//Thursday, February 27, 2020 at 11:59 PM – 6 AM UTC
//Hosted by Seres Produções, MUSICBOX LISBOA, DJ Satelite, DANYKAS DJ
