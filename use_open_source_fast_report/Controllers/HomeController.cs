using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using use_open_source_fast_report.Models;
using FastReport.Web;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;

namespace use_open_source_fast_report.Controllers
{
    public class HomeController : Controller
    {
        static private Report report=null;//biến static lưu đánh dấu report
        private readonly IHostingEnvironment _hostingEnvironment;// lấy đường dẫn
        private readonly Context _context;// Tạo kết nối
        public HomeController(Context context, IHostingEnvironment hostingEnvironment)
        {
			_hostingEnvironment = hostingEnvironment; 
            _context= context;
		}
        // Load report basic trong db với id=1 lên file Report
        public void LoadReportBasic()
        {
            try
            {
                // Create a string array with the lines of text
                /*string[] lines = { "First line", "Second line", "Third line" };*/
                string line = _context.Reports.SingleOrDefault(b => b.ID == 1).Content;
                // Set a variable to the Documents path.
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string webRootPath = _hostingEnvironment.WebRootPath;
                String pathReport = webRootPath + "/Reports/Report.frx";
                // Write the string array to a new file named "WriteLines.txt".
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, pathReport)))
                {
                    outputFile.WriteLine(line);
                };
            }
            catch { 

            }
        }
        //Load report trong db với id bất kỳ lên file Report
        public void LoadRepor(int id)
        {
            try
            {
                // Create a string array with the lines of text
                /*string[] lines = { "First line", "Second line", "Third line" };*/
                string line = _context.Reports.SingleOrDefault(b => b.ID == id).Content;
                // Set a variable to the Documents path.
                string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string webRootPath = _hostingEnvironment.WebRootPath;
                String pathReport = webRootPath + "/Reports/Report.frx";
                // Write the string array to a new file named "WriteLines.txt".
                using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, pathReport)))
                {
                    outputFile.WriteLine(line);
                };
            }
            catch
            {

            }
        }
        //Nạp report lên report design
        public void LoadReportToDesign()
        {
            try
            {
                WebReport WebReport = new WebReport(); // Create a Web Report Object
                WebReport.Width = "1000"; // Set the width of the report
                WebReport.Height = "1000"; // Set the height of the report
                string webRootPath = _hostingEnvironment.WebRootPath; // Get the path to wwwroot folder                                                                   //string contentRootPath = _hostingEnvironment.ContentRootPath;
                WebReport.Report.Load(webRootPath + "/Reports/Report.frx"); // Load the report into a WebReport object
                System.Data.DataSet dataSet = new System.Data.DataSet(); // Create a data source
                dataSet.ReadXml(webRootPath + "/Reports/nwind.xml"); // Open the xml database
                WebReport.Report.RegisterData(dataSet, "NorthWind"); //Register the data source in the report
                WebReport.Mode = WebReportMode.Designer; // Set the mode of the web report object - display of the designer
                WebReport.DesignerPath = "/WebReportDesigner/index.html"; // Specify the URL of the online designer
                WebReport.DesignerSaveCallBack = "/Home/SaveDesignedReport"; // Set the view URL for the report save method
                
                ViewBag.WebReport = WebReport; // pass report to View
            }
            catch
            {

            }
        }
        //Đọc file SaveReport
        public string ReadSaveReport()
        {
            string kq = "";
            try
            {
                string webRootPath = _hostingEnvironment.WebRootPath;
                // Open the text file using a stream reader.
                using (var sr = new StreamReader(webRootPath + "/DesignedReports/SaveReport.frx"))
                {

                    // Read the stream as a string, and write the string to the console.
                    kq = sr.ReadToEnd();
                }
            }
            catch (Exception ex) { }
            return kq;
        }
        //Save file SaveReport xuống db
        public void SaveRReportToDB()
        {
            String contenReport = ReadSaveReport();
            if(report == null)
            {
                report = _context.Reports.SingleOrDefault(b => b.ID == 1);
            }
            Report reportUpdate = new Report();
            reportUpdate.ID = report.ID;
            reportUpdate.Name= report.Name;
            reportUpdate.Content = contenReport;
            _context.Update(reportUpdate);
            _context.SaveChanges();
        }
        public IActionResult Index()
        {
            LoadReportBasic();
            try
            {
                LoadReportBasic();
                LoadReportToDesign();
                return View();
            }
            catch
            {
                return View();
            }

        }

        [HttpPost]
        public ActionResult SaveDesignedReport(string reportID, string reportUUID)
        {
            string webRootPath = _hostingEnvironment.WebRootPath; // Get the path to wwwroot folder ViewBag.Message = String.Format("Confirmed {0} {1}", reportID, reportUUID); // Set a message for view
            Stream reportForSave = Request.Body; // Write the result of the Post query to the stream
            string pathToSave = webRootPath + "/DesignedReports/SaveReport.frx"; // get the path to save the file
            using (FileStream file = new FileStream(pathToSave, FileMode.Create)) // Create a file stream {
            reportForSave.CopyTo(file); // Save the result of the query to a file
            SaveRReportToDB();//Lưu savereport xuống DB
            return View();
             }
        //Load report từ DB
        [HttpGet]
        public IActionResult LoadReportDB(int id)
        {
            try
            {
                LoadRepor(id);
                LoadReportToDesign();
                report = _context.Reports.SingleOrDefault(r => r.ID == id);
                return View();
            }
            catch
            {
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
