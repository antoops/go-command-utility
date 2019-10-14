using Go.Common;
using Go.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Go
{
    public partial class frmInput : Form
    {
        string profileFilePath = ConfigurationManager.AppSettings.Get(Constants.ProfileFilePath);
        string customCommandFilePath = ConfigurationManager.AppSettings.Get(Constants.CustomCommandFilePath);
        string builtInCommandFilePath = ConfigurationManager.AppSettings.Get(Constants.BuiltInCommandFilePath);

        public frmInput()
        {
            InitializeComponent();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            string Command = txtCommand.Text;
            if (Command.Trim() != "")
            {
                Process.Start("go", Command);
                Close();
            }
            else
            {
                MessageBox.Show("Please enter a valid command", "Go - Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void llSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Form f = new frmCustomCommands();
            f.ShowDialog();
          
        }

        private void frmInput_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
          //  this.Location = new Point(Screen.PrimaryScreen.WorkingArea.Width - this.Width,Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            this.Location = new Point(0, Screen.PrimaryScreen.WorkingArea.Height - this.Height);
            txtCommand.Focus();


            //loading the custom commands all into the autom complete source
            // so it will show up in the suggestions

            txtCommand.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtCommand.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection acs = new AutoCompleteStringCollection();
            acs.Clear();            
            txtCommand.AutoCompleteCustomSource = getCustCommands();
        }

        private AutoCompleteStringCollection getCustCommands()
        {
            AutoCompleteStringCollection commands = new AutoCompleteStringCollection();
            var cmdMgr = new CommandManager(profileFilePath, customCommandFilePath, builtInCommandFilePath
                , Application.StartupPath);

            foreach (var dr in cmdMgr.GetAllCustomCommandNames())
            {
                commands.Add(dr);
            }

            return commands;
        }
    }
}
