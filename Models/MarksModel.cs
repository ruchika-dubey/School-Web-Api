using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Text;

namespace Models
{
    public class MarksModel : BaseModel
    {
        [Key]
        
        public string MarksID { get; set; }
        public string StudentID { get; set; }
        public string SubjectID { get; set; }
        public string Marks { get; set; }
    }
}
