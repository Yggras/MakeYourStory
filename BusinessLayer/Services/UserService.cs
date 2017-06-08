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
        /// <summary>
        /// Get the complete History of Storys for the given User
        /// </summary>
        /// <param name="userId">Id of the User</param>
        /// <returns>ResponseObject with a Collection of Stories</returns>
        public ResponseObject<ICollection<Story>> GetStoryHistoryForUser(int userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the complete History of Storys for the given User
        /// </summary>
        /// <param name="user">Entity of the User</param>
        /// <returns>ResponseObject with a Collection of Stories</returns>
        public ResponseObject<ICollection<Story>> GetStoryHistoryForUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get All currently Active Games for the given User
        /// </summary>
        /// <param name="userId">Id of the User</param>
        /// <returns>ResponseObject with a Collection of Games</returns>
        public ResponseObject<ICollection<Game>> GetActiveGamesForUser(int userId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get All currently Active Games for the given User
        /// </summary>
        /// <param name="user">Entity of the User</param>
        /// <returns>ResponseObject with a Collection of Games</returns>
        public ResponseObject<ICollection<Game>> GetActiveGamesForUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get All Friends for the given User
        /// </summary>
        /// <param name="userId">Id of the User</param>
        /// <returns>ResponseObject with a Collection of ApplicationUser</returns>
        public ResponseObject<ICollection<ApplicationUser>> GetFriendsListForUser(int userId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Get All Friends for the given User
        /// </summary>
        /// <param name="user">Entity of the User</param>
        /// <returns>ResponseObject with a Collection of ApplicationUser</returns>
        public ResponseObject<ICollection<ApplicationUser>> GetFriendsListForUser(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add a User to the friendlist of the given User
        /// </summary>
        /// <param name="userId">Id of the User which wants to add a friend</param>
        /// <param name="friend">Entity of the Friend</param>
        /// <returns>Friendslist of the given User</returns>
        public ResponseObject<ICollection<ApplicationUser>> AddFriendToFriendlist(int userId, ApplicationUser friend)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Add a User to the friendlist of the given User
        /// </summary>
        /// <param name="user">Entity of the User which wants to add a friend</param>
        /// <param name="friend">Entity of the Friend</param>
        /// <returns>Friendslist of the given User</returns>
        public ResponseObject<ICollection<ApplicationUser>> AddFriendToFriendlist(ApplicationUser user, ApplicationUser friend)
        {
            throw new NotImplementedException();
        }
    }
}
