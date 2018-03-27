using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using ClosedXML.Excel;
using ScheduleLogic.Models;

namespace ScheduleLogic.Helpers
{
    public static class ReportGenerator
    {
        private const int MaximumExcelWorksheetNameLength = 31;

        private static DataTable ConvertTaskToDataTable(IEnumerable<Task> tasks)
        {
            var output = new DataTable();
            output.Columns.Add(new DataColumn("Scheduled Date", typeof(DateTime)));
            output.Columns.Add(new DataColumn("Team Member", typeof(string)));
            output.Columns.Add(new DataColumn("Role", typeof(string)));
            output.Columns.Add(new DataColumn("Status", typeof(string)));
            output.Columns.Add(new DataColumn("Hours", typeof(decimal)));
            output.Columns.Add(new DataColumn("Comment", typeof(string)));

            // Assign values to columns here
            foreach (var task in tasks)
            {
                var row = output.NewRow();

                row["Scheduled Date"] = task.ScheduledUtc;
                row["Team Member"]    = $"{task.Employees.FirstName} {task.Employees.LastName}";
                row["Role"]           = task.TaskTypes.Name;
                row["Status"]         = task.TaskStatuses.Name;
                row["Hours"]          = task.HoursScheduled;
                row["Comment"]        = string.Empty;

                output.Rows.Add(row);
            }

            return output;
        }

        public static byte[] GenerateExport(WorkRequest request)
        {
            using (var ms = new MemoryStream())
            {
                using (var wb = new XLWorkbook())
                {
                    var ws = wb.AddWorksheet(request.Name.PadRight(MaximumExcelWorksheetNameLength, ' ')
                                                    .Substring(0, MaximumExcelWorksheetNameLength).Trim());

                    ws.Range("A1:C1").Merge().Value = "Job";
                    ws.Range("D1:F1").Merge().Value = request.Name;
                    ws.Range("A2:C2").Merge().Value = "Client";
                    ws.Range("D2:F1").Merge().Value = string.Empty;
                    ws.Range("A3:C3").Merge().Value = "Owner";
                    ws.Range("D3:F3").Merge().Value = $"{request.Employee.FirstName} {request.Employee.LastName}";
                    ws.Range("A4:C4").Merge().Value = "Work Request Link";

                    if (request.ExternalLink != null)
                    {
                        ws.Cell("D4").Value     = "Link";
                        ws.Cell("D4").Hyperlink = new XLHyperlink(request.ExternalLink);
                    }
                    else
                    {
                        ws.Cell("D4").Value = "Not Available";
                    }

                    ws.Range("A5:C5").Merge().Value = "Generated";
                    ws.Cell("D5").Value             = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    // Scheduled Tasks Data Table
                    ws.LastCellUsed()
                      .CellBelow(1)
                      .CellLeft(5)
                      .InsertTable(ConvertTaskToDataTable(request.Tasks));

                    // Make it Pretty
                    ws.Columns().AdjustToContents();

                    // Close it off
                    wb.SaveAs(ms);
                }

                return ms.ToArray();
            }
        }
    }
}