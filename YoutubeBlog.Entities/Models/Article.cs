using YoutubeBlog.Core;

namespace YoutubeBlog.Entities;

public class Article:BaseEntity<int>
{
    public string Title { get; set; }
    public string Content { get; set; }
    public int ViewCount { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }
    public int ImageId { get; set; }
    public Image Image { get; set; }
}

