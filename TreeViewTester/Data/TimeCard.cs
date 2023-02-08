namespace TreeViewTester.Data
{
    public class TimeCard
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime CardDate { get; set; }

        public TimeCard(int id, int employeeId, string name, DateTime cardDate)
        {
            Id = id;
            EmployeeId = employeeId;
            Name = name;
            CardDate = cardDate;
        }
    }
}