
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;

namespace Dash.Managers
{
    public abstract class AbstractManager<T> : IManager where T : IManaged
    {
        protected readonly IList<T> managed;

        protected AbstractManager(T defvalue = default(T))
        {
            try
            {
                managed = Deserialize();
            }
            catch (FileNotFoundException)
            {

                throw;
            }
        }

        public void Save()
        {
            Serialize();
        }
        public IList<T> Get()
        {
            return new ReadOnlyCollection<T>(managed);
        }

        public T FindById(int id)
        {
            return managed.Where(kor => kor.Id == id).FirstOrDefault();
        }

        public void Delete(T obj)
        {
            managed.Remove(obj);
        }

        protected abstract void Serialize();
        protected abstract IList<T> Deserialize();

        public abstract void PreventCollision();
    }
}
