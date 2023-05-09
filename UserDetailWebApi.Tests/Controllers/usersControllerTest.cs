using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserDetailWebApi.Controllers;
using UserDetailWebApi.Models;
using System;
using System.Configuration;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;


namespace User_Details_WEBAPI_TEST.Tests.Controllers
{
    [TestClass]
    public class usersControllerTest
    {
        readonly string apiBaseAddress = ConfigurationManager.AppSettings["apiBaseAddress"];
        readonly string token = ConfigurationManager.AppSettings["token"];
        [TestMethod]
        public void _GetUsersList()
        {
            usersController controller = new usersController();
            var Result = controller.GetUserList(apiBaseAddress, token);
            Assert.IsNotNull(Result);
        }

        [TestMethod]
        public void _AddUser()
        {
           // Before unit test start Please Change User data
            Users users = new Users();
            users.name = "test";
            users.email = "test@test.com";
            users.gender = "Male";
            users.status = "test";
            usersController controller = new usersController();
            var Result = controller.addUsers(users, apiBaseAddress, token);
            if (!Result)
                Assert.Fail();
        }

       

        [TestMethod]
        public void _UpdateUser()
        {
            //Before unit test start Please Change User data
            usersController controller = new usersController();
            Users users = new Users();
            users.name = "test";
            users.email = "test@test.com";
            users.gender = "Male";
            users.status = "test";
            users.id = 1384457;
            var Result = controller.updateUsers(users, apiBaseAddress, token);
            if (!Result)
                Assert.Fail();
        }

        [TestMethod]
        public void _DeleteUser()
        {
            //Before unit test start Please Change User data
            usersController controller = new usersController();
            string id = "1384457";
            var Result = controller.deleteUsers(id, apiBaseAddress, token);
            if (!Result)
                Assert.Fail();
        }
    }
}
