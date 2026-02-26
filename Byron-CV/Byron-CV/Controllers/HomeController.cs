using System.Diagnostics;
using Byron_CV.Models;
using Microsoft.AspNetCore.Mvc;

namespace Byron_CV.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var cv = new CvModel
            {
                PersonalInfo = new MyInformation
                {
                    FullName = "Byron Grove",
                    JobTitle = "Software Developer",
                    Email = "BGrove@email.com",
                    Phone = "011 222 3333",
                    GitHub = "https://github.com/st10435318.github",
                    ProfessionalSummary = "I strive each day to improve and better myself then yesterday ensuring that each day I work harder and improve my knowledge and extending my skills with developing applications. I take pride in my work giving it all my best as I have dedicated years to improve my skills in the different coding languages. I'm a very skilled individual as I have taken part in creating many projects, In my past I have lead mutliple teams which gives me a good insight how to run a team efficiently and effectively. I'm the type of person who looks for solutions and solve problems with immediate effect. I bring a positive and team building mentality which produces determination."
                },

                Experiences = new List<PastExperiences>
        {
            new PastExperiences
            {
                CompanyName = "Tech Company",
                JobTitle = "Junior Developer",
                StartDate = new DateTime(2015, 1, 1),
                EndDate = new DateTime(2017, 1, 1),
                Description = "Developed MVC web applications for clients."
            },
            new PastExperiences
            {
                CompanyName = "Developer Voda",
                JobTitle = "Senior Developer",
                StartDate = new DateTime(2017, 1, 1),
                EndDate = new DateTime(2019, 1, 1),
                Description = "Managed teams and projects."
            },
            new PastExperiences
            {
                CompanyName = "Amaz Coding",
                JobTitle = "Senior Project Developer Manager",
                StartDate = new DateTime(2019, 1, 1),
                EndDate = new DateTime(2021, 1, 1),
                Description = "Micro managed team leaders who ran projects following up on reports."
            },
            new PastExperiences
            {
                CompanyName = "Enzor Developers",
                JobTitle = "Senior IT Operations Engineer",
                StartDate = new DateTime(2021, 1, 1),
                EndDate = null,
                Description = "Managed and operated all systems within the company."
            }
        },

                Educations = new List<MyEducation>
        {
            new MyEducation
            {
                University = "University of Pretoria",
                Qualification = "BSc Computer Science",
                StartDate = new DateTime(2012, 1, 1),
                EndDate = new DateTime(2025, 12, 1)
            },
            new MyEducation
            {
                University = "University of Johannesburg",
                Qualification = "BSc Computer and Information Systems",
                StartDate = new DateTime(2015, 1, 1),
                EndDate = new DateTime(2018, 12, 1)
            },
            new MyEducation
            {
                University = "University of Pretoria",
                Qualification = "Honors in BSc Computer Science",
                StartDate = new DateTime(2015, 1, 1),
                EndDate = new DateTime(2016, 12, 1)
            },
            new MyEducation
            {
                University = "University of Pretoria",
                Qualification = "Masters in BSc Computer Science",
                StartDate = new DateTime(2018, 1, 1),
                EndDate = new DateTime(2020, 12, 1)
            }
        },

                Skills = new List<MySkills>
        {
            new MySkills { SkillName = "C#" },
            new MySkills { SkillName = "ASP.NET Core" },
            new MySkills { SkillName = "SQL Server" },
            new MySkills { SkillName = "HTML & CSS" },
            new MySkills { SkillName = "Python" },
            new MySkills { SkillName = "Excell" },
            new MySkills { SkillName = "Java" },
            new MySkills { SkillName = "Word" },
            new MySkills { SkillName = "Azure labs" },
            new MySkills { SkillName = "Cloud Lab AI" }
        }
            };

            return View(cv);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
