﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace MainApp
{
    public class Hotel: Entity<Guid>
    {
        public string Name { get; set; }
    }
}