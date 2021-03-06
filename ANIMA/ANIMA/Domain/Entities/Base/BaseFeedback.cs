using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ANIMA.Domain.Entities
{
    public class BaseFeedback
    {
        [Required]
        public Guid AuthorId { get; set; }

        [Required]
        public Guid PostId { get; set; }
    }
}
