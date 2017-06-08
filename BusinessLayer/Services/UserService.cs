using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Interfaces;
using BusinessLayer.Ninjas;
using BusinessLayer.ResponseObject;
using DataLayer;
using DataLayer.Model;

namespace BusinessLayer.Services
{
    public class UserService : Ninja, IUserService
    {
        public ResponseObject<ICollection<Story>> GetStoryHistoryForUser(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseObject<ICollection<Story>> GetStoryHistoryForUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public ResponseObject<ICollection<Story>> GetActiveStoriesForUser(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseObject<ICollection<Story>> GetActiveStoriesForUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public ResponseObject<ICollection<ApplicationUser>> GetFriendsListForUser(int id)
        {
            throw new NotImplementedException();
        }

        public ResponseObject<ICollection<ApplicationUser>> GetFriendsListForUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
    }
}
