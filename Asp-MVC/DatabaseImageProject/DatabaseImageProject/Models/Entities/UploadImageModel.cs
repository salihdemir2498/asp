﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatabaseImageProject.Models.Entities
{
    public class UploadImageModel
    {
        public string FullName { get; set; }
        public string FileName { get; set; }
        public long Size { get; set; }
    }
}
