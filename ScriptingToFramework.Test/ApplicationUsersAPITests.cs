using NUnit.Framework;
using Framework.Selenium;
using System.Collections.Generic;
using Framework.Services;
using Framework.Models;
using Moq;
using RestSharp;

namespace ScriptingToFramework.Test
{
    public class ApplicationUsersAPITests
    {
        [SetUp]
        public void BeforeEach()
        {
            Driver.Init();
        }

        [TearDown]
        public void AfterEach()
        {
            Driver.Current.Quit();
        }

        [Test]
        public void Create_New_Application_User()
        {
            string newUser = @"{
                            ""id"": 1,
                            ""name"": ""Jody"",
                            ""username"": ""Matty"",
                            ""email"": ""Sincere@april.biz"",
                            ""address"": {
                            ""street"": ""Kulas Light"",
                            ""suite"": ""Apt. 556"",
                            ""city"": ""Gwenborough"",
                            ""zipcode"": ""92998-3874"",
                            ""geo"": {
                                ""lat"": ""-37.3159"",
                                ""lng"": ""81.1496""
                                }
                            },
                            ""phone"": ""1-770-736-8031 x56442"",
                            ""website"": ""hildegard.org"",
                            ""company"": {
                            ""name"": ""Romaguera-Crona"",
                            ""catchPhrase"": ""Multi-layered client-server neural-net"",
                            ""bs"": ""harness real-time e-markets""
                            }
            }";

            var user = new API<ApplicationUsers>();
            var url = user.SetUrl("users");
            var request = user.CreatePostRequest(newUser);
            var response = user.GetResponse(url, request);
            ApplicationUsers content = user.GetContent<ApplicationUsers>(response);
            Assert.AreEqual("Jody", content.Name);
        }

        [Test]
        public void Get_All_Application_Users()
        {
            var user = new API<ApplicationUsers>();
            var url = user.SetUrl("users");
            var request = user.CreateGetRequest();
            var response = user.GetResponse(url, request);
            ApplicationUsers content = user.GetContent<ApplicationUsers>(response);
            Assert.AreEqual("Leanne Graham", content.Name);   
        }

        [Test]
        public void Get_One_Application_Users()
        {
            var user = new API<ApplicationUsers>();
            var url = user.SetUrl("users");
            var request = user.CreateGetRequest();
            var response = user.GetResponse(url, request);
            ApplicationUsers content = user.GetContent<ApplicationUsers>(response);
            Assert.AreEqual("Leanne Graham", content.Name);   
        }
    }
}