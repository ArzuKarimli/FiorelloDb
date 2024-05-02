namespace test_project.Models
{
    public class InfosItem : BaseEntity
    {
        public string Content { get; set; }
        public string Image { get; set; }
        public int InfoId { get; set; }
        public SupriseInfo Info { get; set; }
    }
}
