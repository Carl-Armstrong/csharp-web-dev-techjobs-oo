using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job testJob1;
        Job testJob2;
        Job testJob3;
        Job testJob4;

        [TestInitialize]
        public void CreateJobObjects()
        {
            testJob1 = new Job();
            testJob2 = new Job();
            testJob3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            testJob4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
        }

        [TestMethod]
        public void TestSettingJobId()
        {
            Assert.AreEqual((testJob1.Id + 1), testJob2.Id, .001);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Assert.IsTrue(testJob3.Name == "Product tester");
            Assert.IsTrue(testJob3.EmployerName.Value == "ACME");
            Assert.IsTrue(testJob3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(testJob3.JobType.Value == "Quality control");
            Assert.IsTrue(testJob3.JobCoreCompetency.Value == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(testJob3.Equals(testJob4));
        }
    }
}
