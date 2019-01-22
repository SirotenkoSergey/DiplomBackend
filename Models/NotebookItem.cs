using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Models
{
    public class NotebookItem {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}