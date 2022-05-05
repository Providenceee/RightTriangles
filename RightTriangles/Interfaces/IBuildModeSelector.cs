﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightTriangles
{
    public interface IBuildModeSelector
    {
        public IBuildMode SelectMode(RightTriangleData data);
    }
}
