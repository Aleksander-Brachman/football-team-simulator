using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadProjekt
{
    class Recovery
    {
        private List<Player> players;
        private SwimmingPool sp;
        private Gym gym;
        private Physiotherapist physio;

        public Recovery(List<Player> _players, SwimmingPool _sp, Gym _gym, Physiotherapist _physio)
        {
            players = _players;
            sp = _sp;
            gym = _gym;
            physio = _physio;
        }

        public void RecoverTeam()
        {
            foreach (var p in players)
            {
                p.Health += sp.SPRecovery() + gym.GymRecovery() + physio.PhysioRecovery();
            }
        }
    }
}
