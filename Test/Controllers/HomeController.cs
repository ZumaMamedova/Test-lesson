using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Test.Models;
using Test.ViewModels;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Student student = new Student()
            {
                Id = 1,
                Name = "Stu1",
                Surname="Surname",
                Age=25
            };

            Student student2 = new Student();
            student2.Id = 2;
            student2.Name = "Stu2";
            student2.Surname = "Surname2";
            List<Student>list = new List<Student>();
            list.Add(student);
            list.Add(student2);

            Group group1 = new Group();
            group1.Id = 1;
            group1.Name = "P515";


            HomeVM homeVM = new HomeVM
            {
                Students = list,
                Group = group1,
            };

            return View(homeVM);
        }

        public IActionResult About() 
        {
            
            {
                Student stu = new Student();
                stu.Name = "Stu2";
                return View(stu);
            };
            
        }
    }

   
}
