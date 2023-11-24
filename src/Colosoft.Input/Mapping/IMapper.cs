using System.Threading.Tasks;

namespace Colosoft.Input.Mapping
{
    public interface IMapper
    {
        Task Apply(object source, object target);
    }
}
