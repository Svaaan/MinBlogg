// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MinBlogg.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230115145351_tableblogPosts")]
    partial class tableblogPosts
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("AuthorId");

                    b.ToTable("authors");
                });

            modelBuilder.Entity("Blog", b =>
                {
                    b.Property<int>("BlogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BlogName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BlogId");

                    b.ToTable("blogs");
                });

            modelBuilder.Entity("BlogPost", b =>
                {
                    b.Property<int>("BlogPostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsPublished")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("BlogPostId");

                    b.ToTable("blogPosts");
                });
#pragma warning restore 612, 618
        }
    }
}
