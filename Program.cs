using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stimulsoft.Report;

namespace StimulSoftTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create the report object
            var report = new StiReport();

            // Load the report
            report.Load("MyReport.mrt");
            try
            {
                // Render the report
                report.Render();

                // Print the report
                report.Print();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
                throw;
            }

        }
    }
}
