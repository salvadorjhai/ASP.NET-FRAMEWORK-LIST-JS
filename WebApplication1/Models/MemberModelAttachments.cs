using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class MemberModelAttachments
    {

        public int id { get; set; }

        [Required]
        public int memberid { get; set; }

        [MaxLength(255)]
        public string title { get; set; }

        [MaxLength(255)]
        public string description { get; set; }

        [MaxLength(255)]
        public string original_filename { get; set; }

        [MaxLength(255)]
        public string hashed_filename { get; set; }


        public int statuslvl { get; set; }

        public int madebyid { get; set; }

        public DateTime? madedate { get; set; }

        public DateTime? lastupdated { get; set; }

        public int updatedbyid { get; set; }

    }
}