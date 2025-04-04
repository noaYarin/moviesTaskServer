namespace movieTasks.Models
{
    public class Movie
    {
        string id;
        string url;
        string primaryTitle;
        string description;
        string primaryImage;
        int year;
        DateTime releaseDate;
        string language;
        double budget;
        double grossWorldwide;
        string[] genres;
        bool isAdult;
        int runtimeMinutes;
        float averageRating;
        int numVotes;

        static List<Movie> moviesList = new List<Movie>(); 

        public Movie() { }

        public Movie(string id, string url, string primaryTitle, string description, string primaryImage, int year, DateTime releaseDate, string language, double budget, double grossWorldwide, string[] genres, bool isAdult, int runtimeMinutes, float averageRating, int numVotes)
        {
            this.id = id;
            this.url = url;
            this.primaryTitle = primaryTitle;
            this.description = description;
            this.primaryImage = primaryImage;
            this.year = year;
            this.releaseDate = releaseDate;
            this.language = language;
            this.budget = budget;
            this.grossWorldwide = grossWorldwide;
            this.genres = genres;
            this.isAdult = isAdult;
            this.runtimeMinutes = runtimeMinutes;
            this.averageRating = averageRating;
            this.numVotes = numVotes;
        }

        public string Id { get => id; set => id = value; }
        public string Url { get => url; set => url = value; }
        public string PrimaryTitle { get => primaryTitle; set => primaryTitle = value; }
        public string Description { get => description; set => description = value; }
        public string PrimaryImage { get => primaryImage; set => primaryImage = value; }
        public int Year1 { get => year; set => year = value; }
        public DateTime ReleaseDate { get => releaseDate; set => releaseDate = value; }
        public string Language { get => language; set => language = value; }
        public double Budget1 { get => budget; set => budget = value; }
        public double GrossWorldwide { get => grossWorldwide; set => grossWorldwide = value; }
        public string[] Genres { get => genres; set => genres = value; }
        public bool IsAdult { get => isAdult; set => isAdult = value; }
        public int RuntimeMinutes { get => runtimeMinutes; set => runtimeMinutes = value; }
        public float AverageRating { get => averageRating; set => averageRating = value; }
        public int NumVotes { get => numVotes; set => numVotes = value; }

        public bool Insert()
        {

            foreach (Movie movie in moviesList)
            {
                if(movie.id == id || movie.primaryTitle == primaryTitle)
                {
                    return false;
                }
            }

            moviesList.Add(this);
            return true;
        }

        public bool Delete(string id)
        {
            foreach (Movie movie in moviesList) {
                if (movie.id == id)
                {
                    moviesList.Remove(movie);
                    return true ;
                }
            }

            return false;
        }
        public List<Movie> Read()
        {
            return moviesList;
        }

        public List<Movie> GetByTitle(string title)
        {
            List<Movie> moviesByTitle = new List<Movie>();
            foreach (Movie movie in moviesList)
            {
                if (!string.IsNullOrEmpty(movie.PrimaryTitle) &&
            movie.PrimaryTitle.Contains(title, StringComparison.OrdinalIgnoreCase))
                {
                    moviesByTitle.Add(movie);
                }
            }
            return moviesByTitle;
        }

        public List<Movie> GetByReleaseDate(DateTime startDate, DateTime endDate)
        {

            List<Movie> moviesByDate = new List<Movie>();
                foreach (Movie movie in moviesList)
                {
                    if (movie.releaseDate >= startDate && movie.releaseDate <= endDate)
                    {
                        moviesByDate.Add(movie);
                    }
                }
            return moviesByDate;

        }
    }

}
