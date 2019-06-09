namespace App4.Models
{
    public class TopRated
    {
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
        public Movies[] results { get; set; }
    }
}
