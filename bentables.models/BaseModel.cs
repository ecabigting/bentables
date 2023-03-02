using System.Dynamic;
using System;
namespace bentables.models;
public class BaseModel
{
    public Guid Id { get; set; }
    public DateTimeOffset CreatedDate { get; set; }
    public Guid? CreatedBy { get; set; }
    public DateTimeOffset UpdatedDate { get; set; }
    public Guid? UpdatedBy { get; set; }
    public bool IsEnabled { get; set; }
    
}
