using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAult.Models
{
    public class ActionModel
    {
        public string Value { get; set; }
        private ActionModel(string value) { Value = value; }

        public static ActionModel UP { get { return new ActionModel("{UP}"); } }
        public static ActionModel DOWN { get { return new ActionModel("{DOWN}"); } }
    }
}
