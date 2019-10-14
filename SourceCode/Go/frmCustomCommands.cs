using Go.Common;
using Go.Common.Entities;
using Go.DataAccess;
using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace Go
{

    public partial class frmCustomCommands : Form
    {
        string profileFilePath = ConfigurationManager.AppSettings.Get(Constants.ProfileFilePath);
        string customCommandFilePath = ConfigurationManager.AppSettings.Get(Constants.CustomCommandFilePath);
        string builtInCommandFilePath = ConfigurationManager.AppSettings.Get(Constants.BuiltInCommandFilePath);

        CommandManager cmdMgr;
        string editCommand;
        CustomCommand editCustomCommand;

        public frmCustomCommands()
        {
            InitializeComponent();
            cmdMgr = new CommandManager(profileFilePath, customCommandFilePath, builtInCommandFilePath,
                Application.StartupPath);
            editCommand = string.Empty;
        }

        private void frmCustomCommands_Load(object sender, EventArgs e)
        {
            LoadCommandList();

        }

        public void LoadCommandList()
        {
            lbCustCommands.Items.Clear();

            foreach (string item in cmdMgr.GetAllCustomCommandNames())
                lbCustCommands.Items.Add(item);

            cbProfile.Items.Clear();
            foreach (Profile item in cmdMgr.GetAllProfile())
            {
                cbProfile.Items.Add(item.Name);
            }
            if (lbCustCommands.Items.Count> 0)
            {
                lbCustCommands.SelectedItem = lbCustCommands.Items[0];

                var custCommand = cmdMgr.GetCustomCommand(lbCustCommands.SelectedItem.ToString());
                editCustomCommand = custCommand;
                txtActionScript.Text = custCommand.ActionScript;
                txtParameter.Text = custCommand.Parameter;
                cbProfile.SelectedIndex = cbProfile.Items.IndexOf(custCommand.Profile.Name);
                btDelete.Enabled = true;
                btCopy.Enabled = true;
                makeCmdEditable();
            }
            else
            {
                btDelete.Enabled = false;
            }
        }


        private void lbCustCommands_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enabling the modify section and fiil the textboxes
            makeCmdEditable();
        }

        private void makeCmdEditable(string copyAction=null)
        {
            //TODO if command not in profile command file
            string cmd = lbCustCommands.SelectedItem.ToString();
            if (copyAction == null)
            {
                //calling for normal edit command operation
                gbModifyCommand.Enabled = true;
                btUpdateCommand.Enabled = true;
                btAddCommand.Enabled = false;
                
                txtCommand.Text = cmd;
                var customCommand = cmdMgr.GetCustomCommand(cmd);
                editCustomCommand = customCommand;
                txtActionScript.Text = customCommand.ActionScript;
                txtParameter.Text = customCommand.Parameter;
                cbProfile.SelectedIndex = cbProfile.Items.IndexOf(customCommand.Profile.Name);
                this.editCommand = cmd;//stroing the current editing command
            }
            else
            {
                //enabling the modify section for copy command operation
                btAddCommand.Enabled = true;
                btUpdateCommand.Enabled = false;
                txtCommand.Text = cmd + "Copy";
                var customCommand = cmdMgr.GetCustomCommand(cmd);
                editCustomCommand = customCommand;
                txtActionScript.Text = customCommand.ActionScript;
                txtParameter.Text = customCommand.Parameter;
                cbProfile.SelectedIndex = cbProfile.Items.IndexOf(customCommand.Profile.Name);
                txtCommand.Focus();

            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (lbCustCommands.Items.Count > 0)
            {    //enabling the modify section and fiil the textboxes
                makeCmdEditable();
            }
            else
            {
                MessageBox.Show("No items to edit, please add and try again","Information",MessageBoxButtons.OK,MessageBoxIcon.Stop);
            }

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //enabling the modify section
            gbModifyCommand.Enabled = true;
            txtActionScript.Text = string.Empty;
            txtCommand.Text = string.Empty;
            txtParameter.Text = string.Empty;
            btAddCommand.Enabled = true;
            btUpdateCommand.Enabled = false;
            txtCommand.Focus();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (lbCustCommands.Items.Count > 0)
            {
                //deleting the value from custom command settings
                string cmd = lbCustCommands.SelectedItem.ToString();

                if (MessageBox.Show("Command " + cmd + " will be deleted, are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    var customCommand = cmdMgr.GetCustomCommand(cmd);
                    cmdMgr.DeleteCustomCommand(customCommand);
                }
                else
                    return;

                ApplyChanges();
            }
            else
            {
                MessageBox.Show("No items to delete, please add and try again", "Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btAddCommand_Click(object sender, EventArgs e)
        {
            //checking both text fields
            if (txtActionScript.Text.Trim() == "" || txtCommand.Text.Trim() == "")
            {
                MessageBox.Show("Either command or action script is missing. Please try again","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            else if (txtCommand.Text.Contains(" "))
            {
                MessageBox.Show("Command shouldnt contain any spaces, you can pass the parameters by putting it in next textbox", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            { //checking if already command exists
                string cmd = txtCommand.Text;

                if(cmdMgr.isThisCustomCommandExists(cmd))
                {
                    MessageBox.Show("Command " + cmd + " is already exists, please update it", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (cmdMgr.isThisBuiltInCommandExists(cmd))
                 {
                    MessageBox.Show("Command " + cmd + " is built in, please use another command it", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //if not exists, then add 
                string newCommand = txtCommand.Text.Trim();
                string newAction = txtActionScript.Text.Trim();
                string newParameter = txtParameter.Text.Trim();
                string newProfile = cbProfile.SelectedItem.ToString();
                var customCommand = new CustomCommand()
                {
                    Name = newCommand,
                    ActionScript = newAction,
                    Parameter = newParameter,
                    Profile = new Profile()
                    {
                        Name = newProfile
                    }
                };
                cmdMgr.AddCustomCommand(customCommand);
                
                //apply the changes back to xml
                ApplyChanges();

            }
        }

        /// <summary>
        /// Method to save options to xml and reloading the list
        /// </summary>
        private void ApplyChanges()
        {
            MessageBox.Show("Changes successfully applied", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCommandList();
        }

        private void btUpdateCommand_Click(object sender, EventArgs e)
        {
            //checking both text fields
            if (txtActionScript.Text.Trim() == "" || txtCommand.Text.Trim() == "")
            {
                MessageBox.Show("Either command or action script is missing. Please try again","Information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (txtCommand.Text.Contains(" "))
            {
                MessageBox.Show("Command shouldnt contain any spaces, you can pass the parameters by putting it in next textbox", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string newCommand = txtCommand.Text;

                if (newCommand != this.editCommand && cmdMgr.isThisCustomCommandExists(newCommand) )
                {
                    MessageBox.Show("This command already exists, so please select and edit it", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (cmdMgr.isThisBuiltInCommandExists(newCommand))
                {
                    MessageBox.Show("This command is reserved, so please user another name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string newAction = txtActionScript.Text.Trim();
                string newParameter = txtParameter.Text.Trim();

                var newCustomCommand = new CustomCommand()
                {
                    Name = newCommand,
                    ActionScript = newAction,
                    Parameter = newParameter,
                    Profile = new Profile()
                    {
                        Name = cbProfile.SelectedItem.ToString()
                    }
                };
                cmdMgr.UpdateCustomCommand(this.editCustomCommand, newCustomCommand);

                ApplyChanges();
            }

        }


        private void frmCustomCommands_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void gbModifyCommand_Enter(object sender, EventArgs e)
        {

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void lbCustCommands_DoubleClick(object sender, EventArgs e)
        {
            if (lbCustCommands.SelectedIndex > 0)
            {
                string strToCopy;
                var cmd = cmdMgr.GetCustomCommand(lbCustCommands.SelectedItem.ToString());
                strToCopy = cmd.ActionScript + " " + cmd.Parameter;
                System.Windows.Forms.Clipboard.SetText(strToCopy);
            }
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            makeCmdEditable("Copy");
        }
    }
}
