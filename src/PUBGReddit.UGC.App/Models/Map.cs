namespace PUBGReddit.UGC.App.Models
{
    public class Map
    {
        public string? Name { get; set; }
        public DateOnly LastChangeDate { get; set; }
        public string? Author { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
        public string? MapUrl { get; set; } 
        public string? Tags { get; set; } // Tags are now a single string containing comma-separated values
    }
}