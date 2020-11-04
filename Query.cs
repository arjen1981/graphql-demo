namespace graphql_demo
{
    public class Query
    {
        public Film GetFilm() => new Film {Title = "The Double Life of Veronique", Director = "Krzysztof Kieslowski" };
    }
}