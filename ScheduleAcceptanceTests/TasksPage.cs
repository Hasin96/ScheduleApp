using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Schedule.Models;
using System;
using System.Collections.Generic;
using FluentAssertions;
using System.Linq;

namespace ScheduleAcceptanceTests
{
    public class TasksPage
    {
        private readonly ChromeDriver chromeDriver;
        private readonly string url = "https://localhost:5001/";

        private readonly By TaskListItemsBy = By.XPath("//section[@name='tasks']//ul//li");

        public TasksPage(ChromeDriver chromeDriver)
        {
            this.chromeDriver = chromeDriver;
        }

        public void Navigate()
        {
            this.chromeDriver.Navigate().GoToUrl(this.url);
        }

        public void ValidateTaskCountIs(int taskCount)
        {
            IList<IWebElement> taskItems = GetTaskListItems();

            Assert.IsTrue(taskItems.Count == taskCount);
        }

        public void ValidateTasks(List<Task> tasks)
        {
            IList<IWebElement> taskItems = GetTaskListItems();

            //List<string> taskTitles = taskItems.Select(ti => ti.Text).ToList();
            //List<string> taskIcons  = taskItems.Select(ti => ti.)

            //Assert.AreEqual(tasks[0].Title, taskItems[0].Text);
            //StringAssert.Contains(".svg", taskItems[0].)

            Assert.AreEqual(tasks[1].Title, taskItems[1].Text);

            Assert.AreEqual(tasks[2].Title, taskItems[2].Text);

        }

        private IList<IWebElement> GetTaskListItems()
        {
            return this.chromeDriver.FindElements(TaskListItemsBy);
        }
    }
}