﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Barangay.Class
{
    public class UserManager
    {
        public UserManager()
        {

        }
        public static UserManager instance;
        public User currentUser { get; set; }
        private OfficerInfo info;
        public OfficerInfo Officers
        {
            get
            {
                if (info == null)
                    info = new OfficerInfo();
                return info;
            }
        }
    }
}
