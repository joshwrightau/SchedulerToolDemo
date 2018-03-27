using System.ComponentModel;

namespace ScheduleInterface
{
    public interface IReport
    {
        string Filename { get; set; }
        string FullFilePath { get; set; }

        event PropertyChangedEventHandler PropertyChanged;
    }
}