namespace SuperHeroAPI.Controllers.Entities
{
    //Class for our superhero to be handled by Entity Framework
    //Name is required and id will be updated automatically in our sql database
    public class SuperHero
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
    }
}
