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

namespace BuggyClient
{
    
    public partial class bugform : Form
    {
        string webhook = "https://discord.com/api/webhooks/918610433701720106/l3xW8XjLettPdWo2O3QP9XZegvq5CnFKwgy-xcsCS4RxL3UTTpHIHnIA3gwh6UDu6cup";
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

            discordValues.Add("content", "A new user has submitted an issue.\n Name:" + textBox1.Text + "\n Email:" + textBox2.Text + "\n Subject:" + textBox3.Text + "\n Information: \n" + richTextBox1); ;

            dWebClient.UploadValues(webhook, discordValues);
        }
    }
}
