using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DM2.Models
{
    public class Articles
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string URL { get; set; }
        public DateTime Fecha { get; set; }
        [StringLength(100)]
        public string Nombre { get; set; }
        public string Body { get; set; }
        [StringLength(100)]
        public string ImgURL { get; set; }
        public int IdUser { get; set; }
        public int IdSection { get; set; }

        public Sections Sections { get; set; }
        public Users Users { get; set; }
    }
}