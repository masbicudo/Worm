namespace Worm.Core
{
    public interface IWormap<in TData, in TModel>
    {
        void UpdateData(TData data, TModel model);

        void UpdateModel(TModel model, TData data);
    }
}