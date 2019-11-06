namespace Go
{
    partial class frmCustomCommands
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomCommands));
            this.gbModifyCommand = new System.Windows.Forms.GroupBox();
            this.cbProfile = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParameter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btUpdateCommand = new System.Windows.Forms.Button();
            this.btAddCommand = new System.Windows.Forms.Button();
            this.txtActionScript = new System.Windows.Forms.TextBox();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ttCustom = new System.Windows.Forms.ToolTip(this.components);
            this.btCancel = new System.Windows.Forms.Button();
            this.lbCustCommands = new System.Windows.Forms.ListBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btCopy = new System.Windows.Forms.Button();
            this.btProfileDelete = new System.Windows.Forms.Button();
            this.btProfileNew = new System.Windows.Forms.Button();
            this.lbProfiles = new System.Windows.Forms.ListBox();
            this.tbProfileCommandPath = new System.Windows.Forms.TextBox();
            this.btProfileUpdate = new System.Windows.Forms.Button();
            this.btProfileAdd = new System.Windows.Forms.Button();
            this.tbProfileName = new System.Windows.Forms.TextBox();
            this.lbBuiltInCommands = new System.Windows.Forms.ListBox();
            this.btBuiltInCommandUpdate = new System.Windows.Forms.Button();
            this.tbBICommand = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCustomCommand = new System.Windows.Forms.TabPage();
            this.tpBuiltInCommands = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gbBIC = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tpProfile = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbProfileModify = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBICParameter = new System.Windows.Forms.TextBox();
            this.gbModifyCommand.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpCustomCommand.SuspendLayout();
            this.tpBuiltInCommands.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbBIC.SuspendLayout();
            this.tpProfile.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbProfileModify.SuspendLayout();
            this.tpConfiguration.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbModifyCommand
            // 
            this.gbModifyCommand.Controls.Add(this.cbProfile);
            this.gbModifyCommand.Controls.Add(this.label1);
            this.gbModifyCommand.Controls.Add(this.txtParameter);
            this.gbModifyCommand.Controls.Add(this.label5);
            this.gbModifyCommand.Controls.Add(this.btUpdateCommand);
            this.gbModifyCommand.Controls.Add(this.btAddCommand);
            this.gbModifyCommand.Controls.Add(this.txtActionScript);
            this.gbModifyCommand.Controls.Add(this.txtCommand);
            this.gbModifyCommand.Controls.Add(this.label3);
            this.gbModifyCommand.Controls.Add(this.label2);
            this.gbModifyCommand.Location = new System.Drawing.Point(18, 259);
            this.gbModifyCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbModifyCommand.Name = "gbModifyCommand";
            this.gbModifyCommand.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbModifyCommand.Size = new System.Drawing.Size(757, 247);
            this.gbModifyCommand.TabIndex = 1;
            this.gbModifyCommand.TabStop = false;
            this.gbModifyCommand.Text = "Add/Edit Commands";
            this.gbModifyCommand.Enter += new System.EventHandler(this.gbModifyCommand_Enter);
            // 
            // cbProfile
            // 
            this.cbProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfile.FormattingEnabled = true;
            this.cbProfile.Location = new System.Drawing.Point(366, 38);
            this.cbProfile.Name = "cbProfile";
            this.cbProfile.Size = new System.Drawing.Size(276, 28);
            this.cbProfile.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Profile";
            // 
            // txtParameter
            // 
            this.txtParameter.Location = new System.Drawing.Point(114, 127);
            this.txtParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtParameter.Multiline = true;
            this.txtParameter.Name = "txtParameter";
            this.txtParameter.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParameter.Size = new System.Drawing.Size(622, 54);
            this.txtParameter.TabIndex = 7;
            this.ttCustom.SetToolTip(this.txtParameter, "Use this field to pass any parameter to the url or file name \r\nor application you" +
        " have entered in action script");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Parameter";
            // 
            // btUpdateCommand
            // 
            this.btUpdateCommand.Enabled = false;
            this.btUpdateCommand.Location = new System.Drawing.Point(598, 202);
            this.btUpdateCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btUpdateCommand.Name = "btUpdateCommand";
            this.btUpdateCommand.Size = new System.Drawing.Size(112, 35);
            this.btUpdateCommand.TabIndex = 9;
            this.btUpdateCommand.Text = "Update";
            this.ttCustom.SetToolTip(this.btUpdateCommand, "Update the modified command/action script/parameter");
            this.btUpdateCommand.UseVisualStyleBackColor = true;
            this.btUpdateCommand.Click += new System.EventHandler(this.btUpdateCommand_Click);
            // 
            // btAddCommand
            // 
            this.btAddCommand.Enabled = false;
            this.btAddCommand.Location = new System.Drawing.Point(478, 202);
            this.btAddCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAddCommand.Name = "btAddCommand";
            this.btAddCommand.Size = new System.Drawing.Size(112, 35);
            this.btAddCommand.TabIndex = 8;
            this.btAddCommand.Text = "Add";
            this.ttCustom.SetToolTip(this.btAddCommand, "Create the entered custom command");
            this.btAddCommand.UseVisualStyleBackColor = true;
            this.btAddCommand.Click += new System.EventHandler(this.btAddCommand_Click);
            // 
            // txtActionScript
            // 
            this.txtActionScript.Location = new System.Drawing.Point(114, 83);
            this.txtActionScript.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtActionScript.Multiline = true;
            this.txtActionScript.Name = "txtActionScript";
            this.txtActionScript.Size = new System.Drawing.Size(622, 25);
            this.txtActionScript.TabIndex = 6;
            this.ttCustom.SetToolTip(this.txtActionScript, "Enter your URL or file name or command you wish to execute\r\nby the above command");
            // 
            // txtCommand
            // 
            this.txtCommand.Location = new System.Drawing.Point(114, 38);
            this.txtCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(131, 26);
            this.txtCommand.TabIndex = 5;
            this.ttCustom.SetToolTip(this.txtCommand, "Enter/Modify command ");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Action Script";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Command";
            // 
            // btCancel
            // 
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(771, 606);
            this.btCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(112, 35);
            this.btCancel.TabIndex = 10;
            this.btCancel.Text = "Cancel";
            this.ttCustom.SetToolTip(this.btCancel, "Create the entered custom command");
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // lbCustCommands
            // 
            this.lbCustCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustCommands.FormattingEnabled = true;
            this.lbCustCommands.ItemHeight = 20;
            this.lbCustCommands.Location = new System.Drawing.Point(27, 29);
            this.lbCustCommands.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbCustCommands.Name = "lbCustCommands";
            this.lbCustCommands.Size = new System.Drawing.Size(416, 164);
            this.lbCustCommands.Sorted = true;
            this.lbCustCommands.TabIndex = 0;
            this.ttCustom.SetToolTip(this.lbCustCommands, "Lists the present custom commands. Double click an item to copy its action script" +
        " and parameter to clipboard");
            this.lbCustCommands.SelectedIndexChanged += new System.EventHandler(this.lbCustCommands_SelectedIndexChanged);
            this.lbCustCommands.DoubleClick += new System.EventHandler(this.lbCustCommands_DoubleClick);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(614, 29);
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(112, 35);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "New";
            this.ttCustom.SetToolTip(this.btAdd, "Create new custom command");
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(614, 118);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(112, 35);
            this.btDelete.TabIndex = 4;
            this.btDelete.Text = "Delete";
            this.ttCustom.SetToolTip(this.btDelete, "Delete the selected custom command");
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btCopy
            // 
            this.btCopy.Enabled = false;
            this.btCopy.Location = new System.Drawing.Point(614, 74);
            this.btCopy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btCopy.Name = "btCopy";
            this.btCopy.Size = new System.Drawing.Size(112, 35);
            this.btCopy.TabIndex = 5;
            this.btCopy.Text = "Copy";
            this.ttCustom.SetToolTip(this.btCopy, "Delete the selected custom command");
            this.btCopy.UseVisualStyleBackColor = true;
            this.btCopy.Click += new System.EventHandler(this.button1_Click);
            // 
            // btProfileDelete
            // 
            this.btProfileDelete.Location = new System.Drawing.Point(614, 74);
            this.btProfileDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btProfileDelete.Name = "btProfileDelete";
            this.btProfileDelete.Size = new System.Drawing.Size(112, 35);
            this.btProfileDelete.TabIndex = 4;
            this.btProfileDelete.Text = "Delete";
            this.ttCustom.SetToolTip(this.btProfileDelete, "Delete the selected custom command");
            this.btProfileDelete.UseVisualStyleBackColor = true;
            this.btProfileDelete.Click += new System.EventHandler(this.btProfileDelete_Click);
            // 
            // btProfileNew
            // 
            this.btProfileNew.Location = new System.Drawing.Point(614, 29);
            this.btProfileNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btProfileNew.Name = "btProfileNew";
            this.btProfileNew.Size = new System.Drawing.Size(112, 35);
            this.btProfileNew.TabIndex = 2;
            this.btProfileNew.Text = "New";
            this.ttCustom.SetToolTip(this.btProfileNew, "Create new custom command");
            this.btProfileNew.UseVisualStyleBackColor = true;
            this.btProfileNew.Click += new System.EventHandler(this.btProfileNew_Click);
            // 
            // lbProfiles
            // 
            this.lbProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfiles.FormattingEnabled = true;
            this.lbProfiles.ItemHeight = 20;
            this.lbProfiles.Location = new System.Drawing.Point(27, 29);
            this.lbProfiles.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbProfiles.Name = "lbProfiles";
            this.lbProfiles.Size = new System.Drawing.Size(416, 164);
            this.lbProfiles.Sorted = true;
            this.lbProfiles.TabIndex = 0;
            this.ttCustom.SetToolTip(this.lbProfiles, "Lists the present custom commands. Double click an item to copy its action script" +
        " and parameter to clipboard");
            this.lbProfiles.SelectedIndexChanged += new System.EventHandler(this.lbProfiles_SelectedIndexChanged);
            // 
            // tbProfileCommandPath
            // 
            this.tbProfileCommandPath.Location = new System.Drawing.Point(215, 83);
            this.tbProfileCommandPath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbProfileCommandPath.Multiline = true;
            this.tbProfileCommandPath.Name = "tbProfileCommandPath";
            this.tbProfileCommandPath.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbProfileCommandPath.Size = new System.Drawing.Size(524, 58);
            this.tbProfileCommandPath.TabIndex = 7;
            this.ttCustom.SetToolTip(this.tbProfileCommandPath, "Use this field to pass any parameter to the url or file name \r\nor application you" +
        " have entered in action script");
            // 
            // btProfileUpdate
            // 
            this.btProfileUpdate.Enabled = false;
            this.btProfileUpdate.Location = new System.Drawing.Point(370, 170);
            this.btProfileUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btProfileUpdate.Name = "btProfileUpdate";
            this.btProfileUpdate.Size = new System.Drawing.Size(112, 35);
            this.btProfileUpdate.TabIndex = 9;
            this.btProfileUpdate.Text = "Update";
            this.ttCustom.SetToolTip(this.btProfileUpdate, "Update the modified command/action script/parameter");
            this.btProfileUpdate.UseVisualStyleBackColor = true;
            this.btProfileUpdate.Click += new System.EventHandler(this.btProfileUpdate_Click);
            // 
            // btProfileAdd
            // 
            this.btProfileAdd.Enabled = false;
            this.btProfileAdd.Location = new System.Drawing.Point(212, 170);
            this.btProfileAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btProfileAdd.Name = "btProfileAdd";
            this.btProfileAdd.Size = new System.Drawing.Size(112, 35);
            this.btProfileAdd.TabIndex = 8;
            this.btProfileAdd.Text = "Add";
            this.ttCustom.SetToolTip(this.btProfileAdd, "Create the entered custom command");
            this.btProfileAdd.UseVisualStyleBackColor = true;
            this.btProfileAdd.Click += new System.EventHandler(this.btProfileAdd_Click);
            // 
            // tbProfileName
            // 
            this.tbProfileName.Location = new System.Drawing.Point(215, 44);
            this.tbProfileName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbProfileName.Name = "tbProfileName";
            this.tbProfileName.Size = new System.Drawing.Size(426, 26);
            this.tbProfileName.TabIndex = 5;
            this.ttCustom.SetToolTip(this.tbProfileName, "Enter/Modify command ");
            // 
            // lbBuiltInCommands
            // 
            this.lbBuiltInCommands.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuiltInCommands.FormattingEnabled = true;
            this.lbBuiltInCommands.ItemHeight = 20;
            this.lbBuiltInCommands.Location = new System.Drawing.Point(27, 29);
            this.lbBuiltInCommands.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbBuiltInCommands.Name = "lbBuiltInCommands";
            this.lbBuiltInCommands.Size = new System.Drawing.Size(416, 164);
            this.lbBuiltInCommands.Sorted = true;
            this.lbBuiltInCommands.TabIndex = 0;
            this.ttCustom.SetToolTip(this.lbBuiltInCommands, "Lists the present custom commands. Double click an item to copy its action script" +
        " and parameter to clipboard");
            this.lbBuiltInCommands.SelectedIndexChanged += new System.EventHandler(this.lbBuiltInCommands_SelectedIndexChanged);
            // 
            // btBuiltInCommandUpdate
            // 
            this.btBuiltInCommandUpdate.Enabled = false;
            this.btBuiltInCommandUpdate.Location = new System.Drawing.Point(133, 153);
            this.btBuiltInCommandUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBuiltInCommandUpdate.Name = "btBuiltInCommandUpdate";
            this.btBuiltInCommandUpdate.Size = new System.Drawing.Size(112, 35);
            this.btBuiltInCommandUpdate.TabIndex = 9;
            this.btBuiltInCommandUpdate.Text = "Update";
            this.ttCustom.SetToolTip(this.btBuiltInCommandUpdate, "Update the modified command/action script/parameter");
            this.btBuiltInCommandUpdate.UseVisualStyleBackColor = true;
            this.btBuiltInCommandUpdate.Click += new System.EventHandler(this.btBuiltInCommandUpdate_Click);
            // 
            // tbBICommand
            // 
            this.tbBICommand.Location = new System.Drawing.Point(133, 38);
            this.tbBICommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBICommand.Name = "tbBICommand";
            this.tbBICommand.Size = new System.Drawing.Size(534, 26);
            this.tbBICommand.TabIndex = 5;
            this.ttCustom.SetToolTip(this.tbBICommand, "Enter/Modify command ");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCopy);
            this.groupBox1.Controls.Add(this.btDelete);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.lbCustCommands);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(747, 204);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Custom Commands";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCustomCommand);
            this.tabControl1.Controls.Add(this.tpBuiltInCommands);
            this.tabControl1.Controls.Add(this.tpProfile);
            this.tabControl1.Controls.Add(this.tpConfiguration);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(901, 558);
            this.tabControl1.TabIndex = 11;
            // 
            // tpCustomCommand
            // 
            this.tpCustomCommand.Controls.Add(this.groupBox1);
            this.tpCustomCommand.Controls.Add(this.gbModifyCommand);
            this.tpCustomCommand.Location = new System.Drawing.Point(4, 29);
            this.tpCustomCommand.Name = "tpCustomCommand";
            this.tpCustomCommand.Padding = new System.Windows.Forms.Padding(3);
            this.tpCustomCommand.Size = new System.Drawing.Size(893, 525);
            this.tpCustomCommand.TabIndex = 0;
            this.tpCustomCommand.Text = "CustomCommands";
            this.tpCustomCommand.UseVisualStyleBackColor = true;
            // 
            // tpBuiltInCommands
            // 
            this.tpBuiltInCommands.Controls.Add(this.groupBox3);
            this.tpBuiltInCommands.Controls.Add(this.gbBIC);
            this.tpBuiltInCommands.Location = new System.Drawing.Point(4, 29);
            this.tpBuiltInCommands.Name = "tpBuiltInCommands";
            this.tpBuiltInCommands.Padding = new System.Windows.Forms.Padding(3);
            this.tpBuiltInCommands.Size = new System.Drawing.Size(893, 525);
            this.tpBuiltInCommands.TabIndex = 1;
            this.tpBuiltInCommands.Text = "BuiltIn Commands";
            this.tpBuiltInCommands.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbBuiltInCommands);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(78, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(747, 204);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Builtin Commands";
            // 
            // gbBIC
            // 
            this.gbBIC.Controls.Add(this.tbBICParameter);
            this.gbBIC.Controls.Add(this.btBuiltInCommandUpdate);
            this.gbBIC.Controls.Add(this.tbBICommand);
            this.gbBIC.Controls.Add(this.label4);
            this.gbBIC.Controls.Add(this.label8);
            this.gbBIC.Location = new System.Drawing.Point(68, 254);
            this.gbBIC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBIC.Name = "gbBIC";
            this.gbBIC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBIC.Size = new System.Drawing.Size(757, 247);
            this.gbBIC.TabIndex = 5;
            this.gbBIC.TabStop = false;
            this.gbBIC.Text = "Add/Edit Commands";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 44);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Command";
            // 
            // tpProfile
            // 
            this.tpProfile.Controls.Add(this.groupBox2);
            this.tpProfile.Controls.Add(this.gbProfileModify);
            this.tpProfile.Location = new System.Drawing.Point(4, 29);
            this.tpProfile.Name = "tpProfile";
            this.tpProfile.Size = new System.Drawing.Size(893, 525);
            this.tpProfile.TabIndex = 2;
            this.tpProfile.Text = "Profile";
            this.tpProfile.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btProfileDelete);
            this.groupBox2.Controls.Add(this.btProfileNew);
            this.groupBox2.Controls.Add(this.lbProfiles);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(78, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(747, 204);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Profiles";
            // 
            // gbProfileModify
            // 
            this.gbProfileModify.Controls.Add(this.tbProfileCommandPath);
            this.gbProfileModify.Controls.Add(this.btProfileUpdate);
            this.gbProfileModify.Controls.Add(this.btProfileAdd);
            this.gbProfileModify.Controls.Add(this.tbProfileName);
            this.gbProfileModify.Controls.Add(this.label10);
            this.gbProfileModify.Controls.Add(this.label11);
            this.gbProfileModify.Location = new System.Drawing.Point(68, 254);
            this.gbProfileModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProfileModify.Name = "gbProfileModify";
            this.gbProfileModify.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbProfileModify.Size = new System.Drawing.Size(757, 247);
            this.gbProfileModify.TabIndex = 3;
            this.gbProfileModify.TabStop = false;
            this.gbProfileModify.Text = "Add/Edit Commands";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 83);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(196, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Profile Command File Path";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 44);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Profile Name";
            // 
            // tpConfiguration
            // 
            this.tpConfiguration.Controls.Add(this.label7);
            this.tpConfiguration.Location = new System.Drawing.Point(4, 29);
            this.tpConfiguration.Name = "tpConfiguration";
            this.tpConfiguration.Size = new System.Drawing.Size(893, 525);
            this.tpConfiguration.TabIndex = 3;
            this.tpConfiguration.Text = "Configuration";
            this.tpConfiguration.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(309, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(274, 36);
            this.label7.TabIndex = 1;
            this.label7.Text = "Under Construction";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Configuration";
            // 
            // tbBICParameter
            // 
            this.tbBICParameter.Location = new System.Drawing.Point(133, 90);
            this.tbBICParameter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBICParameter.Name = "tbBICParameter";
            this.tbBICParameter.Size = new System.Drawing.Size(534, 26);
            this.tbBICParameter.TabIndex = 10;
            // 
            // frmCustomCommands
            // 
            this.AcceptButton = this.btAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(925, 765);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmCustomCommands";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Custom Commands";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCustomCommands_FormClosing);
            this.Load += new System.EventHandler(this.frmCustomCommands_Load);
            this.gbModifyCommand.ResumeLayout(false);
            this.gbModifyCommand.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpCustomCommand.ResumeLayout(false);
            this.tpBuiltInCommands.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gbBIC.ResumeLayout(false);
            this.gbBIC.PerformLayout();
            this.tpProfile.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.gbProfileModify.ResumeLayout(false);
            this.gbProfileModify.PerformLayout();
            this.tpConfiguration.ResumeLayout(false);
            this.tpConfiguration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbModifyCommand;
        private System.Windows.Forms.Button btUpdateCommand;
        private System.Windows.Forms.Button btAddCommand;
        private System.Windows.Forms.TextBox txtActionScript;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParameter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip ttCustom;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.ListBox lbCustCommands;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btCopy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCustomCommand;
        private System.Windows.Forms.TabPage tpBuiltInCommands;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProfile;
        private System.Windows.Forms.TabPage tpProfile;
        private System.Windows.Forms.TabPage tpConfiguration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btProfileDelete;
        private System.Windows.Forms.Button btProfileNew;
        private System.Windows.Forms.ListBox lbProfiles;
        private System.Windows.Forms.GroupBox gbProfileModify;
        private System.Windows.Forms.TextBox tbProfileCommandPath;
        private System.Windows.Forms.Button btProfileUpdate;
        private System.Windows.Forms.Button btProfileAdd;
        private System.Windows.Forms.TextBox tbProfileName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbBuiltInCommands;
        private System.Windows.Forms.GroupBox gbBIC;
        private System.Windows.Forms.Button btBuiltInCommandUpdate;
        private System.Windows.Forms.TextBox tbBICommand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbBICParameter;
        private System.Windows.Forms.Label label4;
    }
}