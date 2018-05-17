using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Snap7;
using System.IO;
using System.Threading;

namespace Demo_Visualisation
{
    public partial class Form1 : Form
    {

        //private S7Client host;
        private string sHostIP = "10.93.158.12";
        private string sTagFile = "tags.ini";

        private bool debugging = true;

        public List<sTAG> lTagAList = new List<sTAG>();

        public Form1()
        {
            InitializeComponent();
            configReader(sTagFile);
            populateTagList();
            populateControls();
        }

        #region [Visualisation Functions]

        private bool initializeConnection()
        {
            bool result = true;

            S7Client host = new S7Client();
            int res = host.ConnectTo(sHostIP, 0, 2);                //PLC connection string - IP address, rack, slot
            if (res != 0)
            {
                DebugHandler("Connection", "Res:" + res.ToString());
                result = false;
            }
            host.Disconnect();
            return result;
        }

        private void DebugHandler(string source, string fault)
        {
            if (debugging)
            {
                MessageBox.Show(source + "\n\n\n" + fault);
            }
        }

        private void configReader(string fileName)
        {
            string sTagDescriptor = "[TAG]";
            char cSeparator = ';';

            lTagAList = new List<sTAG>();

            string[] lines = System.IO.File.ReadAllLines(fileName);
            string[] splitter;
            bool marker = false;


            for (int i = 0; i < lines.Length; i++)
            {
                if (marker)
                {
                    try
                    {
                        splitter = lines[i].Split(cSeparator);
                        lTagAList.Add(new sTAG()
                        {
                            iType = int.Parse(splitter[0]),
                            iDBAddress = int.Parse(splitter[1]),
                            iStart = int.Parse(splitter[2]),
                            iLength = int.Parse(splitter[3]),
                            iBit = int.Parse(splitter[4]),
                            iRepresentation = int.Parse(splitter[5]),
                            sControlName = splitter[6],
                            bData = new byte[int.Parse(splitter[3])],
                            sDisplayName = splitter[7]
                        });
                    }
                    catch (Exception exc)
                    {
                        DebugHandler("CONFIG READ", exc.ToString());
                    }

                }
                if (lines[i] == sTagDescriptor)
                {
                    marker = true;                      //Tag list descriptor found - begin processing
                }
            }
        }
        //There is additional list of tags on the second tab page to list the tags
        private void populateTagList()
        {
            lvTags.Items.Clear();
            int listLength = lTagAList.Count;
            for (int i = 0; i < listLength; i++)
            {
                ListViewItem lvi = new ListViewItem(dataType(lTagAList[i].iType));
                lvi.SubItems.Add(lTagAList[i].iDBAddress.ToString());
                lvi.SubItems.Add(lTagAList[i].iStart.ToString());
                lvi.SubItems.Add(lTagAList[i].iLength.ToString());
                lvi.SubItems.Add(lTagAList[i].iBit.ToString());
                lvi.SubItems.Add(repFormat(lTagAList[i].iRepresentation));
                lvi.SubItems.Add(lTagAList[i].sControlName.ToString());
                lvi.SubItems.Add(lTagAList[i].formatedData().ToString());
                lvi.SubItems.Add(lTagAList[i].sDisplayName);
                lvTags.Items.Add(lvi);
            }
        }
        //change representation code to description
        private string repFormat(int rep)
        {
            string representation = "";

            switch (rep)
            {
                case 0:
                    {
                        representation = "BOOL";
                        break;
                    }
                case 1:
                    {
                        representation = "INT";
                        break;
                    }
                case 2:
                    {
                        representation = "CHAR";
                        break;
                    }
                case 3:
                    {
                        representation = "S7 STRING";
                        break;
                    }
                case 4:
                    {
                        representation = "BIN WORD";
                        break;
                    }
                case 5:
                    {
                        representation = "CHAR ARRAY";
                        break;
                    }
            }

            return representation;
        }
        //change data type code to description
        private string dataType(int type)
        {
            string sType = "";

            switch (type)
            {
                case 0:
                    {
                        sType = "DB";
                        break;
                    }
                case 1:
                    {
                        sType = "INPUT";
                        break;
                    }
                case 2:
                    {
                        sType = "OUTPUT";
                        break;
                    }
                case 3:
                    {
                        sType = "MARKER";
                        break;
                    }
            }


            return sType;
        }

        private void readTags()
        {
            S7Client host = new S7Client();
            host.ConnectTo(sHostIP, 0, 2);
            foreach (sTAG tag in lTagAList)
            {

                switch (tag.iType)
                {
                    case 0:                                     //DB
                        {
                            host.DBRead(tag.iDBAddress, tag.iStart, tag.iLength, tag.bData);
                            break;
                        }
                    case 1:                                     //Input
                        {
                            host.EBRead(tag.iStart, tag.iLength, tag.bData);
                            break;
                        }
                    case 2:                                     //Output
                        {
                            host.ABRead(tag.iStart, tag.iLength, tag.bData);
                            break;
                        }
                    case 3:                                     //Marker/Flag
                        {
                            host.MBRead(tag.iStart, tag.iLength, tag.bData);
                            break;
                        }
                }


            }
            host.Disconnect();

        }

        //this is where tag name in tags.ini and control name is cross checked and referenced to update values
        private void populateControls()
        {

            foreach (sTAG tag in lTagAList)
            {
                switch (tag.iRepresentation)
                {
                    case 0:
                        {
                            RadioButton rb = this.Controls.Find(tag.sControlName, true).FirstOrDefault() as RadioButton;
                            if (rb != null)
                            {
                                rb.Checked = (bool)tag.formatedData();
                                rb.Text = tag.sDisplayName;
                            }
                            Indicator.BoolIndicator bi = this.Controls.Find(tag.sControlName, true).FirstOrDefault() as Indicator.BoolIndicator;
                            if(bi != null)
                            {
                                bi.State = (bool)tag.formatedData();
                                bi.LabelText = tag.sDisplayName;
                            }
                            break;
                        }
                    case 1:
                        {
                            TextBox tb = this.Controls.Find(tag.sControlName, true).FirstOrDefault() as TextBox;
                            if (tb != null)
                            {
                                tb.Text = tag.formatedData().ToString();
                            }
                            break;
                        }
                    case 2:
                        {
                            TextBox tb = this.Controls.Find(tag.sControlName, true).FirstOrDefault() as TextBox;
                            if (tb != null)
                            {
                                tb.Text = tag.formatedData().ToString();
                            }
                            break;
                        }
                    case 3:
                        {
                            TextBox tb = this.Controls.Find(tag.sControlName, true).FirstOrDefault() as TextBox;
                            if (tb != null)
                            {
                                tb.Text = tag.formatedData().ToString();
                            }
                            break;
                        }
                    case 4:
                        {
                            TextBox tb = this.Controls.Find(tag.sControlName, true).FirstOrDefault() as TextBox;
                            if (tb != null)
                            {
                                tb.Text = Convert.ToString((byte)tag.formatedData(), 2).PadLeft(8, '0');
                            }
                            break;
                        }
                    case 5:
                        {
                            TextBox tb = this.Controls.Find(tag.sControlName, true).FirstOrDefault() as TextBox;
                            if (tb != null)
                            {
                                tb.Text = tag.formatedData().ToString();
                            }
                            break;
                        }
                }
            }
        }

        //single scan button
        private void button1_Click(object sender, EventArgs e)
        {
            configReader(sTagFile);
            populateTagList();
            if (initializeConnection())
            {
                readTags();
                populateTagList();
                populateControls();
            }
        }

        //online mode enable/disable
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "OFFLINE")
            {
                button2.Text = "ONLINE";
                button2.BackColor = Color.Lime;
                bwOnlineMode.RunWorkerAsync();
            }
            else
            {
                button2.Enabled = false;
                bwOnlineMode.CancelAsync();
            }
        }

        #endregion

        #region [ONLINE MODE]

        private void bwOnlineMode_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!bwOnlineMode.CancellationPending)
            {
                Thread.Sleep(1000);
                readTags();
                bwOnlineMode.ReportProgress(0);
            }
        }      

        private void bwOnlineMode_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            populateTagList();
            populateControls();
            userScript();
        }

        private void bwOnlineMode_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button2.Enabled = true;
            button2.Text = "OFFLINE";
            button2.BackColor = Color.Red;
        }

        #endregion

        #region [USER SCRIPTS]

        private void userScript()
        {
            if (bi_e63_0.State)
            {
                pb_Switch2.Image = Image.FromFile("Resources/Conveyor_Icon_Switch_0.bmp");
            }

            if (bi_e63_1.State)
            {
                pb_Switch2.Image = Image.FromFile("Resources/Conveyor_Icon.bmp");
            }

            if (bi_e60_5.State)
            {
                pb_Switch1.Image = Image.FromFile("Resources/Conveyor_Icon_Switch_180.bmp");
            }

            if (bi_e60_6.State)
            {
                pb_Switch1.Image = Image.FromFile("Resources/Conveyor_Icon.bmp");
            }
        }

        #endregion             
    }

    #region [PLC TAG CLASS]

    public class sTAG
    {
        public int iType { get; set; }              //0 = DB, 1 = I, 2 = O, 3 = M
        public int iDBAddress { get; set; }         //leave 0 for I/M
        public int iStart { get; set; }             //start area of rading
        public int iLength { get; set; }            //area size
        public int iBit { get; set; }               //if I or M specify Bit number or will be read/represented as integer         
        public int iRepresentation { get; set; }    //0 = bool, 1 = int, 2 = char, 3 = string, 4 = word
        public string sControlName { get; set; }    //name of the control in the visualisation side        
        public string sDisplayName { get; set; }    //name displayed next to the control (if applicable)
        public byte[] bData { get; set; }
        public object formatedData()
        {
            object oRetPlaceholder = null;
            string sReturn = "";
            int iReturn = 0;
            bool blReturn = false;
            byte byReturn = 0;
            char cReturn = '\n';
            
            //some processing of Snap7 return values from the PLC
            switch (iRepresentation)
            {
                case 0:
                    {

                        if ((bData[0] & (1 << iBit)) != 0)
                        {
                            blReturn = true;
                        }
                        if ((bData[0] & (1 << iBit)) == 0)
                        {
                            blReturn = false;
                        }
                        oRetPlaceholder = blReturn;
                        break;
                    }
                case 1:
                    {
                        if (iLength == 1)
                        {
                            iReturn = bData[0];
                        }
                        else
                        {
                            iReturn = BitConverter.ToInt32(bData, 0);
                        }
                        oRetPlaceholder = iReturn;
                        break;
                    }
                case 2:
                    {
                        cReturn = (char)bData[0];
                        oRetPlaceholder = cReturn;
                        break;
                    }
                case 3:
                    {
                        sReturn = "";
                        foreach (byte b in bData)
                        {
                            sReturn += (char)b;
                        }
                        oRetPlaceholder = sReturn.Substring(2);
                        break;
                    }
                case 4:
                    {
                        byReturn = bData[0];
                        oRetPlaceholder = byReturn;
                        break;
                    }
                case 5:
                    {
                        sReturn = "";
                        foreach (byte b in bData)
                        {
                            sReturn += (char)b;
                        }
                        oRetPlaceholder = sReturn;
                        break;
                    }
            }


            return oRetPlaceholder;
        }
    }
    #endregion

}
