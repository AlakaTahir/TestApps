using System;
using System.Collections.Generic;
using System.Text;
using Test.Model;

namespace Test.Logic
{
    public class DivisionLogic
    {
        public double Divide(DivisionModel model)
        {
            return model.NumA / model.NumB;
        }
    }
}
