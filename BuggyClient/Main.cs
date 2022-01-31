using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Collections.Specialized;
using System.Diagnostics;

namespace BuggyClient
{
    
    public partial class bugform : Form
    {
        string webhook = "Your Webhook here";
        string githuburl = "https://github.com/Awire9966/Buggy"; // Your github url here.
        public bugform()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NameValueCollection discordValues = new NameValueCollection();
            WebClient dWebClient = new WebClient();
            discordValues.Add("username", textBox1.Text);

            discordValues.Add("content", "A new user has submitted an issue.\n Name: " + textBox1.Text + "\n Email: " + textBox2.Text + "\n Subject: " + textBox3.Text + "\n Information: \n" + richTextBox1.Text); 

            dWebClient.UploadValues(webhook, discordValues);

            DialogResult result = MessageBox.Show("The issue has been submitted. Would you like to view the github page of the project while you wait?", "Done", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Process.Start(githuburl);
            }
        }
    }
}
