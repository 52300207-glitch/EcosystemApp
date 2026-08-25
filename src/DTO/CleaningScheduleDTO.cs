using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemApp.DTO
{
    public class CleaningScheduleDTO
    {
        private string ID;
        private DateTime Date;
        private string Status;
        private DateTime StartTime;
        private DateTime EndTime;


        public CleaningScheduleDTO() { }

        public CleaningScheduleDTO(string id, DateTime date, string status, DateTime startTime, DateTime endTime)
        {
            ID = id;
            Date = date;
            Status = status;
            StartTime = startTime;
            EndTime = endTime;
        }

        //getter setter
        public string GetID() { return ID; }
        public DateTime GetDate() { return Date; }
        public string GetStatus() { return Status; }
        public DateTime GetStartTime() { return StartTime; }
        public void SetStartTime(DateTime startTime) { StartTime = startTime; }
        public void SetEndTime(DateTime endTime) { EndTime = endTime; }
        public DateTime GetEndTime() { return EndTime; }
        public void SetID(string id) { ID = id; }
        public void SetStatus(string status) { Status = status; }

        
    }
}
