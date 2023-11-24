using System.Threading.Tasks;

namespace Colosoft.Input.Mapping
{
    public interface IPropertyMapAsync<in TSource, in TTarget> : IPropertyMap<TSource, TTarget>
    {
        Task ApplyAsync(TSource source, TTarget target, IMappingContext context = null);
    }
}
