using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAult.Models
{
    public class OperationModel
    {
        public string Value { get; set; }
        private OperationModel(string value) { Value = value; }

        public static OperationModel GreaterThan { get { return new OperationModel("GT"); } }
        public static OperationModel LessThan { get { return new OperationModel("LT"); } }
    }
}
