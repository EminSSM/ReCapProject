﻿using Core.Entities;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Customer :IEntityBase
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserList User { get; set; }
        public string CompanyName { get; set; }
    }
}
