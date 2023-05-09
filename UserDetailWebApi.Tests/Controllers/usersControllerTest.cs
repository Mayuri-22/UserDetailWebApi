using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDetailWebApi.Controllers;
using UserDetailWebApi.Models;

namespace UserDetailWebApi.Tests.Controllers
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
            //Before unit  test start Please Change User data 
            Users users = new Users();
            users.name = "krishna";
            users.email = "K@test.com";
            users.gender = "Male";
            users.status = "ACTIVE";
            usersController controller = new usersController();
            var Result = controller.addUsers(users, apiBaseAddress, token);
            if (!Result)
                Assert.Fail();
        }

        [TestMethod]
        public void _UpdateUser()
        {
            //Before unit  test start Please Change User data 
            usersController controller = new usersController();
            Users users = new Users();
            users.name = "jasmin";
            users.email = "j@test.com";
            users.gender = "FeMale";
            users.status = "Active";
            users.id = 1366866;
            var Result = controller.updateUsers(users, apiBaseAddress, token);
            if (!Result)
                Assert.Fail();
        }

        [TestMethod]
        public void _DeleteUser()
        {
            //Before unit test start Please Change User data 
            usersController controller = new usersController();
            string id = "1366864";
            var Result = controller.deleteUsers(id, apiBaseAddress, token);
            if (!Result)
                Assert.Fail();
        }
    }
}
