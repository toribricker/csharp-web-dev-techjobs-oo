using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
   public class JobTests
    {
      [TestMethod]
      public void TestSettingJobId()
        {
            Job testJob1 = new Job();
            Job testJob2 = new Job();
            Assert.IsFalse(testJob1.Id == testJob2.Id);
            Assert.IsTrue(testJob2.Id - testJob1.Id == 1);
        }
    }
}
