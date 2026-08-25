public class WorkShiftDTO
{
    // Property dùng cho ComboBox Binding
    private int ID;
    private string ShiftName;

    private string StartTime;
    private string EndTime;

    // Constructor
    public WorkShiftDTO() { }

    public WorkShiftDTO(int id, string name, string start, string end)
    {
        ID = id;
        ShiftName = name;
        StartTime = start;
        EndTime = end;
    }

    // Nếu bạn cần giữ lại hàm cũ thì vẫn giữ được
    public int GetID() { return ID; }
    public string GetShiftName() { return ShiftName; }
    public string GetStartTime() { return StartTime; }
    public string GetEndTime() { return EndTime; }

    public void SetID(int id) { this.ID = id; }
    public void SetShiftName(string name) { this.ShiftName = name; }
    public void SetStartTime(string time) { this.StartTime = time; }
    public void SetEndTime(string time) { this.EndTime = time; }
}
