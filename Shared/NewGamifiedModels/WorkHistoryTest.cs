﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XebecPortal.Shared.Security;

namespace XebecPortal.Shared
{
  public  class WorkHistoryTest
    {
        public int Id { get; set; }

        public string CompanyName { get; set; }

        public string JobTitle { get; set; }

        public string Description { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; } 

        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }


     }
}
