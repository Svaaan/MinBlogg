internal class Program
{
    private static void Main(string[] args)
    {
        MyDbContext db = new();
        Author author = new("Karl", "Svan", "xXDrakMästarN69Xx", "earthisflat@live.se");
        Blog blog = new Blog("CoolaBloggen");
        BlogPost blogPost = new("Första Inlägget", "Här är mitt inlägg", true);
        Comment comment = new("Fin Blogg");

        
        db.SaveChanges();
    }
}