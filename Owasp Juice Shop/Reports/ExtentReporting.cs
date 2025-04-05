using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Owasp_Juice_Shop.Reports
{
    public static class ExtentReporting
    {
        private static AventStack.ExtentReports.ExtentReports _extent;
        private static ExtentTest extentTest;
        private static ExtentHtmlReporter _htmlReporter;
        private static string reportPath;

        public static void InitializeReport()
        {
            //Windows
            //string reportPath = "C:\\TestReports\\ExtentReport.html";

            //Mac
            string reportPath = "/Users/ayushsmac/Desktop/TestReports/ExtentReport.html";
            Console.WriteLine(reportPath);
            _htmlReporter = new ExtentHtmlReporter(reportPath);
            _extent = new AventStack.ExtentReports.ExtentReports();
            _extent.AttachReporter(_htmlReporter);
        } 

        public static void CreateTest(string testName)
        {
            extentTest = _extent.CreateTest(testName);
        }

        public static void LogInfo(string message)
        {
            extentTest.Info(message);
        }

        public static void LogPass(string message)
        {
            extentTest.Pass(message);
        }

        public static void LogFail(string message)
        {
            extentTest.Fail(message);
        }

        public static void EndReporting()
        {
            try
            {
                _extent.Flush();
                Console.WriteLine($"Report generated at: {reportPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while flushing report: " + ex.Message);
            }
        }

        public static void LogScreenshot(string info, string image)
        {
            extentTest.Info(info, MediaEntityBuilder.CreateScreenCaptureFromBase64String(image).Build());
        }
    }
}