using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Models
{
    public class NotebookItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateStart { get; set;}
        public DateTime DateEnd { get; set;}

        public int GroupID {get; set; }
        public int  CourseID {get; set; }

        public int FacultyID { get; set; }
        public int Week { get; set; }

    }
}