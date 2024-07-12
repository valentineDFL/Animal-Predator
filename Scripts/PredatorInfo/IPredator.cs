﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts
{
    internal interface IPredator
    {
        public void Move();
        public bool Flairs(float distanceActivate);
        public void MoveToAnimal();
    }
}
