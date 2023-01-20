﻿using Domain.Entities.Constant;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Base
{
    public class DomainEntity
    {
        [Key]
        public Guid Id { get; set; }
        public int State { get; set; }

    }
}
