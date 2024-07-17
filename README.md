1. Checkout this repo
2. Execute `RunTests.ps1` in Powershell (Right-click it).  
This will run a single test with 5 datarows.  
Each datarow will attach one `ResultFile`

```csharp
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
```

3. Open newly created TRX file under `..\tests\logs\` with an editor.  
Each test (one test fpr each datarow) now contains 5 resultfiles.  
Not only does one test contain their own ResultFile, but also all ResultFiles of the other datarows.  

 
```xml
[...]
<Results>
    <UnitTestResult executionId="7c20a225-47f1-452c-929e-8ed161c92996" testId="ed522b40-2be8-facb-40aa-3a96cc0ac794" testName="TestMethodAsync (&quot;DataRow1&quot;)" computerName="removed-PC" duration="00:00:00.0030518" startTime="2024-07-17T15:15:25.7902755+00:00" endTime="2024-07-17T15:15:25.8069986+00:00" testType="13CDC9D9-DDB5-4fa4-A97D-D965CCFC6D4B" outcome="Passed" testListId="8C84FA94-04C1-424b-9868-57A2D4851A1D" relativeResultsDirectory="7c20a225-47f1-452c-929e-8ed161c92996">
      <ResultFiles>
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow1" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow2" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow3" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow4" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow5" />
      </ResultFiles>
    </UnitTestResult>
    <UnitTestResult executionId="a314c973-55ac-4304-9cdf-265a60b910fc" testId="9b7172a2-d59e-1d2f-ca95-76be462b0666" testName="TestMethodAsync (&quot;DataRow2&quot;)" computerName="removed-PC" duration="00:00:00.0004131" startTime="2024-07-17T15:15:25.8142133+00:00" endTime="2024-07-17T15:15:25.8150792+00:00" testType="13CDC9D9-DDB5-4fa4-A97D-D965CCFC6D4B" outcome="Passed" testListId="8C84FA94-04C1-424b-9868-57A2D4851A1D" relativeResultsDirectory="a314c973-55ac-4304-9cdf-265a60b910fc">
      <ResultFiles>
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow1" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow2" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow3" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow4" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow5" />
      </ResultFiles>
    </UnitTestResult>
    <UnitTestResult executionId="e1eda2e3-8928-4a7c-80fc-1921f08ed808" testId="0ec32517-2ace-af52-99ea-a9c04b6990bc" testName="TestMethodAsync (&quot;DataRow3&quot;)" computerName="removed-PC" duration="00:00:00.0001093" startTime="2024-07-17T15:15:25.8153409+00:00" endTime="2024-07-17T15:15:25.8156215+00:00" testType="13CDC9D9-DDB5-4fa4-A97D-D965CCFC6D4B" outcome="Passed" testListId="8C84FA94-04C1-424b-9868-57A2D4851A1D" relativeResultsDirectory="e1eda2e3-8928-4a7c-80fc-1921f08ed808">
      <ResultFiles>
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow1" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow2" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow3" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow4" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow5" />
      </ResultFiles>
    </UnitTestResult>
    <UnitTestResult executionId="8b8e7862-16ab-42dd-b5e0-13c21615e12b" testId="ebebb18e-06e4-549d-8e53-1eb89586f979" testName="TestMethodAsync (&quot;DataRow4&quot;)" computerName="removed-PC" duration="00:00:00.0000092" startTime="2024-07-17T15:15:25.8157442+00:00" endTime="2024-07-17T15:15:25.8158977+00:00" testType="13CDC9D9-DDB5-4fa4-A97D-D965CCFC6D4B" outcome="Passed" testListId="8C84FA94-04C1-424b-9868-57A2D4851A1D" relativeResultsDirectory="8b8e7862-16ab-42dd-b5e0-13c21615e12b">
      <ResultFiles>
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow1" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow2" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow3" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow4" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow5" />
      </ResultFiles>
    </UnitTestResult>
    <UnitTestResult executionId="6741f77c-77cc-464e-be23-daaf7a5026ae" testId="e7c115d7-2378-fee6-ccd7-ee152e69b9fe" testName="TestMethodAsync (&quot;DataRow5&quot;)" computerName="removed-PC" duration="00:00:00.0000089" startTime="2024-07-17T15:15:25.8160100+00:00" endTime="2024-07-17T15:15:25.8170272+00:00" testType="13CDC9D9-DDB5-4fa4-A97D-D965CCFC6D4B" outcome="Passed" testListId="8C84FA94-04C1-424b-9868-57A2D4851A1D" relativeResultsDirectory="6741f77c-77cc-464e-be23-daaf7a5026ae">
      <ResultFiles>
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow1" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow2" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow3" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow4" />
        <ResultFile path="T:\src\mstest_multiple_ResultFiles\bin\Debug\net8.0\DataRow5" />
      </ResultFiles>
    </UnitTestResult>
  </Results>
[...]
```
