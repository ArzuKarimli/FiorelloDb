namespace test_project.Models
{
    public class SupriseInfo:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
       public List<InfosItem> infosItems { get; set; }
    

    }
}
