using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models
{
    public class SubjectModel :BaseModel
    {
        [Key]
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }
    }
}
