﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    interface IHasCorners
    {
        ICollection<double> GetCornersAngles();
    }
}
