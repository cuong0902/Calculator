﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap
{
    public class Bai1
    {
        public static double Power(double x, int n)
        {
            if (n == 0)
                return 1.0;
            else if (n > 0)
                return n * Power(x, n - 1);
            else
                return Power(x, n + 1) / x;
        }
    }
}
