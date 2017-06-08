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
    public class GameService : Ninja, IGameService
    {
        public ResponseObject<Game> CreateNewGame(int userId)
        {
            throw new NotImplementedException();
        }

        public ResponseObject<Game> CreateNewGame(ApplicationUser user)
        {
            throw new NotImplementedException();
        }

        public ResponseObject<ApplicationUser> GetCurrentToken(int gameId)
        {
            throw new NotImplementedException();
        }

        public ResponseObject<ApplicationUser> GetCurrentToken(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
