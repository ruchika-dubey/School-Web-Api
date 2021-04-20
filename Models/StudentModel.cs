using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class StudentModel : BaseModel
    {
        [Key]
        public string StudentID { get; set; }
        public string StudentName { get; set; }

        public string StudentGrade { get; set; }
    }
}
