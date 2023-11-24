namespace Colosoft.Input.Mapping
{
    public interface IPropertyMap<in TSource, in TTarget>
    {
        string PropertyName { get; }

        void Apply(TSource source, TTarget target);
    }
}
