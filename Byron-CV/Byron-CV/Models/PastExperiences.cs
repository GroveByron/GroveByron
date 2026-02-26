using Microsoft.AspNetCore.Mvc;

namespace Byron_CV.Models
{
    public class PastExperiences
    {
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
    }
}
