namespace CleanArchitecture.Domain.Shared;

public class BaseEntity
{
    public DateTime Created { get; set; }
    public DateTime? LastModified { get; set; }
    public DateTime? Deleted { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid CreatedBy { get; set; }
    public bool IsDeleted { get; set; }
}