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
namespace DNA_Sequence
{
    
    public partial class Form1 : Form
    {
        public int stnum;
        public string[] resSite = new string[10000];
        public string[] resName = new string[10000];
        public bool ifNew;
        public bool ifEdited;
        public bool ifEditingDNA;
        public string seqName;
        public void readRes()
        {
            if (!File.Exists("../../ReadLog.dll"))
            {
                File.Create("../../ReadLog.dll");
            }
            string stdFilePath = @"../../ReadLog.dll";
            StreamReader srReadFile = new StreamReader(stdFilePath,Encoding.UTF8);
            stnum = 0;
            while (!srReadFile.EndOfStream)
            {
                resName[stnum] = srReadFile.ReadLine();
                resSite[stnum] = srReadFile.ReadLine();
                stnum++;
            }
            srReadFile.Close();
        }
        public void refresh()
        {
            listBoxDRS.Items.Clear();
            for (int i = 0; i < stnum; i++)
            {
                listBoxDRS.Items.Add(resName[i] + "\t(" + resSite[i] + ")  ");
            }
        }
        public bool saveas()
        {
            SaveFileDialog saveSeq = new SaveFileDialog();
            saveSeq.Filter = "DNA Sequence(*.seq)|*.seq";
            saveSeq.FileName = seqName;
            if (saveSeq.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(saveSeq.FileName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.Write(textBoxDSeq.Text);
                sw.Flush();
                sw.Close();
                seqName = saveSeq.FileName;
                this.Text = seqName;
                ifEdited = false;
                ifNew = false;
                textBoxDSeq.ClearUndo();
                return true;
            }
            return false;
        }
        public bool save()
        {
            if (ifNew == true)
            {
                return saveas();
            }
            else
            {
                FileStream fs = new FileStream(seqName, FileMode.Create);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.Write(textBoxDSeq.Text);
                sw.Flush();
                sw.Close();
                this.Text = seqName;
                ifEdited = false;
                ifNew = false;
                textBoxDSeq.ClearUndo();
                return true;
            }
        }
        public void open()
        {
            OpenFileDialog of = new OpenFileDialog();
            of.Filter = "DNA Sequence(*.seq)|*.seq|Text files(*.txt)|*.txt";
            of.Multiselect = false;
            if(of.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(of.FileName,FileMode.Open);
                StreamReader sr = new StreamReader(fs,Encoding.UTF8);
                textBoxDSeq.ClearUndo();
                textBoxDSeq.Clear();
                textBoxDSeq.Text = sr.ReadToEnd();
                ifNew = false;
                ifEdited = false;
                seqName = of.FileName;
                this.Text = seqName + " - BIC DNA";
            }
        }
        public void resize()
        {
            tabControlDS.Height = this.Height - 50;
            listBoxDRS.Height = tabPage1.Height - 280;
            label3.Top = listBoxDRS.Top + listBoxDRS.Height + 20;
            label4.Top = label3.Top + label3.Height + 20;
            textBoxresName.Top = label4.Top + label4.Height + 10;
            label5.Top = textBoxresName.Top + textBoxresName.Height + 20;
            textBoxresSeq.Top = label5.Top + label5.Height + 10;
            buttonAddResSite.Top= textBoxresSeq.Top + textBoxresSeq.Height + 20;
            textBoxDSeq.Height = (this.Height - 160) * 3 / 4;
            textBoxRSeq.Height = (this.Height - 160) * 3 / 4;
            textBoxPSeq.Height = (this.Height - 160) / 4;
            textBoxPSeq.Top = textBoxDSeq.Bottom;
            buttonA.Top = textBoxPSeq.Bottom + 15;
            buttonT.Top = textBoxPSeq.Bottom + 15;
            buttonC.Top = textBoxPSeq.Bottom + 15;
            buttonG.Top = textBoxPSeq.Bottom + 15;
            //Left
            textBoxDSeq.Width = (this.Width - 480) / 3 * 2;
            textBoxRSeq.Width = (this.Width - 480) / 3;
            textBoxRSeq.Left = textBoxDSeq.Right;
            textBoxPSeq.Width = (this.Width - 480);
            label2.Left = textBoxRSeq.Left;
            buttonSbmt.Left = textBoxRSeq.Right + 10;
            buttonClr.Left = textBoxRSeq.Right + 10;
            buttonRev.Left = textBoxRSeq.Right + 10;
            buttonRevs.Left = textBoxRSeq.Right + 10;
            buttonA.Width = (this.Width - 480) / 4;
            buttonT.Width = (this.Width - 480) / 4;
            buttonC.Width = (this.Width - 480) / 4;
            buttonG.Width = (this.Width - 480) / 4;
            buttonT.Left = buttonA.Left + ((this.Width - 480) - buttonA.Width) / 3;
            buttonC.Left = buttonA.Left + ((this.Width - 480) - buttonA.Width) / 3 * 2;
            buttonG.Left = buttonA.Left + ((this.Width - 480) - buttonA.Width);
        }
        public string TransSription(string DNA)
        {
            string RNA = "";
            for(int i=0;i<DNA.Length;i++)
            {
                string temp = DNA.Substring(i, 1);
                switch (temp)
                {
                    case "A":
                        RNA += "A";
                        break;
                    case "T":
                        RNA += "U";
                        break;
                    case "C":
                        RNA += "C";
                        break;
                    case "G":
                        RNA += "G";
                        break;
                    default:
                        break;
                }
            }
            return RNA;
        }
        public string AntiTransSription(string RNA)
        {
            string DNA = "";
            for (int i = 0; i < RNA.Length; i++)
            {
                string temp = RNA.Substring(i, 1);
                switch (temp)
                {
                    case "A":
                        DNA += "A";
                        break;
                    case "U":
                        DNA += "T";
                        break;
                    case "C":
                        DNA += "C";
                        break;
                    case "G":
                        DNA += "G";
                        break;
                    default:
                        break;
                }
            }
            return DNA;
        }
        public void Translation()
        {
            string RNA = textBoxRSeq.Text;
            textBoxPSeq.Text = ""; 
            string protein = "";
            int proNum = 0;
            int i = 0;
            string temp="";
            while (i < RNA.Length)
            {
                if(temp.Length<3)
                {
                    temp += RNA[i];
                }
                else
                {
                    temp = temp.Substring(1, 2) + RNA[i];
                }
                if (temp == "AUG") 
                {
                    proNum++;
                    protein = "M";
                    temp = "";
                    while (i+1 < RNA.Length)
                    {
                        if (temp == "UAA" || temp == "UAG" || temp == "UGA")
                        {
                            temp = "";
                            break;
                        }
                        i++;
                        if (temp.Length < 3)
                        {
                            temp += RNA[i];
                        }
                        else
                        {
                            temp = temp.Substring(1, 2) + RNA[i];
                        }
                        switch (temp)
                            {
                                //UUX
                                case "UUU":
                                    protein += "F";
                                    temp = "";
                                    break;
                                case "UUC":
                                    protein += "F";
                                    temp = "";
                                    break;
                                case "UUA":
                                    protein += "L";
                                    temp = "";
                                    break;
                                case "UUG":
                                    protein += "L";
                                    temp = "";
                                    break;
                                //UCX
                                case "UCU":
                                    protein += "S";
                                    temp = "";
                                    break;
                                case "UCC":
                                    protein += "S";
                                    temp = "";
                                    break;
                                case "UCA":
                                    protein += "S";
                                    temp = "";
                                    break;
                                case "UCG":
                                    protein += "S";
                                    temp = "";
                                    break;
                                //UAX
                                case "UAU":
                                    protein += "Y";
                                    temp = "";
                                    break;
                                case "UAC":
                                    protein += "Y";
                                    temp = "";
                                    break;
                            //UGX
                            case "UGU":
                                    protein += "C";
                                    temp = "";
                                    break;
                                case "UGC":
                                    protein += "C";
                                    temp = "";
                                    break;
                                case "UGG":
                                    protein += "W";
                                    temp = "";
                                    break;
                                //CUX
                                case "CUU":
                                    protein += "L";
                                    temp = "";
                                    break;
                                case "CUC":
                                    protein += "L";
                                    temp = "";
                                    break;
                                case "CUA":
                                    protein += "L";
                                    temp = "";
                                    break;
                                case "CUG":
                                    protein += "L";
                                    temp = "";
                                    break;
                                //CCX
                                case "CCU":
                                    protein += "P";
                                    temp = "";
                                    break;
                                case "CCC":
                                    protein += "P";
                                    temp = "";
                                    break;
                                case "CCA":
                                    protein += "P";
                                    temp = "";
                                    break;
                                case "CCG":
                                    protein += "P";
                                    temp = "";
                                    break;
                                //CAX
                                case "CAU":
                                    protein += "H";
                                    temp = "";
                                    break;
                                case "CAC":
                                    protein += "H";
                                    temp = "";
                                    break;
                                case "CAA":
                                    protein += "Q";
                                    temp = "";
                                    break;
                                case "CAG":
                                    protein += "Q";
                                    temp = "";
                                    break;
                                //CGX
                                case "CGU":
                                    protein += "R";
                                    temp = "";
                                    break;
                                case "CGC":
                                    protein += "R";
                                    temp = "";
                                    break;
                                case "CGA":
                                    protein += "R";
                                    temp = "";
                                    break;
                                case "CGG":
                                    protein += "R";
                                    temp = "";
                                    break;
                                //AUX
                                case "AUU":
                                    protein += "I";
                                    temp = "";
                                    break;
                                case "AUC":
                                    protein += "I";
                                    temp = "";
                                    break;
                                case "AUA":
                                    protein += "I";
                                    temp = "";
                                    break;
                                case "AUG":
                                    protein += "M";
                                    temp = "";
                                    break;
                                //ACX
                                case "ACU":
                                    protein += "T";
                                    temp = "";
                                    break;
                                case "ACC":
                                    protein += "T";
                                    temp = "";
                                    break;
                                case "ACA":
                                    protein += "T";
                                    temp = "";
                                    break;
                                case "ACG":
                                    protein += "T";
                                    temp = "";
                                    break;
                                //AAX
                                case "AAU":
                                    protein += "N";
                                    temp = "";
                                    break;
                                case "AAC":
                                    protein += "N";
                                    temp = "";
                                    break;
                                case "AAA":
                                    protein += "K";
                                    temp = "";
                                    break;
                                case "AAG":
                                    protein += "K";
                                    temp = "";
                                    break;
                                //AGX
                                case "AGU":
                                    protein += "S";
                                    temp = "";
                                    break;
                                case "AGC":
                                    protein += "S";
                                    temp = "";
                                    break;
                                case "AGA":
                                    protein += "R";
                                    temp = "";
                                    break;
                                case "AGG":
                                    protein += "R";
                                    temp = "";
                                    break;
                                //GUX
                                case "GUU":
                                    protein += "V";
                                    temp = "";
                                    break;
                                case "GUC":
                                    protein += "V";
                                    temp = "";
                                    break;
                                case "GUA":
                                    protein += "V";
                                    temp = "";
                                    break;
                                case "GUG":
                                    protein += "V";
                                    temp = "";
                                    break;
                                //GCX
                                case "GCU":
                                    protein += "A";
                                    temp = "";
                                    break;
                                case "GCC":
                                    protein += "A";
                                    temp = "";
                                    break;
                                case "GCA":
                                    protein += "A";
                                    temp = "";
                                    break;
                                case "GCG":
                                    protein += "A";
                                    temp = "";
                                    break;
                                //GAX
                                case "GAU":
                                    protein += "D";
                                    temp = "";
                                    break;
                                case "GAC":
                                    protein += "D";
                                    temp = "";
                                    break;
                                case "GAA":
                                    protein += "E";
                                    temp = "";
                                    break;
                                case "GAG":
                                    protein += "E";
                                    temp = "";
                                    break;
                                //GGX
                                case "GGU":
                                    protein += "G";
                                    temp = "";
                                    break;
                                case "GGC":
                                    protein += "G";
                                    temp = "";
                                    break;
                                case "GGA":
                                    protein += "G";
                                    temp = "";
                                    break;
                                case "GGG":
                                    protein += "G";
                                    temp = "";
                                    break;
                                default:
                                    break;
                            }
                    };
                    i++;
                    textBoxPSeq.Text += "Protein" + proNum.ToString() + ": " + protein + "\r\n";
                }
                else
                {
                    i++;
                }
            }
        }
        public void clean()
        {
            if (ifEditingDNA)
            {
                int q = textBoxDSeq.SelectionStart;
                string DNA = textBoxDSeq.Text;
                string rDNA = "";
                for (int i = 0; i < DNA.Length; i++)
                {
                    string temp = DNA.Substring(i, 1);
                    switch (temp)
                    {
                        case "A":
                            rDNA += "A";
                            break;
                        case "T":
                            rDNA += "T";
                            break;
                        case "C":
                            rDNA += "C";
                            break;
                        case "G":
                            rDNA += "G";
                            break;
                        default:
                            q--;
                            break;
                    }
                }
                textBoxDSeq.Text = rDNA;
                textBoxDSeq.SelectionStart = q;
            }
            else
            {
                int q = textBoxRSeq.SelectionStart;
                string RNA = textBoxRSeq.Text;
                string rRNA = "";
                for (int i = 0; i < RNA.Length; i++)
                {
                    string temp = RNA.Substring(i, 1);
                    switch (temp)
                    {
                        case "A":
                            rRNA += "A";
                            break;
                        case "U":
                            rRNA += "U";
                            break;
                        case "C":
                            rRNA += "C";
                            break;
                        case "G":
                            rRNA += "G";
                            break;
                        default:
                            q--;
                            break;
                    }
                }
                textBoxRSeq.Text = rRNA;
                textBoxRSeq.SelectionStart = q;
            }
        }
        public void readSetting()
        {
            string stlocation = @"../../Settings.dll";
            FileStream fs = new FileStream(stlocation,FileMode.Open);
            StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            Common pv = new Common();
            pv.threel = Convert.ToBoolean(sr.ReadLine());
            pv.sep = Convert.ToBoolean(sr.ReadLine());
            sr.Close();
        }
        public string flipped(string a)
        {
            string ans = "";
            for (int i = 0;i< a.Length;i++)
            {
                ans += a[a.Length - i - 1].ToString();
            }
            return ans;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ifNew = true;
            ifEdited = false;
            ifEditingDNA = true;
            textBoxRSeq.BackColor = Color.LightGray;
            seqName = "untitled.seq";
            this.Text = "untitled.seq" + " - BIC DNA";
            readSetting();
            readRes();
            refresh();
            resize();
        }

        private void buttonADD_Click(object sender, EventArgs e)
        {
            if(tabControlDS.SelectedIndex==0)
            {
                if(listBoxDRS.SelectedItem==null)
                {
                    MessageBox.Show("You have not choose a restriction site yet!");
                }
                else
                {
                    string s = textBoxDSeq.Text;
                    int idx = textBoxDSeq.SelectionStart;
                    s = s.Insert(idx, resSite[listBoxDRS.SelectedIndex]);
                    textBoxDSeq.Text = s;
                    textBoxDSeq.SelectionStart = idx + resSite[listBoxDRS.SelectedIndex].Length;
                    textBoxDSeq.Focus();
                }
            }
        }

        private void buttonClr_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to clear this sequence?", "Attention", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                textBoxDSeq.Text = "";
                textBoxRSeq.Text = "";
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (ifEditingDNA)
            {
                string s = textBoxDSeq.Text;
                int idx = textBoxDSeq.SelectionStart;
                s = s.Insert(idx, "A");
                textBoxDSeq.Text = s;
                textBoxDSeq.SelectionStart = idx + 1;
                textBoxDSeq.Focus();
            }
            else
            {
                string s = textBoxRSeq.Text;
                int idx = textBoxRSeq.SelectionStart;
                s = s.Insert(idx, "A");
                textBoxRSeq.Text = s;
                textBoxRSeq.SelectionStart = idx + 1;
                textBoxRSeq.Focus();
            }
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            if (ifEditingDNA)
            {
                string s = textBoxDSeq.Text;
                int idx = textBoxDSeq.SelectionStart;
                s = s.Insert(idx, "T");
                textBoxDSeq.Text = s;
                textBoxDSeq.SelectionStart = idx + 1;
                textBoxDSeq.Focus();
            }
            else
            {
                string s = textBoxRSeq.Text;
                int idx = textBoxRSeq.SelectionStart;
                s = s.Insert(idx, "U");
                textBoxRSeq.Text = s;
                textBoxRSeq.SelectionStart = idx + 1;
                textBoxRSeq.Focus();
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            if (ifEditingDNA)
            {
                string s = textBoxDSeq.Text;
                int idx = textBoxDSeq.SelectionStart;
                s = s.Insert(idx, "C");
                textBoxDSeq.Text = s;
                textBoxDSeq.SelectionStart = idx + 1;
                textBoxDSeq.Focus();
            }
            else
            {
                string s = textBoxRSeq.Text;
                int idx = textBoxRSeq.SelectionStart;
                s = s.Insert(idx, "C");
                textBoxRSeq.Text = s;
                textBoxRSeq.SelectionStart = idx + 1;
                textBoxRSeq.Focus();
            }
        }

        private void buttonG_Click(object sender, EventArgs e)
        {
            if (ifEditingDNA)
            {
                string s = textBoxDSeq.Text;
                int idx = textBoxDSeq.SelectionStart;
                s = s.Insert(idx, "G");
                textBoxDSeq.Text = s;
                textBoxDSeq.SelectionStart = idx + 1;
                textBoxDSeq.Focus();
            }
            else
            {
                string s = textBoxRSeq.Text;
                int idx = textBoxRSeq.SelectionStart;
                s = s.Insert(idx, "G");
                textBoxRSeq.Text = s;
                textBoxRSeq.SelectionStart = idx + 1;
                textBoxRSeq.Focus();
            }
        }

        private void listBoxDRS_DoubleClick(object sender, EventArgs e)
        {
            string s = textBoxDSeq.Text;
            int idx = textBoxDSeq.SelectionStart;
            s = s.Insert(idx, resSite[listBoxDRS.SelectedIndex]);
            textBoxDSeq.Text = s;
            textBoxDSeq.SelectionStart = idx + resSite[listBoxDRS.SelectedIndex].Length;
            textBoxDSeq.Focus();
        }

        private void textBoxDSeq_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (tabControlDS.SelectedIndex == 0)
            {
                
                if (listBoxDRS.SelectedItem == null)
                {
                    MessageBox.Show("You have not choose a re site yet!");
                }
                else
                {
                    if (MessageBox.Show("Are you sure to remove this restriction site from the table?", "Attention", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        for (int i = listBoxDRS.SelectedIndex; i < stnum - 1; i++) 
                        {
                            resName[i] = resName[i + 1];
                            resSite[i] = resSite[i + 1];
                        }
                        stnum--;
                        refresh();
                    }
                }
            }
        }

        private void buttonAddResSite_Click(object sender, EventArgs e)
        {
            if (textBoxresName.Text == "" || textBoxresSeq.Text == "") 
            {
                MessageBox.Show("Name or sequence has not been input!");
            }
            else
            {
                for(int i=0;i<stnum;i++)
                {
                    if(textBoxresName.Text==resName[i]||textBoxresSeq.Text==resSite[i])
                    {
                        MessageBox.Show("Name or DNA sequence exists!\nName:" + resName[i] + "\nSequence:" + resSite[i],"Attention");
                        return;
                    }
                }
                resName[stnum] = textBoxresName.Text;
                textBoxresName.Text = "";
                resSite[stnum] = textBoxresSeq.Text;
                textBoxresSeq.Text = "";
                stnum++;
                refresh();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveas();
        }

        private void textBoxDSeq_TextChanged(object sender, EventArgs e)
        {
            if (ifEdited==false)
            {
                this.Text =seqName + "*"+ " - BIC DNA";
            }
            ifEdited = true;
            if (ifEditingDNA) textBoxRSeq.Text = TransSription(textBoxDSeq.Text);
            clean();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(ifEdited)
            {
                DialogResult dR = MessageBox.Show("Changes has not been saved. Save changes?", "Attention", MessageBoxButtons.YesNoCancel);
                if (dR == DialogResult.Yes)
                {
                    if(save()==false)
                    {
                        e.Cancel = true;
                    }

                }
                else if (dR==DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ifEdited)
            {
                DialogResult dR = MessageBox.Show("Changes has not been saved. Save changes?", "Attention", MessageBoxButtons.YesNo);
                if (dR == DialogResult.Yes)
                {
                    if(save())
                    {
                        textBoxDSeq.Clear();
                        ifNew = true;
                        ifEdited = false;
                        seqName = "untitled.seq" + " - BIC DNA";
                        this.Text = seqName;
                        textBoxDSeq.ClearUndo();
                    }
                }
                else if (dR == DialogResult.No)
                {
                    textBoxDSeq.Clear();
                    ifNew = true;
                    ifEdited = false;
                    seqName = "untitled.seq" + " - BIC DNA";
                    this.Text = seqName;
                    textBoxDSeq.ClearUndo();
                }
            }
            else
            {
                textBoxDSeq.Clear();
                ifNew = true;
                ifEdited = false;
                seqName = "untitled.seq" + " - BIC DNA";
                this.Text = seqName;
                textBoxDSeq.ClearUndo();
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void undoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^c");
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^x");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ifEdited)
            {
                DialogResult dR = MessageBox.Show("Changes has not been saved. Save changes?", "Attention", MessageBoxButtons.YesNo);
                if (dR == DialogResult.Yes)
                {
                    if (save())
                    {
                        open();
                    }
                }
                else if (dR == DialogResult.No)
                {
                    open();
                }
            }
            else
            {
                open();
            }
        }

        private void undoToolStripMenuItem_Click_2(object sender, EventArgs e)
        {

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDSeq.Focus();
            SendKeys.Send("^v");
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDSeq.Focus();
            SendKeys.Send("{DELETE}");
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            resize();
        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBoxDSeq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) e.Handled = true;
        }

        private void textBoxresSeq_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void ListBoxDRS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                if (listBoxDRS.SelectedItem == null)
                {
                    MessageBox.Show("You have not choose a restriction site yet!");
                }
                else
                {
                    string s = textBoxDSeq.Text;
                    int idx = textBoxDSeq.SelectionStart;
                    s = s.Insert(idx, resSite[listBoxDRS.SelectedIndex]);
                    textBoxDSeq.Text = s;
                    textBoxDSeq.SelectionStart = idx + resSite[listBoxDRS.SelectedIndex].Length;
                }
            }
        }

        private void ToolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxDSeq_MouseUp(object sender, MouseEventArgs e)
        {
            if (textBoxDSeq.SelectionLength != 0)
            {
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem1.Enabled = true;
                cutToolStripMenuItem1.Enabled = true;
                deleteToolStripMenuItem1.Enabled = true;
                flipSelectToolStripMenuItem.Enabled = true;
                reverseSelectToolStripMenuItem.Enabled = true;
                translateSelectToolStripMenuItem.Enabled = true;
                flipSelectToolStripMenuItem1.Enabled = true;
                reverseSelectToolStripMenuItem1.Enabled = true;
                translateSelectToolStripMenuItem1.Enabled = true;
            }
            else
            {
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem1.Enabled = false;
                cutToolStripMenuItem1.Enabled = false;
                deleteToolStripMenuItem1.Enabled = false;
                flipSelectToolStripMenuItem.Enabled = false;
                reverseSelectToolStripMenuItem.Enabled = false;
                translateSelectToolStripMenuItem.Enabled = false;
                flipSelectToolStripMenuItem1.Enabled = false;
                reverseSelectToolStripMenuItem1.Enabled = false;
                translateSelectToolStripMenuItem1.Enabled = false;
            }
        }

        private void TextBoxDSeq_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxDSeq.SelectionLength != 0)
            {
                copyToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem1.Enabled = true;
                cutToolStripMenuItem1.Enabled = true;
                deleteToolStripMenuItem1.Enabled = true;
                flipSelectToolStripMenuItem.Enabled = true;
                reverseSelectToolStripMenuItem.Enabled = true;
                translateSelectToolStripMenuItem.Enabled = true;
                flipSelectToolStripMenuItem1.Enabled = true;
                reverseSelectToolStripMenuItem1.Enabled = true;
                translateSelectToolStripMenuItem1.Enabled = true;
            }
            else
            {
                copyToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem1.Enabled = false;
                cutToolStripMenuItem1.Enabled = false;
                deleteToolStripMenuItem1.Enabled = false;
                flipSelectToolStripMenuItem.Enabled = false;
                reverseSelectToolStripMenuItem.Enabled = false;
                translateSelectToolStripMenuItem.Enabled = false;
                flipSelectToolStripMenuItem1.Enabled = false;
                reverseSelectToolStripMenuItem1.Enabled = false;
                translateSelectToolStripMenuItem1.Enabled = false;
            }
        }

        private void CopyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^c");
        }

        private void CutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^x");
        }

        private void PasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBoxDSeq.Focus();
            SendKeys.Send("^v");
        }

        private void DeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBoxDSeq.Focus();
            SendKeys.Send("{DELETE}");
        }

        private void SavePresetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to save this preset?", "Attention", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                FileStream fs = new FileStream("../../ReadLog.dll", FileMode.Create);
                StreamWriter sw = new StreamWriter(fs,Encoding.UTF8);
                for (int i = 0; i < stnum; i++)
                {
                    sw.WriteLine(resName[i]);
                    sw.WriteLine(resSite[i]);
                }
                sw.Flush();
                sw.Close();
            }
        }

        private void ResetPresetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to reset this preset?", "Attention", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string stdFilePath = @"../../ResetPreset.dll";
                StreamReader srReadFile = new StreamReader(stdFilePath, Encoding.UTF8);
                stnum = 0;
                while (!srReadFile.EndOfStream)
                {
                    resName[stnum] = srReadFile.ReadLine();
                    resSite[stnum] = srReadFile.ReadLine();
                    stnum++;
                }
                srReadFile.Close();
                refresh();
            }
        }

        private void LoadPresetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "preset files(*.dll)|8.dll";
            if(ofd.ShowDialog()==DialogResult.OK)
            {
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                stnum = 0;
                while (!sr.EndOfStream)
                {
                    resName[stnum] = sr.ReadLine();
                    resSite[stnum] = sr.ReadLine();
                    stnum++;
                }
                sr.Close();
            }
        }

        private void TextBoxDSeq_Click(object sender, EventArgs e)
        {
            ifEditingDNA = true;
            textBoxRSeq.BackColor = Color.LightGray;
            textBoxDSeq.BackColor = Color.White;
            buttonT.Text = "T";
            listBoxDRS.Enabled = true;
            listBoxDRS.SelectedItem = null;
        }

        private void TextBoxRSeq_Click(object sender, EventArgs e)
        {
            ifEditingDNA = false;
            textBoxDSeq.BackColor = Color.LightGray;
            textBoxRSeq.BackColor = Color.White;
            buttonT.Text = "U";
            listBoxDRS.Enabled = false;
            listBoxDRS.SelectedItem = null;
        }

        private void TextBoxRSeq_TextChanged(object sender, EventArgs e)
        {
            if (ifEdited == false)
            {
                this.Text = seqName + "*" + " - BIC DNA";
            }
            ifEdited = true;
            if (!ifEditingDNA)
            {
                textBoxDSeq.Text = AntiTransSription(textBoxRSeq.Text);
            }

            Translation();
        }

        private void ButtonRev_Click(object sender, EventArgs e)
        {
            if (ifEditingDNA)
            {
                string DNA = textBoxDSeq.Text;
                string rDNA = "";
                for (int i = 0; i < DNA.Length; i++) 
                {
                    rDNA += DNA[DNA.Length - i-1];
                }
                textBoxDSeq.Text = rDNA;
            }
            else
            {
                string RNA = textBoxRSeq.Text;
                string rRNA = "";
                for (int i = 0; i < RNA.Length; i++)
                {
                    rRNA += RNA[RNA.Length - i-1];
                }
                textBoxRSeq.Text = rRNA;
            }
        }

        private void SettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ButtonRevs_Click(object sender, EventArgs e)
        {
            if (ifEditingDNA)
            {
                string DNA = textBoxDSeq.Text;
                string rDNA = "";
                for (int i = 0; i < DNA.Length; i++) 
                {
                    switch (DNA[i])
                    {
                        case 'A':
                            rDNA += 'T';
                            break;
                        case 'T':
                            rDNA += 'A';
                            break;
                        case 'C':
                            rDNA += 'G';
                            break;
                        case 'G':
                            rDNA += 'C';
                            break;
                        default:
                            break;
                    }
                }
                textBoxDSeq.Text = rDNA;
            }
            else
            {
                string RNA = textBoxRSeq.Text;
                string rRNA = "";
                for (int i = 0; i < RNA.Length; i++)
                {
                    switch (RNA[i])
                    {
                        case 'A':
                            rRNA += 'U';
                            break;
                        case 'U':
                            rRNA += 'A';
                            break;
                        case 'C':
                            rRNA += 'G';
                            break;
                        case 'G':
                            rRNA += 'C';
                            break;
                        default:
                            break;
                    }
                }
                textBoxRSeq.Text = rRNA;
            }
        }

        private void ContextMenuStripText_Opening(object sender, CancelEventArgs e)
        {

        }

        private void FlipSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ifEditingDNA)
            {
                int i = textBoxDSeq.SelectionStart;
                int j = textBoxDSeq.SelectionLength;
                textBoxDSeq.SelectedText = flipped(textBoxDSeq.SelectedText);
                textBoxDSeq.SelectionStart = i;
                textBoxDSeq.SelectionLength = j;
            }
            else
            {
                int i = textBoxRSeq.SelectionStart;
                int j = textBoxRSeq.SelectionLength;
                textBoxRSeq.SelectedText = flipped(textBoxRSeq.SelectedText);
                textBoxRSeq.SelectionStart = i;
                textBoxRSeq.SelectionLength = j;
            }
        }

        private void FlipSelectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ifEditingDNA)
            {
                int i = textBoxDSeq.SelectionStart;
                int j = textBoxDSeq.SelectionLength;
                textBoxDSeq.SelectedText = flipped(textBoxDSeq.SelectedText);
                textBoxDSeq.SelectionStart = i;
                textBoxDSeq.SelectionLength = j;
            }
            else
            {
                int i = textBoxRSeq.SelectionStart;
                int j = textBoxRSeq.SelectionLength;
                textBoxRSeq.SelectedText = flipped(textBoxRSeq.SelectedText);
                textBoxRSeq.SelectionStart = i;
                textBoxRSeq.SelectionLength = j;
            }
        }

        private void ReverseSelectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (ifEditingDNA)
            {
                string DNA = textBoxDSeq.SelectedText;
                string rDNA = "";
                int r = textBoxDSeq.SelectionStart;
                int j = textBoxDSeq.SelectionLength;
                for (int i = 0; i < DNA.Length; i++)
                {
                    switch (DNA[i])
                    {
                        case 'A':
                            rDNA += 'T';
                            break;
                        case 'T':
                            rDNA += 'A';
                            break;
                        case 'C':
                            rDNA += 'G';
                            break;
                        case 'G':
                            rDNA += 'C';
                            break;
                        default:
                            break;
                    }
                }
                textBoxDSeq.SelectedText = rDNA;
                textBoxDSeq.SelectionStart = r;
                textBoxDSeq.SelectionLength = j;
            }
            else
            {
                string RNA = textBoxDSeq.SelectedText;
                string rRNA = "";
                int r = textBoxRSeq.SelectionStart;
                int j = textBoxRSeq.SelectionLength;
                for (int i = 0; i < RNA.Length; i++)
                {
                    switch (RNA[i])
                    {
                        case 'A':
                            rRNA += 'U';
                            break;
                        case 'U':
                            rRNA += 'A';
                            break;
                        case 'C':
                            rRNA += 'G';
                            break;
                        case 'G':
                            rRNA += 'C';
                            break;
                        default:
                            break;
                    }
                }
                textBoxRSeq.SelectedText = rRNA;
                textBoxRSeq.SelectionStart = r;
                textBoxRSeq.SelectionLength = j;
            }
        }

        private void ReverseSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ifEditingDNA)
            {
                string DNA = textBoxDSeq.SelectedText;
                string rDNA = "";
                int r = textBoxDSeq.SelectionStart;
                int j = textBoxDSeq.SelectionLength;
                for (int i = 0; i < DNA.Length; i++)
                {
                    switch (DNA[i])
                    {
                        case 'A':
                            rDNA += 'T';
                            break;
                        case 'T':
                            rDNA += 'A';
                            break;
                        case 'C':
                            rDNA += 'G';
                            break;
                        case 'G':
                            rDNA += 'C';
                            break;
                        default:
                            break;
                    }
                }
                textBoxDSeq.SelectedText = rDNA;
                textBoxDSeq.SelectionStart = r;
                textBoxDSeq.SelectionLength = j;
            }
            else
            {
                string RNA = textBoxDSeq.SelectedText;
                string rRNA = "";
                int r = textBoxRSeq.SelectionStart;
                int j = textBoxRSeq.SelectionLength;
                for (int i = 0; i < RNA.Length; i++)
                {
                    switch (RNA[i])
                    {
                        case 'A':
                            rRNA += 'U';
                            break;
                        case 'U':
                            rRNA += 'A';
                            break;
                        case 'C':
                            rRNA += 'G';
                            break;
                        case 'G':
                            rRNA += 'C';
                            break;
                        default:
                            break;
                    }
                }
                textBoxRSeq.SelectedText = rRNA;
                textBoxRSeq.SelectionStart = r;
                textBoxRSeq.SelectionLength = j;
            }
        }

        private void TranslateSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string RNA;
            if(ifEditingDNA)
            {
                int r = textBoxDSeq.SelectionStart;
                int j = textBoxDSeq.SelectionLength;
                RNA = TransSription(textBoxDSeq.SelectedText);
            }
            else
            {
                RNA = textBoxRSeq.Text;
            }
        }
    }
    public class Common
    {
        public bool threel;
        public bool sep;
    }
}