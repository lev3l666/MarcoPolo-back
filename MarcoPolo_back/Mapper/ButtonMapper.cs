using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcoPolo_back.Mapper
{
    public class ButtonMapper
    {
        class Globals
        {
            public static OpenQA.Selenium.Appium.AppiumOptions appiumOptions;
            public static WindowsDriver<WindowsElement> vcdsSession;
        }

        public bool StartSession(string appName)
        {
            Globals.appiumOptions = new OpenQA.Selenium.Appium.AppiumOptions();
            Globals.appiumOptions.AddAdditionalCapability("app", appName);
            Globals.vcdsSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), Globals.appiumOptions);
            //var response = Globals.vcdsSession.SessionId;

            return true; //poner try catch para err
        }
        public List<WindowsControl> GetAllControlsXpath(string parentXpath)
        {
            List<WindowsElement> controles = new List<WindowsElement>(Globals.vcdsSession.FindElements(By.XPath(parentXpath)));
            WindowsElement padre = Globals.vcdsSession.FindElement(By.XPath("//*[@ClassName='#32770']"));
            controles.Add(padre);
            List<WindowsControl> auxiliar = new List<WindowsControl>();

            foreach (var item in controles)
            {
                auxiliar.Add(new WindowsControl(item.Text,
                    item.TagName,
                    item.GetAttribute("BoundingRectangle"),
                    item.GetAttribute("RuntimeId"),
                    item.GetAttribute("AutomationId"),
                    item.Enabled,
                    item.Displayed,
                    Convert.ToBoolean(item.GetAttribute("IsModal")),
                    Convert.ToBoolean(item.GetAttribute("IsTopmost"))));
            }

            return auxiliar;
        }

        public WindowsElement GetControlXpath(int Xpath)
        {
            Console.WriteLine("xpath de elemento: " + Xpath);
            Globals.vcdsSession.FindElement(By.XPath("//*[@AutomationId='" + Xpath.ToString() + "']")).Click();
            //WindowsElement response= Globals.vcdsSession.FindElement(By.XPath("//*[@AutomationId='"+Xpath+"']"));

            return Globals.vcdsSession.FindElement(By.XPath("//*[@AutomationId='" + Xpath.ToString() + "']")); ;
        }

        public string SendEvent(int id1, string type, string keys)
        {
            //hacer switch case de eventos
            if (type == "click")
            {
                //Globals.vcdsSession.FindElement(By.Id(id1)).Click();
                Globals.vcdsSession.FindElement(By.XPath("//*[@AutomationId='" + id1.ToString() + "']")).Click();
            }            

            return "test";
        }
        public string SendEvent(string id1, string id2, string type)
        {

            return "test";
        }
    }
}
