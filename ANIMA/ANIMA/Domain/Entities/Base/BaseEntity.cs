using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ANIMA.Domain.Entities
{
    public abstract class BaseEntity
    {
        protected BaseEntity() => Id = Guid.NewGuid();

        [Required]
        public Guid Id { get; set; }
    }
}
