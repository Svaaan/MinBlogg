class Comment
{
    public int Id { get; set; }
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