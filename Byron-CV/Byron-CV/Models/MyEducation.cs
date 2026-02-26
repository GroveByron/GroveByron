using Microsoft.AspNetCore.Mvc;

namespace Byron_CV.Models
{
    public class MyEducation 
    {
        public string University { get; set; }
        public string Qualification { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
