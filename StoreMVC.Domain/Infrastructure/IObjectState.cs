using System.ComponentModel.DataAnnotations.Schema;

namespace StoreMVC.Domain.Infrastructure
{
    public interface IObjectState
    {
        [NotMapped]
        ObjectState ObjectState { get; set; }
    }
}
