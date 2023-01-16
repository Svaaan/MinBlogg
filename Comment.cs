using System.ComponentModel.DataAnnotations;
//DataAnnotations tillåter ändring i antalet tecken och requiered på value måste finnas.
class Comment
{
    public int Id { get; set; }
    [Required]
    [MaxLength(500)]
    public string Content { get; set; }
    public DateTime CreatedAt { get; private set; }

    public int BlogPostId { get; set; }

    //public int BlogPostId { get; set; }
    //public BlogPost BlogPost { get; set; }
    public Comment(string content)
    {
        
        Content = content;
        CreatedAt = DateTime.Now;
    }

    public Comment()
    {
        
    }
}