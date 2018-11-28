﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Helpers
{
    public class UserParams
    {
        private const int MaxPageSize = 50;
        public int PageNumber { get; set; } = 1;
        public int pageSize = 10;
        public int MyProperty
        {
            get { return pageSize = 10; }
            set { pageSize = (value > MaxPageSize) ? MaxPageSize : value; }
        }
    }
}
