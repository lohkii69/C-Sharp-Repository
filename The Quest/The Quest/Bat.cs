﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace The_Quest
{
    class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game,location,6) {}

        public override void Move(Random random)
        {
            throw new NotImplementedException();
        }
    }
}
