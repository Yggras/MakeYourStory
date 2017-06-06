using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Model
{
    public class Game
    {
        public int GameId { get; set; }
        public ICollection<ApplicationUser> Player { get; set; }
        public ApplicationUser Token { get; set; }
        public Story Story { get; set; }
    }
}
