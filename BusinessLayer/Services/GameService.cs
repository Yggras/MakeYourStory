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
        /// <summary>
        /// Create a new Game of the given User
        /// </summary>
        /// <param name="userId">Id of the User</param>
        /// <returns>ResponseObject with the newly created Game</returns>
        public ResponseObject<Game> CreateNewGame(int userId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Create a new Game of the given User
        /// </summary>
        /// <param name="user">Entity of the User</param>
        /// <returns>ResponseObject with the newly created Game</returns>
        public ResponseObject<Game> CreateNewGame(ApplicationUser user)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets the User, which is on the Task to write the next line
        /// </summary>
        /// <param name="gameId">Id of the Game</param>
        /// <returns>ResponseObject with the user, who has to write the next Line</returns>
        public ResponseObject<ApplicationUser> GetCurrentToken(int gameId)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets the User, which is on the Task to write the next line
        /// </summary>
        /// <param name="game">Entity of the Game</param>
        /// <returns>ResponseObject with the user, who has to write the next Line</returns>
        public ResponseObject<ApplicationUser> GetCurrentToken(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
