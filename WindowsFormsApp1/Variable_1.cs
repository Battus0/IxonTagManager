using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class UAVariable
    {
        public string Name { get; set; }
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

        public string Unit { get; set; }

        public UAVariable()
        {

        }

        public string GetTagCsvString()
        {
            // outputFile2.WriteLine(string.Format("{0},{1},{2},1m,260w,last,,interval,,,", identifierN, nodeId, displayN));
            // CSV format:
            // outputFile2.WriteLine("Identifier,Address,Name,Logging interval,Retention policy,Edge aggregator,On change expiry,Log event,Trigger address,Trigger condition,Trigger threshold");

            return string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8};{9};{10}", Identifier, Address, Name, LoggingInterval, RetentionPolicy, EdgeAggregator, OnChangeExpiry, LogEvent, TriggerAddress, TriggerCondition, TriggerThreshold);
        }

        public string GetVarCsvString()
        {
            // outputFile.WriteLine(string.Format("{0},{1},{2},{3},,", identifierN, displayN, nodeId, TypeWidthSignedMaxstringlength));
            // CSV format:
            // outputFile.WriteLine("Identifier,Name,Address,Type,Width,Signed,Max string length,Factor,Unit");

            return string.Format("{0};{1};{2};{3};{4};{5};{6};{7};{8}", Identifier, Name, Address, Type, Width, Signed, Maxstringlength, Factor, Unit);
        }

        private void setTypesVars(string lastNode)
        {
            // https://help.codesys.com/webapp/varnames;product=LibDevSummary;version=3.5.17.0


            if (lastNode.StartsWith("x"))
            {
                Type = "bool";
                Width = "";
                Signed = "";
                Maxstringlength = "";
            }

            if (lastNode.StartsWith("t"))
            {
                Type = "int";
                Width = "64";
                Signed = "True";
                Maxstringlength = "";
            }

            if (lastNode.StartsWith("uli") || lastNode.StartsWith("auli"))
            {
                Type = "int";
                Width = "64";
                Signed = "False";
                Maxstringlength = "";
            }

            if (lastNode.StartsWith("r"))
            {
                Type = "float";
                Width = "32";
                Signed = "";
                Maxstringlength = "";
            }

            if (lastNode.StartsWith("ar"))
            {
                Type = "float";
                Width = "32";
                Signed = "";
                Maxstringlength = "";
            }

            if (lastNode.StartsWith("dw"))
            {
                Type = "int";
                Width = "32";
                Signed = "False";
                Maxstringlength = "";
            }

            if (lastNode.StartsWith("s"))
            {
                Type = "str";
                Width = "";
                Signed = "";
                Maxstringlength = "254"; // max
            }

            if (lastNode.StartsWith("ui"))
            {
                Type = "int";
                Width = "16";
                Signed = "False";
                Maxstringlength = "";
            }

            if (lastNode.StartsWith("by") || lastNode.StartsWith("usi"))
            {
                Type = "int";
                Width = "8";
                Signed = "False";
                Maxstringlength = "";
            }
        }
    }
}
