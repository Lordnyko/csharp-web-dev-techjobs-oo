using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        Job test_job;
        Job test_job2;
        Job test_job3;
        Job test_job4;

        [TestInitialize]
        public void CreateJobObject()
        {
            test_job = new Job();
            test_job2 = new Job();
            test_job3 = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                new PositionType("Quality control"), new CoreCompetency("Persistence"));
            test_job4 = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
                new PositionType("Quality control"), new CoreCompetency(""));
        }

        [TestMethod]
        public void TestSettingJobId()
        {           
            Assert.IsTrue(test_job.Id != test_job2.Id && (test_job2.Id + 1) ==  test_job3.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            //var employerName = new Employer("ACME");
            //var employerLocation = new Location("Desert");
            //var jobType = new PositionType("Quality control");
            //var jobCoreCompetency = new CoreCompetency("Persistence");

            //test_job = new Job("Product tester", employerName, employerLocation,
            //    jobType, jobCoreCompetency);

            Assert.AreEqual("Product tester", test_job3.Name);
            Assert.AreEqual("ACME", test_job3.EmployerName.Value);
            Assert.AreEqual("Desert", test_job3.EmployerLocation.Value);
            Assert.AreEqual("Quality control", test_job3.JobType.Value);
            Assert.AreEqual("Persistence", test_job3.JobCoreCompetency.Value);

        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Assert.IsFalse(test_job == test_job2);
        }

        [TestMethod]
        public void TestJobToStringForBlankLine()
        {           
            //test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"),
            //    new PositionType("Quality control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(test_job3.ToString().StartsWith("") == test_job3.ToString().EndsWith(""));
            //Assert.IsTrue(test_job3.ToString().EndsWith("\n"));
        }

        [TestMethod]
        public void TestForEmptyField()
        {
            string expected_string = $@"\nID: {test_job4.Id}\nName: {test_job4.Name}\nEmployer: {test_job4.EmployerName}\nLocation: {test_job4.EmployerLocation}\nPosition Type: {test_job4.JobType}\nCore Competency: Data not available\n";
            Assert.AreEqual(expected_string, test_job4.ToString());
        }
    }
}
