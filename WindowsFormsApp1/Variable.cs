using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class UAVariable
    {
        public int Name { get; set; }
        public string Identifier { get; set; }
        public string Address { get; set; }
        public string Type { get; set; }
        public string Width { get; set; }
        public string Signed { get; set; }
        public string Maxstringlength { get; set; }
        public string Factor { get; set; }
        public string LoggingInterval { get; set; }
        public string RetentionPolicy { get; set; }
        public string EdgeAggregator { get; set; }
        public string OnChangeExpiry { get; set; }
        public string LogEvent { get; set; }
        public string TriggerAddress { get; set; }
        public string TriggerCondition { get; set; }
        public string TriggerThreshold { get; set; }
       
        public UAVariable()
        {

        }

        public string GetTagCsvString ()
        {

            return "";
        }

          public string GetVarCsvString()
        {

            return "";
        }


    }
}
