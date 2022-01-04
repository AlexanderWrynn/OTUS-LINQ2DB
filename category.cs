using LinqToDB.Mapping;

namespace OTUS_LINQ2DB
{
    [Table(Name = "category")]
    public class Category
    {
        [PrimaryKey]
        [Column(Name = "category_id")]
        public int Category_id { get; set; }

        [Column(Name = "name")]
        public string Name { get; set; }

        [Column(Name = "last_update")]
        public string Last_update { get; set; }
    }
}
