﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrForm
{
[Serializable]
   public class User
    {
        public User()
        {

        }
       public string login { get; set; }
       public string password { get; set; }
       public string email { get; set; }
    }
}
