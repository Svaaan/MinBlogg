using System.ComponentModel.DataAnnotations;
public class Blog
{
    //BlogPost blogPost = new BlogPost();
    public int BlogId { get; set; }
    
    [Required]
    [MaxLength(30)]
    public string BlogName { get; set; }

    public Blog(string blogName)
    {
        this.BlogName = blogName;
    }

    //Testar att blogpost ska vara foreign key här
    //public int AuthorId {get; set;}
    //public Author Author { get; set; }
    // public List<BlogPost> blogPosts = new();


    //     public void AddBlogPost(BlogPost blogPost)
    //     {
    //         dbContext.blogPosts.Add(blogPost);
    //     }

    //     //Hämta en lista på alla blogposts
    //     public List<BlogPost> GetAllPosts()
    //     {

    //         return dbContext.blogPosts.ToList();
    //     }

    //     public BlogPost GetBlogPost(int id)
    //     {
    //         //FIXME! Gör en sökalgoritm här som hittar och skickar 
    //         //tillbaka en BlogPost med specifikt Id
    //         return null;
    //     }
    //     public void RemovePost(BlogPost blogPost)
    //     {
    //          dbContext.blogPosts.Remove(blogPost);
    //     }
    //     public void RemoveAuthor(Author author)
    //     {
    //         dbContext.authors.Remove(author);   
    //     }

    //     public void UpdateBlogPost()
    //     {
    //         System.Console.WriteLine("");
    //     }


    // Ta bort en BlogPost

    // Redigera BlogPost

    // Söka efter blogginlägg
}