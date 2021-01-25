using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Faces;
using DataModel;

namespace Business
{
    public class UserRepository : IUserRepository
    {
        ProjectEntities projectEntities = null;
        public UserRepository(ProjectEntities pEnt)
        {
            projectEntities = pEnt;
        }
        public void Add(User entity)
        {
            projectEntities.Users.Add(entity);
            projectEntities.SaveChanges();
        }

        public void Delete(User entity)
        {
            projectEntities.Users.Remove(entity);
            projectEntities.SaveChanges();

        }

        public List<User> GetAll()
        {
            return projectEntities.Users.ToList();
        }

        public User GetById(int id)
        {
            return projectEntities.Users.Find(id);
        }

        public void Update(User entityChanges)
        {
            projectEntities.Entry(entityChanges).State = System.Data.Entity.EntityState.Modified;
            projectEntities.SaveChanges();


        }
    }
}
