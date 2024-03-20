using YoutubeBlog.Core;

namespace YoutubeBlog.Entities;

public class Image : BaseEntity<int>
{
    public string FileName { get; set; }
    public string FileType { get; set; }
    public ICollection<Article> Articles { get; set; }

    
}
