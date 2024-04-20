namespace _3_Solid_L_Problem.Solution.Data.BaseRepository
{
    public interface IRepository
    {
        IEnumerable<object> GetAll();

        object GetOne(string filter);

        bool Insert(object item);

        bool Update(object item);
       
        bool Remove(object item);
    }
}
