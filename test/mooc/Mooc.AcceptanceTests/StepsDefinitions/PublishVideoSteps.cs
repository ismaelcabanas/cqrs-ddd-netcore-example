using Mooc.AcceptanceTests.Drivers;
using TechTalk.SpecFlow;

namespace Mooc.AcceptanceTests.StepsDefinitions
{
    [Binding]
    public class PublishVideoSteps
    {
        private readonly PublishVideoDriver _driver;

        public PublishVideoSteps(PublishVideoDriver driver)
        {
            _driver = driver;
        }

        [Given(@"I have created a (.*) concept video about: (.*)")]
        public void GivenANewVideo(string title, string description)
        {
            _driver.Title(title);
            _driver.Description(description);
        }

        [When(@"I publish the video")]
        public void WhenIPublishTheVideo()
        {
            _driver.Publish();
        }

        [Then(@"the system send a notification video was pulblished")]
        public void ThenTheVideoIsCreatedInPlatform()
        {
            _driver.IsVideoPublished();
        }
        
    }
}