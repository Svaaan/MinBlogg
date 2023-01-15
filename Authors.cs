public class Author
{
    public int AuthorId { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string NickName { get; set; }
    public string Email { get; set; }

    public int BlogId { get; set; }

    //public int BlogPostId { get; set; }
    public Author(string name, string lastName, string nickName, string email)
    {
        Name = name;
        LastName = lastName;
        NickName = nickName;
        Email = email;
    }
}