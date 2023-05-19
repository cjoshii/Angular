
namespace MyShop.WebApi.Data;
public class BaseEntity : IEquatable<BaseEntity>
{
    public long Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public ApplicationUser CreatedBy { get; set; }
    public DateTime? ModifiedAt { get; set; }
    public ApplicationUser ModifiedBy { get; set; }

    public override bool Equals(object obj)
    {
        return Equals(obj as BaseEntity);
    }

    public bool Equals(BaseEntity other)
    {
        return other != null && Id == other.Id;
    }

    public override int GetHashCode()
    {
        return Id.GetHashCode() * 31;
    }
}
