namespace DbWork
{
    public class UserHub<TEntity> where TEntity :class, IEntity
    {
        public List<TEntity> Entities { get; private set; }

        public UserHub()
        {
            Entities = new List<TEntity>();
        }

        public void Add(TEntity entity)
        {
            Entities.Add(entity);
        }

        public void Remove(int id)
        {
            var i = Entities.FirstOrDefault(i => i.Id == id);

            if(i != null)
                Entities.Remove(i);
        }

        public void Change(TEntity entity)
        {
            var existed = Entities.FirstOrDefault(i => i.Id == entity.Id);
            existed = entity;
        }
    }
}
