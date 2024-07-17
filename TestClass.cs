using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject;

[TestClass]
public class TestClass
{
    public TestContext TestContext { get; set; }

    [TestMethod]
    [DataRow("DataRow1")]
    [DataRow("DataRow2")]
    [DataRow("DataRow3")]
    [DataRow("DataRow4")]
    [DataRow("DataRow5")]
    public void TestMethodAsync(string datarowName)
    {
        TestContext.AddResultFile(datarowName);
    }
}
