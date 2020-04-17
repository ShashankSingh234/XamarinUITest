using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UITestDemo.UITest
{
    [TestFixture(Platform.Android)]
    //[TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        [TestCase("email@email.com", "password", "LoggedIn successfully.")]
        [TestCase("emai@email.com", "password", "Invalid email or password.")]
        [TestCase("emai@email.com", "password", "LoggedIn successfully.")]
        [TestCase("email@email.com", "password", "Invalid email or password.")]
        public void PerformLogin(string email, string password, string result)
        {
            app.EnterText("Email", email);
            app.EnterText("Password", password);

            app.Tap("LoginButton");

            var appResult = app.Query("Result").First(r => r.Text == result);
            Assert.IsTrue(appResult != null, "Label not displayiong right result.");
        }
    }
}
