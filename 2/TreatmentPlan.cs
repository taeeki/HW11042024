using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treatment
{
    internal class TreatmentPlan
    {
        int code;
        public int Code { get => code; }
        public TreatmentPlan(int code)
        {
            this.code = code;
        }
    }
}
