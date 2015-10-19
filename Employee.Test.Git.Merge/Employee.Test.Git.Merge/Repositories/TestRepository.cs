using System.Collections.Generic;

namespace Employee.Test.Git.Merge.Repositories
{
    public class TestRepository : ITestRepository
    {
        public List<string> GetData()
        {
            return new List<string>()
            {
                "valid-1",
                "valid-2",
                "valid-3",
                "valid-4",
                "valid-5",
                "valid-6",
                "valid-7",
                "valid-8"
            };
        }
    }
}