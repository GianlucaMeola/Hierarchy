using System.Collections.Generic;

namespace ConsoleApp3
{
    public class ReportMenu : Menu 
    {
        public List<WinTechReport> WinTechReports { get; set; }
        public List<MicrosoftReport> MicrosoftReports { get; set; }
    }
}