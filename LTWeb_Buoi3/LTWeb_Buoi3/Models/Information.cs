﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LTWeb_Buoi3.Models
{
    public class Information
    {
        public string FullName { get; set; }
        public string IdStudent { get; set; }
        public string Email { get; set; }
        public string File { get; set;  }
        public string Note { get; set; }
        public bool Check1 { get; set; }
        public bool Check2 { get; set; }
        public bool Check3 { get; set; }

        public string ChooseWorkTime { get; set; }
        public string SelectCourse { get; set;  }
       
    }
}