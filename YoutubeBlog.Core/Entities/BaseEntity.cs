namespace YoutubeBlog.Core;

public abstract class BaseEntity<TId> : IEntity
{
    public virtual TId Id { get; set; }
    public virtual string CreatedBy { get; set; }
    public virtual string? ModifiedBy { get; set; }
    public virtual string? DeletedBy { get; set; }
    public virtual DateTime CreatedDate { get; set; }
    public virtual DateTime? ModifiedDate { get; set; }
    public virtual DateTime? DeletedDate { get; set; }
    public virtual bool IsActived { get; set; }
}
