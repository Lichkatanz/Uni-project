namespace MovieStore.Models.DTO
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public int Year { get; set; }

        public IEnumerable<int> Actors { get; set; } =
            Enumerable.Empty<int>();
    }
}