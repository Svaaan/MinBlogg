using System.ComponentModel.DataAnnotations;
public class Author
{
    public int AuthorId { get; set; }
    [Required]
    [MaxLength(30)]
    public string Name { get; set; }
    [Required]
    [MaxLength(30)]
    public string LastName { get; set; }
    [Required]
    [MaxLength(30)]
    public string NickName { get; set; }
    [Required]
    [MaxLength(50)]
    public string Email { get; set; }
    //Man kan även göra [Column (Typename= "varchar(10)")] - på t.ex. personnummer, mobil nummer osv..
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