using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExpertSystem
{
    public class Frame
    {
        private string frameName;
        private Dictionary<string, string> field;

        public Frame(string name)
        {
            this.frameName = name;
            field = new Dictionary<string, string>();
        }
        ~Frame() { field.Clear(); field = null; }

        public void addFieldAndValue(string key, string value)
        {
            field.Add(key, value);
        }
    }
}
