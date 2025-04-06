using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MariaPersonalStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentList()
        {
            List<Models.Student> people = new List<Models.Student>();

            people.Add(new Models.Student { StudentNumber = "u22234567", Name = "Lola", Surname = "Alkov", Email = "lola.alkov@tuks.co.za", MyLink = "/HTML/LolaAlkov.html" });
            people.Add(new Models.Student { StudentNumber = "u22345678", Name = "Arielle", Surname = "Tatum", Email = "arielle.tatum@tuks.co.za", MyLink = "/HTML/ArielleeTatum.html" });
            people.Add(new Models.Student { StudentNumber = "u22761421", Name = "Marialynn", Surname = "Vewesse", Email = "marialynn.vewesse@tuks.co.za", MyLink = "/HTML/MariaVewesse.html" });
            people.Add(new Models.Student { StudentNumber = "u24567890", Name = "Kamo", Surname = "Nkomo", Email = "kamo.nkomo@tuks.co.za", MyLink = "/HTML/KamoNkomo.html" });
            people.Add(new Models.Student { StudentNumber = "u25678901", Name = "Petrus", Surname = "Chabedi", Email = "petrus.chabedi@tuks.co.za", MyLink = "/HTML/PetrusChabedi.html" });

            return View(people);
        }
    }
}