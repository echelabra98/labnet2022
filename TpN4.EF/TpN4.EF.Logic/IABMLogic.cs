using System.Collections.Generic;

namespace TpN4.EF.Logic
{
    public interface IABMLogic<T, I>
    {
        List<T> GetAll();

        void Add(T item);

        void Delete(I id);
        
        void Update(T item);
    }
}
