using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.ResponseObject;
using DataLayer;
using DataLayer.Model;

namespace BusinessLayer.Interfaces
{
    public interface IGameService
    {
        ResponseObject<Game> CreateNewGame(int userId);
        ResponseObject<Game> CreateNewGame(ApplicationUser user);
        ResponseObject<ApplicationUser> GetCurrentToken(int gameId);
        ResponseObject<ApplicationUser> GetCurrentToken(Game game);
        
    }
}
