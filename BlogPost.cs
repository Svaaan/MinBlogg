using System.ComponentModel.DataAnnotations;
public class BlogPost
{

    public int BlogPostId { get; private set; }
    //public Author Author { get; private set;
    [Required]
    [MaxLength(50)]
    public string Title { get; set; }
    [Required]
    [MaxLength(1000)]
    public string Content { get; set; }
    public bool IsPublished { get; set; }
    public int AuthorId { get; set; }
    public  int BlogId { get; set; }
    // public ICollection<Author> Author { get; set; } //Relation till author

    private DateTime _createdAt;
    public DateTime CreatedAt { get { return _createdAt; } }
    private DateTime _modifiedAt;

     public BlogPost(string title , string content, bool isPublished)
    {
        Title = title;
        Content = content;
        IsPublished = isPublished;
        //Id = new Random().Next();
        //Author = author;
        //_createdAt = DateTime.Now;
    }

    public BlogPost()
    {
        //Id = new Random().Next();
        //Author = author;
        //_createdAt = DateTime.Now;
    }
}