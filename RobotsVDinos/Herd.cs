﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotsVDinos
{
    internal class Herd
    {
        public List<Dino> dinos;

        public Herd()
        {
            //Create dinos
            Dino trex = new Dino("trex", 100, 5, 5);
            Dino stego = new Dino("stego", 100, 15, 2);
            Dino terra = new Dino("terra", 100, 10, 3);

            //Create dino list
            this.dinos = new List<Dino>();

            //Add dinos to list
            dinos.Add(trex);
            dinos.Add(stego);
            dinos.Add(terra);
        }

    }
}
