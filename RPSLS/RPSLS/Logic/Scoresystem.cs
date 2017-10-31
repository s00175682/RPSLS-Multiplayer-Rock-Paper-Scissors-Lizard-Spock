﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS.Logic
{
    class Scoresystem
    {
        private int _player1Points;
        private int _player2Points;

        public int Player1Points { get => _player1Points; set => _player1Points = value; }
        public int Player2Points { get => _player2Points; set => _player2Points = value; }

        public Scoresystem()
        {
            Player1Points = 0;
            Player2Points = 0;    
        }
    }
}
