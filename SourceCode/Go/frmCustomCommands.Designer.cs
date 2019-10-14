﻿namespace Go
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCustomCommand = new System.Windows.Forms.TabPage();
            this.tpBuiltInCommands = new System.Windows.Forms.TabPage();
            this.tpProfile = new System.Windows.Forms.TabPage();
            this.tpConfiguration = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbModifyCommand.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpCustomCommand.SuspendLayout();
            this.tpBuiltInCommands.SuspendLayout();
            this.tpProfile.SuspendLayout();
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
            this.tpBuiltInCommands.Controls.Add(this.label4);
            this.tpBuiltInCommands.Location = new System.Drawing.Point(4, 29);
            this.tpBuiltInCommands.Name = "tpBuiltInCommands";
            this.tpBuiltInCommands.Padding = new System.Windows.Forms.Padding(3);
            this.tpBuiltInCommands.Size = new System.Drawing.Size(893, 525);
            this.tpBuiltInCommands.TabIndex = 1;
            this.tpBuiltInCommands.Text = "BuiltIn Commands";
            this.tpBuiltInCommands.UseVisualStyleBackColor = true;
            // 
            // tpProfile
            // 
            this.tpProfile.Controls.Add(this.label6);
            this.tpProfile.Location = new System.Drawing.Point(4, 29);
            this.tpProfile.Name = "tpProfile";
            this.tpProfile.Size = new System.Drawing.Size(893, 525);
            this.tpProfile.TabIndex = 2;
            this.tpProfile.Text = "Profile";
            this.tpProfile.UseVisualStyleBackColor = true;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 36);
            this.label6.TabIndex = 1;
            this.label6.Text = "Under Construction";
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
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 36);
            this.label4.TabIndex = 1;
            this.label4.Text = "Under Construction";
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
            this.tpBuiltInCommands.PerformLayout();
            this.tpProfile.ResumeLayout(false);
            this.tpProfile.PerformLayout();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}