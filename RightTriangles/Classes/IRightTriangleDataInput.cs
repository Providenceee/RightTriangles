﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RightTriangles
{
    public interface IRightTriangleDataInput
    {
        public RightTriangleData InputData { get; }
        public Size Size { get; }
        public event Action? AnyValueChanged;
        public void UpdateDecimalAccuracy();
        public void UpdateIncrement();
    }
}
