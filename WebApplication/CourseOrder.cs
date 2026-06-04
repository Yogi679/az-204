namespace WebApplication
{
    public class CourseOrder
    {
        public int OrderId { get; set; }
        public required string  CustomerName { get; set; }
        public required string CustomerEmail { get; set; }
        public required string CourseName { get; set; }
        public decimal Amount { get; set; }
        public DateTime OrderDateUtc { get; set; }
    }
}
