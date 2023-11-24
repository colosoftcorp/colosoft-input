using System.Threading.Tasks;

namespace Colosoft.Input.Mapping
{
    public interface IMappingContextSupport : IMapper
    {
        Task Apply(object source, object target, IMappingContext context);
    }
}
