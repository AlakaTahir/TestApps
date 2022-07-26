using System;
using System.Collections.Generic;
using System.Text;
using Test.Model;

namespace Test.Logic
{
    public class DivisionLogic
    {
        public double Divide(CalculationModel model)
        {
            return model.NumA / model.NumB;
        }
        public double Add(CalculationModel model)
        {
            return model.NumA +model.NumB;
        }
    }
}
