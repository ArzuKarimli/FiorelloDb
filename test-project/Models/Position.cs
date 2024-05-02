namespace test_project.Models
{
    public class Position : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Expert>  experts { get; set; }
    }
}
