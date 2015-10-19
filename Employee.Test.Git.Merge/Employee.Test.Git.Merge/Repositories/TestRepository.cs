using System.Collections.Generic;

namespace Employee.Test.Git.Merge.Repositories
{
    public class TestRepository : ITestRepository
    {
        public List<string> GetData()
        {
            return new List<string>()
            {
                "merge",
                "Merge",
                "MERGE"
            };
        }
    }
}