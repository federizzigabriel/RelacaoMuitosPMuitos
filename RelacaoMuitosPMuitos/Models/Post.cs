namespace RelacaoMuitosPMuitos.Models
{
    public class Post
    {
        public int? Id { get; set; }
        public List<PostTag>? PostTags { get; } = new();
        
    }
}
