using System.Threading.Tasks;

namespace Colosoft.Input.Mapping
{
    public interface IMapperContextSupport<in TSource, in TTarget> : IMapper
    {
        Task Apply(TSource source, TTarget target, IMappingContext context);
    }
}
