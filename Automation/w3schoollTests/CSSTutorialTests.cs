using NUnit.Framework;
using w3schoollAutomation.Pages.CSS;

namespace w3schoollTests
{
    [TestFixture]
    public class CSSTutorialTests : BaseUITest
    {

        private CSSTutorialPage page = new CSSTutorialPage();

        public override void InitTestPage()
        {
            page.Init();
        }

        [Test]
        public void verifyTitleWhenOpenCSSTutorialPage()
        {
            /*
            Steps:
            - open CSSTutorial Page 
            - verify title correct and pageHeader correct
            */
            //Assert.True(page.isAt);
        }

        [Test]
        public void verifyUserCanClickNextFromCSS()
        {
            /*
            Steps:
            - open CSSTutorial Page 
            - click Next button
            - verify title correct and pageHeader correct
            */
            page.ClickNext();
            Assert.True(page.isAt_i);
        }

        [Test]
        public void verifyUserCanClickHomeFromCSS()
        {
            /*
            Steps:
            - open CSSTutorial Page 
            - click Home button
            - verify title correct and pageHeader correct
            */
            page.ClickHome();
            Assert.AreNotSame(page.GetTitle(), "HTML");
        }


        [Test]
        public void verifyUserCanClickNextButtonSecondTime()
        {
            /*
            Steps:
            - open CSSTutorial Page 
            - click Next button
            - click Next button
            - verify title correct and pageHeader correct
            */
            page.ClickNext();
            page.ClickNext();
            Assert.True(page.isAt);
        }

        [Test]
        public void verifyUserCanClickPreviousButton()
        {
            /*
            Steps:
            - open CSSTutorial Page 
            - click Next button
            - click ❮ Previous  button 
            - verify title correct and pageHeader correct
            */
            page.ClickNext();
            page.ClickHome();
            Assert.True(page.isAt);
        }
    }
}
