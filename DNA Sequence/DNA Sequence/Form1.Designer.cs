namespace DNA_Sequence
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxDSeq = new System.Windows.Forms.TextBox();
            this.contextMenuStripText = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.flipSelectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseSelectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.translateSelectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlDS = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAddResSite = new System.Windows.Forms.Button();
            this.textBoxresSeq = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxresName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxDRS = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSbmt = new System.Windows.Forms.Button();
            this.buttonADD = new System.Windows.Forms.Button();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonT = new System.Windows.Forms.Button();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonClr = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePresetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPresetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetPresetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.flipSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reverseSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.translateSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRSeq = new System.Windows.Forms.TextBox();
            this.textBoxPSeq = new System.Windows.Forms.TextBox();
            this.buttonRev = new System.Windows.Forms.Button();
            this.buttonRevs = new System.Windows.Forms.Button();
            this.contextMenuStripText.SuspendLayout();
            this.tabControlDS.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDSeq
            // 
            this.textBoxDSeq.AllowDrop = true;
            this.textBoxDSeq.BackColor = System.Drawing.Color.White;
            this.textBoxDSeq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDSeq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxDSeq.ContextMenuStrip = this.contextMenuStripText;
            resources.ApplyResources(this.textBoxDSeq, "textBoxDSeq");
            this.textBoxDSeq.Name = "textBoxDSeq";
            this.textBoxDSeq.TabStop = false;
            this.textBoxDSeq.Click += new System.EventHandler(this.TextBoxDSeq_Click);
            this.textBoxDSeq.TextChanged += new System.EventHandler(this.textBoxDSeq_TextChanged);
            this.textBoxDSeq.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxDSeq_DragDrop);
            this.textBoxDSeq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDSeq_KeyPress);
            this.textBoxDSeq.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBoxDSeq_KeyUp);
            this.textBoxDSeq.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TextBoxDSeq_MouseUp);
            // 
            // contextMenuStripText
            // 
            this.contextMenuStripText.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1,
            this.cutToolStripMenuItem1,
            this.pasteToolStripMenuItem1,
            this.deleteToolStripMenuItem1,
            this.toolStripSeparator2,
            this.flipSelectToolStripMenuItem1,
            this.reverseSelectToolStripMenuItem1,
            this.translateSelectToolStripMenuItem1});
            this.contextMenuStripText.Name = "contextMenuStripText";
            resources.ApplyResources(this.contextMenuStripText, "contextMenuStripText");
            this.contextMenuStripText.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripText_Opening);
            // 
            // copyToolStripMenuItem1
            // 
            resources.ApplyResources(this.copyToolStripMenuItem1, "copyToolStripMenuItem1");
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.CopyToolStripMenuItem1_Click);
            // 
            // cutToolStripMenuItem1
            // 
            resources.ApplyResources(this.cutToolStripMenuItem1, "cutToolStripMenuItem1");
            this.cutToolStripMenuItem1.Name = "cutToolStripMenuItem1";
            this.cutToolStripMenuItem1.Click += new System.EventHandler(this.CutToolStripMenuItem1_Click);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            resources.ApplyResources(this.pasteToolStripMenuItem1, "pasteToolStripMenuItem1");
            this.pasteToolStripMenuItem1.Click += new System.EventHandler(this.PasteToolStripMenuItem1_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem1, "deleteToolStripMenuItem1");
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.DeleteToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // flipSelectToolStripMenuItem1
            // 
            resources.ApplyResources(this.flipSelectToolStripMenuItem1, "flipSelectToolStripMenuItem1");
            this.flipSelectToolStripMenuItem1.Name = "flipSelectToolStripMenuItem1";
            this.flipSelectToolStripMenuItem1.Click += new System.EventHandler(this.FlipSelectToolStripMenuItem1_Click);
            // 
            // reverseSelectToolStripMenuItem1
            // 
            resources.ApplyResources(this.reverseSelectToolStripMenuItem1, "reverseSelectToolStripMenuItem1");
            this.reverseSelectToolStripMenuItem1.Name = "reverseSelectToolStripMenuItem1";
            this.reverseSelectToolStripMenuItem1.Click += new System.EventHandler(this.ReverseSelectToolStripMenuItem1_Click);
            // 
            // translateSelectToolStripMenuItem1
            // 
            resources.ApplyResources(this.translateSelectToolStripMenuItem1, "translateSelectToolStripMenuItem1");
            this.translateSelectToolStripMenuItem1.Name = "translateSelectToolStripMenuItem1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tabControlDS
            // 
            this.tabControlDS.Controls.Add(this.tabPage1);
            this.tabControlDS.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControlDS, "tabControlDS");
            this.tabControlDS.Name = "tabControlDS";
            this.tabControlDS.SelectedIndex = 0;
            this.tabControlDS.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.buttonAddResSite);
            this.tabPage1.Controls.Add(this.textBoxresSeq);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBoxresName);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.listBoxDRS);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // buttonAddResSite
            // 
            this.buttonAddResSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAddResSite.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonAddResSite, "buttonAddResSite");
            this.buttonAddResSite.ForeColor = System.Drawing.Color.Black;
            this.buttonAddResSite.Name = "buttonAddResSite";
            this.buttonAddResSite.UseVisualStyleBackColor = false;
            this.buttonAddResSite.Click += new System.EventHandler(this.buttonAddResSite_Click);
            // 
            // textBoxresSeq
            // 
            this.textBoxresSeq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxresSeq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxresSeq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxresSeq.ContextMenuStrip = this.contextMenuStripText;
            this.textBoxresSeq.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.textBoxresSeq, "textBoxresSeq");
            this.textBoxresSeq.Name = "textBoxresSeq";
            this.textBoxresSeq.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxresSeq_KeyPress);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Name = "label5";
            // 
            // textBoxresName
            // 
            this.textBoxresName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxresName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxresName.ContextMenuStrip = this.contextMenuStripText;
            this.textBoxresName.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.textBoxresName, "textBoxresName");
            this.textBoxresName.Name = "textBoxresName";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Name = "label3";
            // 
            // listBoxDRS
            // 
            this.listBoxDRS.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxDRS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.listBoxDRS, "listBoxDRS");
            this.listBoxDRS.ForeColor = System.Drawing.Color.Black;
            this.listBoxDRS.FormattingEnabled = true;
            this.listBoxDRS.Name = "listBoxDRS";
            this.listBoxDRS.DoubleClick += new System.EventHandler(this.listBoxDRS_DoubleClick);
            this.listBoxDRS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ListBoxDRS_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // buttonSbmt
            // 
            this.buttonSbmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonSbmt.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonSbmt, "buttonSbmt");
            this.buttonSbmt.Name = "buttonSbmt";
            this.buttonSbmt.UseVisualStyleBackColor = false;
            // 
            // buttonADD
            // 
            this.buttonADD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonADD.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonADD, "buttonADD");
            this.buttonADD.Name = "buttonADD";
            this.buttonADD.UseVisualStyleBackColor = false;
            this.buttonADD.Click += new System.EventHandler(this.buttonADD_Click);
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonA, "buttonA");
            this.buttonA.FlatAppearance.BorderSize = 0;
            this.buttonA.Name = "buttonA";
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonT
            // 
            this.buttonT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonT, "buttonT");
            this.buttonT.FlatAppearance.BorderSize = 0;
            this.buttonT.Name = "buttonT";
            this.buttonT.UseVisualStyleBackColor = false;
            this.buttonT.Click += new System.EventHandler(this.buttonT_Click);
            // 
            // buttonG
            // 
            this.buttonG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonG, "buttonG");
            this.buttonG.FlatAppearance.BorderSize = 0;
            this.buttonG.Name = "buttonG";
            this.buttonG.UseVisualStyleBackColor = false;
            this.buttonG.Click += new System.EventHandler(this.buttonG_Click);
            // 
            // buttonC
            // 
            this.buttonC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            resources.ApplyResources(this.buttonC, "buttonC");
            this.buttonC.FlatAppearance.BorderSize = 0;
            this.buttonC.Name = "buttonC";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonClr
            // 
            this.buttonClr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonClr.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonClr, "buttonClr");
            this.buttonClr.Name = "buttonClr";
            this.buttonClr.UseVisualStyleBackColor = false;
            this.buttonClr.Click += new System.EventHandler(this.buttonClr_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRemove.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonRemove, "buttonRemove");
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.editToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.importToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            resources.ApplyResources(this.filesToolStripMenuItem, "filesToolStripMenuItem");
            this.filesToolStripMenuItem.Click += new System.EventHandler(this.filesToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            resources.ApplyResources(this.newToolStripMenuItem, "newToolStripMenuItem");
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            resources.ApplyResources(this.saveAsToolStripMenuItem, "saveAsToolStripMenuItem");
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savePresetsToolStripMenuItem,
            this.loadPresetsToolStripMenuItem,
            this.resetPresetsToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            resources.ApplyResources(this.importToolStripMenuItem, "importToolStripMenuItem");
            // 
            // savePresetsToolStripMenuItem
            // 
            this.savePresetsToolStripMenuItem.Name = "savePresetsToolStripMenuItem";
            resources.ApplyResources(this.savePresetsToolStripMenuItem, "savePresetsToolStripMenuItem");
            this.savePresetsToolStripMenuItem.Click += new System.EventHandler(this.SavePresetsToolStripMenuItem_Click);
            // 
            // loadPresetsToolStripMenuItem
            // 
            this.loadPresetsToolStripMenuItem.Name = "loadPresetsToolStripMenuItem";
            resources.ApplyResources(this.loadPresetsToolStripMenuItem, "loadPresetsToolStripMenuItem");
            this.loadPresetsToolStripMenuItem.Click += new System.EventHandler(this.LoadPresetsToolStripMenuItem_Click);
            // 
            // resetPresetsToolStripMenuItem
            // 
            this.resetPresetsToolStripMenuItem.Name = "resetPresetsToolStripMenuItem";
            resources.ApplyResources(this.resetPresetsToolStripMenuItem, "resetPresetsToolStripMenuItem");
            this.resetPresetsToolStripMenuItem.Click += new System.EventHandler(this.ResetPresetsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            resources.ApplyResources(this.quitToolStripMenuItem, "quitToolStripMenuItem");
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.toolStripSeparator1,
            this.flipSelectToolStripMenuItem,
            this.reverseSelectToolStripMenuItem,
            this.translateSelectToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            resources.ApplyResources(this.editToolStripMenuItem, "editToolStripMenuItem");
            // 
            // copyToolStripMenuItem
            // 
            resources.ApplyResources(this.copyToolStripMenuItem, "copyToolStripMenuItem");
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cutToolStripMenuItem
            // 
            resources.ApplyResources(this.cutToolStripMenuItem, "cutToolStripMenuItem");
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            resources.ApplyResources(this.pasteToolStripMenuItem, "pasteToolStripMenuItem");
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            resources.ApplyResources(this.deleteToolStripMenuItem, "deleteToolStripMenuItem");
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // flipSelectToolStripMenuItem
            // 
            resources.ApplyResources(this.flipSelectToolStripMenuItem, "flipSelectToolStripMenuItem");
            this.flipSelectToolStripMenuItem.Name = "flipSelectToolStripMenuItem";
            this.flipSelectToolStripMenuItem.Click += new System.EventHandler(this.FlipSelectToolStripMenuItem_Click);
            // 
            // reverseSelectToolStripMenuItem
            // 
            resources.ApplyResources(this.reverseSelectToolStripMenuItem, "reverseSelectToolStripMenuItem");
            this.reverseSelectToolStripMenuItem.Name = "reverseSelectToolStripMenuItem";
            this.reverseSelectToolStripMenuItem.Click += new System.EventHandler(this.ReverseSelectToolStripMenuItem_Click);
            // 
            // translateSelectToolStripMenuItem
            // 
            resources.ApplyResources(this.translateSelectToolStripMenuItem, "translateSelectToolStripMenuItem");
            this.translateSelectToolStripMenuItem.Name = "translateSelectToolStripMenuItem";
            this.translateSelectToolStripMenuItem.Click += new System.EventHandler(this.TranslateSelectToolStripMenuItem_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBoxRSeq
            // 
            this.textBoxRSeq.AllowDrop = true;
            this.textBoxRSeq.BackColor = System.Drawing.Color.White;
            this.textBoxRSeq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxRSeq.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxRSeq.ContextMenuStrip = this.contextMenuStripText;
            resources.ApplyResources(this.textBoxRSeq, "textBoxRSeq");
            this.textBoxRSeq.Name = "textBoxRSeq";
            this.textBoxRSeq.TabStop = false;
            this.textBoxRSeq.Click += new System.EventHandler(this.TextBoxRSeq_Click);
            this.textBoxRSeq.TextChanged += new System.EventHandler(this.TextBoxRSeq_TextChanged);
            // 
            // textBoxPSeq
            // 
            this.textBoxPSeq.AcceptsReturn = true;
            this.textBoxPSeq.AllowDrop = true;
            this.textBoxPSeq.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxPSeq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPSeq.ContextMenuStrip = this.contextMenuStripText;
            resources.ApplyResources(this.textBoxPSeq, "textBoxPSeq");
            this.textBoxPSeq.Name = "textBoxPSeq";
            this.textBoxPSeq.ReadOnly = true;
            this.textBoxPSeq.TabStop = false;
            // 
            // buttonRev
            // 
            this.buttonRev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRev.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonRev, "buttonRev");
            this.buttonRev.Name = "buttonRev";
            this.buttonRev.UseVisualStyleBackColor = false;
            this.buttonRev.Click += new System.EventHandler(this.ButtonRev_Click);
            // 
            // buttonRevs
            // 
            this.buttonRevs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonRevs.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.buttonRevs, "buttonRevs");
            this.buttonRevs.Name = "buttonRevs";
            this.buttonRevs.UseVisualStyleBackColor = false;
            this.buttonRevs.Click += new System.EventHandler(this.ButtonRevs_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.buttonRevs);
            this.Controls.Add(this.buttonRev);
            this.Controls.Add(this.textBoxPSeq);
            this.Controls.Add(this.textBoxRSeq);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonClr);
            this.Controls.Add(this.buttonADD);
            this.Controls.Add(this.buttonG);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonT);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.buttonSbmt);
            this.Controls.Add(this.tabControlDS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDSeq);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.contextMenuStripText.ResumeLayout(false);
            this.tabControlDS.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDSeq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlDS;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBoxDRS;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonADD;
        private System.Windows.Forms.Button buttonSbmt;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonT;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonClr;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAddResSite;
        private System.Windows.Forms.TextBox textBoxresSeq;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxresName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePresetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPresetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetPresetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripText;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRSeq;
        private System.Windows.Forms.TextBox textBoxPSeq;
        private System.Windows.Forms.Button buttonRev;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Button buttonRevs;
        private System.Windows.Forms.ToolStripMenuItem flipSelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reverseSelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem translateSelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem flipSelectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reverseSelectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem translateSelectToolStripMenuItem1;
    }
}

