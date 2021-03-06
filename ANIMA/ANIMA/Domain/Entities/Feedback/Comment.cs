using ANIMA.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ANIMA.Domain.Entities.Feedback
{
    public class Comment : BaseFeedback, IPostable
    {
        [Required]
        public Guid Id { get; set; } = Guid.NewGuid();

        [Required]
        public DateTime Date { get; } = DateTime.Now;

        [Required]
        public string Text { get; set; }
    }
}
