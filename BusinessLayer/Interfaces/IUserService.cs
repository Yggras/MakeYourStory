using System.Collections;
using System.Collections.Generic;
using DataLayer;
using DataLayer.Model;
using BusinessLayer.ResponseObject;

namespace BusinessLayer.Interfaces
{
    public interface IUserService
    {
        ResponseObject<ICollection<Story>> GetStoryHistoryForUser(int userId);
        ResponseObject<ICollection<Story>> GetStoryHistoryForUser(ApplicationUser user);
        ResponseObject<ICollection<Game>> GetActiveGamesForUser(int userId);
        ResponseObject<ICollection<Game>> GetActiveGamesForUser(ApplicationUser user);
        ResponseObject<ICollection<ApplicationUser>> GetFriendsListForUser(int userId);
        ResponseObject<ICollection<ApplicationUser>> GetFriendsListForUser(ApplicationUser user);
        ResponseObject<ICollection<ApplicationUser>> AddFriendToFriendlist(int userId, ApplicationUser friend);
        ResponseObject<ICollection<ApplicationUser>> AddFriendToFriendlist(ApplicationUser user, ApplicationUser friend);
    }
}