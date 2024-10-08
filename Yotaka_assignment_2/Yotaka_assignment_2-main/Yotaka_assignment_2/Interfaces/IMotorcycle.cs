﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yotaka_assignment_2.Models;

namespace Yotaka_assignment_2.Interfaces
{
    public interface IMotorcycle : IVehicle
    {
        string EngineType { get; set; }
        

        void StartEngine();
        void StopEngine();
        string Drive();
        void PutOnHelmet(); // added new method to put on helmet specific only for motorcycle
    }
}
