using Candy_Mapper.Setup;
using Candy_Mapper.Test_Methods;
using Candy_Mapper.TestCases;
using Candy_Mapper.TestData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candy_Mapper.TestSuite
{
    [TestFixture]
    public class SmokeTest : Base
    {
        #region required input data
        public static string email = testData.email;
        public static string password = testData.password;
        public static string invalidPassword = testData.invalidPassword;
        #endregion 

        [Test, Order(1)]
        public void Testcase_01_UserIsAbleToLogin()
        {
            var login = new LoginTestCase(driver);
            login.Login(email, password);
        }

        [Test, Order(2)]
        public void Testcase_02_UserIsAbleToHostAHalloweenParty()
        {
            var halloweenparty = new HalloweenPartyTestCase(driver);
            var crossButton = new LoginTestMethods(driver);
            crossButton.ClickOnCrossButton();
            halloweenparty.HostAHalloweenParty(email);
        }

        [Test, Order(3)]
        public void Testcase_03_UserIsAbleToLogout()
        {
            var login = new LoginTestCase(driver);
            var logout = new LogoutTestCase(driver);
            login.Login(email, password);
            logout.Logout();
        }
    }
}