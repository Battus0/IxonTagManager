using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchDisplayName = "DisplayName=";
            string searchNodeId = "NodeId=\"";

            string identifierN = "";
            string displayN = "";
            string nodeId = "";

            string inputFilename = UAexpertFilebox.Text;
            string outputVariablesFilename = OutputFileFars.Text;
            string outputTageFilename = OutputfileTags.Text;

            KeyValuePair<string, UAVariable> varList = new KeyValuePair<string, UAVariable>;
            UAVariable uAVariable = new UAVariable(); 

            using (StreamWriter outputFile = new StreamWriter(string.Format("{0}.txt", outputVariablesFilename)))
            {
                using (StreamWriter outputFile2 = new StreamWriter(string.Format("{0}.txt", outputTageFilename)))
                {
                    outputFile.WriteLine("Identifier,Name,Address,Type,Width,Signed,Max string length,Factor,Unit");
                    outputFile2.WriteLine("Identifier,Address,Name,Logging interval,Retention policy,Edge aggregator,On change expiry,Log event,Trigger address,Trigger condition,Trigger threshold");


                    foreach (string line in System.IO.File.ReadLines(inputFilename))
                    {
                        if (line.Contains(searchDisplayName))
                        {
                            displayN = getLine(line, searchDisplayName);
                            uAVariable.Name = displayN;
                        }
                        else if (line.Contains(searchNodeId))
                        {
                            // The nodeID contains a " at start and end. You have te remove this
                            int st = line.IndexOf(searchNodeId);
                            st = st + searchNodeId.Length;
                            int lng = line.Length;

                            // the magic nr 1 is for the " 
                            nodeId = line.Substring(st, lng - (st + 1));

                            uAVariable.Identifier = nodeId;
                        }

                        if (displayN != "" & nodeId != "")
                        {
                            // split the namespace 
                            string[] subs = nodeId.Split('.');
                            string lastNode = subs[subs.Length - 1];
                            string preLastNode = subs[subs.Length - 2];
                            
                            string TypeWidthSignedMaxstringlength = getTypesVars(lastNode);

                            setTheIdentifier(lastNode, preLastNode, ref identifierN, ref displayN);

                            outputFile.WriteLine(string.Format("{0},{1},{2},{3},,", identifierN, displayN, nodeId, TypeWidthSignedMaxstringlength));
                            outputFile2.WriteLine(string.Format("{0},{1},{2},1m,260w,last,,interval,,,", identifierN, nodeId, displayN));
                            displayN = "";
                            nodeId = "";
                            identifierN = "";
                        }
                    }
                }
            }
        }

        private void setTheIdentifier(string lastNode, string preLastNode, ref string identifierN, ref string displayN)
        {
            if (preLastNode.StartsWith("fb"))
            {
                identifierN = string.Format("{0}{1}", preLastNode, lastNode);
                displayN = string.Format("{0}-{1}", preLastNode, lastNode);
            }
            else
            {
                identifierN = string.Format("{0}",  lastNode);
                displayN = string.Format("{0}",  lastNode);
            }
        }

        private string getTypesVars(string lastNode)
        {
            string varType = "";
            string varWidth = "";
            string varSigned = "";
            string varMaxStrLength = "";

            // https://help.codesys.com/webapp/varnames;product=LibDevSummary;version=3.5.17.0

            
            if (lastNode.StartsWith("x"))
            {
                varType = "bool";
                varWidth = "";
                varSigned = "";
                varMaxStrLength = "";
            }

            if (lastNode.StartsWith("t"))
            {
                varType = "int";
                varWidth = "64";
                varSigned = "True";
                varMaxStrLength = "";
            }

            if (lastNode.StartsWith("uli") || lastNode.StartsWith("auli"))
            {
                varType = "int";
                varWidth = "64";
                varSigned = "False";
                varMaxStrLength = "";
            }

            if (lastNode.StartsWith("r"))
            {
                varType = "float";
                varWidth = "32";
                varSigned = "";
                varMaxStrLength = "";
            }

            if (lastNode.StartsWith("ar"))
            {
                varType = "float";
                varWidth = "32";
                varSigned = "";
                varMaxStrLength = "";
            }

            if (lastNode.StartsWith("dw"))
            {
                varType = "int";
                varWidth = "32";
                varSigned = "False";
                varMaxStrLength = "";
            }

            if (lastNode.StartsWith("s"))
            {
                varType = "str";
                varWidth = "";
                varSigned = "";
                varMaxStrLength = "254"; // max
            }

            if (lastNode.StartsWith("ui"))
            {
                varType = "int";
                varWidth = "16";
                varSigned = "False";
                varMaxStrLength = "";
            }

            if (lastNode.StartsWith("by") || lastNode.StartsWith("usi"))
            {
                varType = "int";
                varWidth = "8";
                varSigned = "False";
                varMaxStrLength = "";
            }
            

            return string.Format("{0},{1},{2},{3}", varType, varWidth, varSigned, varMaxStrLength);
        }

        private string getLine(string line, string searchString)
        {
            int st = line.IndexOf(searchString);
            st += searchString.Length;
            int lng = line.Length;

            return line.Substring(st, lng - st);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                UAexpertFilebox.Text = fd.FileName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }



}
