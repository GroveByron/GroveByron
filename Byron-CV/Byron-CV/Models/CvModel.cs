using Microsoft.AspNetCore.Mvc;

namespace Byron_CV.Models
{
    public class CvModel 
    {
            public MyInformation PersonalInfo { get; set; }
            public List<PastExperiences> Experiences { get; set; }
            public List<MyEducation> Educations { get; set; }
            public List<MySkills> Skills { get; set; }
        
    }
}
