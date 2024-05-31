namespace PRACTICE_WEB.Models
{
    public class StudentPaginationViewModel
    {
        public IEnumerable<Student>? Students { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}

