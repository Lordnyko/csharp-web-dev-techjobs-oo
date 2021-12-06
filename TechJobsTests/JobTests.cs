using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job test_job;
        Job test_job2;

        [TestMethod]
        public void TestSettingJobId()
        {
            test_job = new Job();
            test_job2 = new Job();
            Assert.IsFalse(test_job.Id == test_job2.Id);

        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            var employerName = new Employer("ACME");
            var employerLocation = new Location("Desert");
            var jobType = new PositionType("Quality control");
            var jobCoreCompetency = new CoreCompetency("Persistence");

            test_job = new Job("Product tester", employerName, employerLocation,
                jobType, jobCoreCompetency);

            Assert.AreEqual("Product tester", test_job.Name);
            Assert.AreEqual("ACME", test_job.EmployerName.Value);
            Assert.AreEqual("Desert", test_job.EmployerLocation.Value);
            Assert.AreEqual("Quality control", test_job.JobType.Value);
            Assert.AreEqual("Persistence", test_job.JobCoreCompetency.Value);

        }

        [TestMethod]
        public void TestJobsForEquality()
        {

        }

    }
}
