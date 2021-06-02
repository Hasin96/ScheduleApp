using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using Schedule.Models;

namespace ScheduleAcceptanceTests
{
    [TestFixture]
    public class ScheduleEnd2EndTests
    {
        private List<Task> testTaskData = new List<Task>();
        public ScheduleEnd2EndTests()
        {

        }

        [SetUp]
        public void SetUp()
        {
            testTaskData = new List<Task>()
                {
                    new Task()
                    {
                        Title = "Reading", ColorId = 2, DateAndTime = DateTime.Now, IconId = 3
                    },
                    new Task()
                    {
                        Title = "Playing", ColorId = 3, DateAndTime = DateTime.Now.AddMinutes(5), IconId = 4
                    },
                    new Task()
                    {
                        Title = "Break", ColorId = 4, DateAndTime = DateTime.Now.AddMinutes(10), IconId = 5
                    }
                };

            using (var db = new ScheduleContext())
            {
                db.Tasks.AddRange(testTaskData);
                db.SaveChanges();
            }
        }

        [Test]
        public void TestShowAllTasksOnPageLoad()
        {
            TasksPage schedulePage = new TasksPage(new ChromeDriver());
            schedulePage.Navigate();
            schedulePage.ValidateTaskCountIs(3);
            schedulePage.ValidateTasks(
               testTaskData
            );
        }

        [TearDown]
        public void TearDown()
        {
            using (var db = new ScheduleContext())
            {
                db.Tasks.RemoveRange(db.Tasks);
                db.SaveChanges();
            }
        }
    }
}
