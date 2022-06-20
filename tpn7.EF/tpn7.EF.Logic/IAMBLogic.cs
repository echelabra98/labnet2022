using System.Collections.Generic;

namespace tpn7.EF.Logic
{
    public interface IAMBLogic <T, I>
    {
        List<T> GetAll();

        void Add(T item);

        void Delete(I id);

        void Update(T item);
    }
}
