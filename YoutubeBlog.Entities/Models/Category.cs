using YoutubeBlog.Core;

namespace YoutubeBlog.Entities;

public class Category : BaseEntity<int>
{
    public string Name { get; set; }
    public ICollection<Article> Articles { get; set; }
}
