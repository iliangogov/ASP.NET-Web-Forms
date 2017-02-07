namespace Countries.Data.Models
{
    public class Town
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Population { get; set; }

        public int? CountryId { get; set; }

        public Country Country { get; set; }

    }
}