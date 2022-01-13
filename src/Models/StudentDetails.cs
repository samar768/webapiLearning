using System;
using System.Collections.Generic;

namespace WEBAPILearning2.Models
{
    public partial class StudentDetails
    {
        public int Studentid { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int? Mobile { get; set; }
        public string City { get; set; }
        public DateTime? Dob { get; set; }
        public string Gender { get; set; }
        public string Class { get; set; }
        public string Fathername { get; set; }
    }
}
