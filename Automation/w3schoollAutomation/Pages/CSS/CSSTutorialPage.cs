using OpenQA.Selenium;

namespace w3schoollAutomation.Pages.CSS
{
    public class CSSTutorialPage : W3SchoolsPage<CSSTutorialPage>
    {
        public override CSSTutorialPage Init()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseURL + "css/default.asp");
            return this;
        }

        public CSSTutorialPage ClickNext()
        {
            Driver.Instance.FindElement(By.CssSelector("#main > div.nextprev > a.w3-right.w3-btn"))
                .Click();
            return this;
        }

        public CSSTutorialPage ClickHome()
        {
            Driver.Instance.FindElement(By.CssSelector("#main > div.nextprev > a.w3-left.w3-btn")).Click();
            return this;
        }

        public string GetTitle()
        {
            return Driver.Instance.Title;
        }

        public string GetPageHeader()
        {
            return Driver.Instance.FindElement(By.CssSelector("#main > h1")).Text;
        }



        public bool isAt
        {
            get
            {
                IWebElement CSSTutorialLink = Driver.Instance.FindElements(By.CssSelector("#main > h1"))[0];
                return Driver.Instance.Title.Equals("CSS Tutorial") && CSSTutorialLink.Text.Equals("CSS Tutorial");
            }
        }
        public bool isAt_i
        {
            get
            {
                IWebElement CSSTutorialLink = Driver.Instance.FindElements(By.CssSelector("#main > h1"))[0];
                return Driver.Instance.Title.Equals("CSS Introduction") && CSSTutorialLink.Text.Equals("CSS Introduction");
            }
        }


    }

}