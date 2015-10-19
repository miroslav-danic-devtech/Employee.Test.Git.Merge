using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Employee.Test.Git.Merge;
using Employee.Test.Git.Merge.Controllers;
using Employee.Test.Git.Merge.Repositories;
using Employee.Test.Git.Merge.Services;
using Moq;
using Xunit;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Employee.Test.Git.Merge.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void TestMerge()
        {
            var service = new TestService(new TestRepository());

            var validData = new List<string>()
            {
                "VALID-4",
                "VALID-5",
                "VALID-6",
                "VALID-7",
                "VALID-8"
            };

            var actualData = service.GetData();
            for (int i = 0; i < validData.Count; i++)
            {
                Assert.AreEqual(actualData[i], validData[i]);
            }
        }
    }
}
