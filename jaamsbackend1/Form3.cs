using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tamir.SharpSsh;
using Tamir.Streams;

namespace jaamsbackend1
{
    public partial class login : Form
    {
        private static string serverExt = "ecs.csus.edu";
        private static string serverName;
        private static string userName;
        private static string password;
        //private List<string> category = new List<string>(); // list to store header fields such as Name etc.
    

        public login()
        {
            InitializeComponent();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            serverName = server.Text + serverExt;
            userName = user.Text;
            password = pw.Text;
            SshShell SshShell = new SshShell(serverName

        }
        private void openDataBase()
        {

        }
        private bool Validate(string username, string password)
        {

            return true;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are You Sure You Want To Cancel?", "Cancel Box", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }
    }
}
