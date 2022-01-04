using LinqToDB.Mapping;

namespace OTUS_LINQ2DB
{
    [Table(Name = "country")]
    public class CountryTable
    {
        [PrimaryKey]
        [Column(Name = "country_id")]
        public string Country_id { get; set; }

        [Column(Name = "country")]
        public string Country { get; set; }

        [Column(Name = "last_update")]
        public string Last_update { get; set; }
    }
}
