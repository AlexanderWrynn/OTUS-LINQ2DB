using LinqToDB.Mapping;

namespace OTUS_LINQ2DB
{
    [Table(Name = "actor")]
    public class Actor
    {
        [PrimaryKey]
        [Column(Name = "actor_id")]
        public int Actor_id { get; set; }

        [Column(Name = "first_name")]
        public string First_name { get; set; }

        [Column(Name = "last_name")]
        public string Last_name { get; set; }

        [Column(Name = "last_update")]
        public string Last_update { get; set; }
    }

}
