using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Blockchain;

namespace BlockchainMessaging
{
    public partial class Form1 : Form
    {
        Blockchain<string> messagingChain;
        public Form1()
        {
            InitializeComponent();
            messagingChain = new Blockchain<string>(4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = txtUsername.Text;
            lvi.SubItems.Add(txtMessage.Text);
            if (lvi.Text != "" && lvi.SubItems[0].Text != "")
            {
                listWriteBuffer.Items.Add(lvi);
                messagingChain.buffer.Add(lvi.Text + ": " + lvi.SubItems[0].Text);
            }
            else { MessageBox.Show("Cannot push with empty " + (lvi.Text == "" ? "Username" : "Message") + " field!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            txtMessage.Text = "";
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //Thread for mining here
            new Task(() =>
            {
                messagingChain.push();
                if (listWriteBuffer.InvokeRequired)
                {
                    listWriteBuffer.Invoke((MethodInvoker)delegate
                    {
                        listWriteBuffer.Items.Clear();
                    });
                }
                else
                {
                    listWriteBuffer.Items.Clear();
                }
                MessageBox.Show("New Blockchain Size: " + messagingChain.chain.Count.ToString(), "Mining Complete!");
            }).Start();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (!messagingChain.validate())
            {
                throw new Exception("Corrupted blockchain!"); //validate function is broken. Fix
            }
            listReadChain.Items.Clear();
            foreach (Block<String> block in messagingChain.chain)
            {
                MessageBox.Show("Handling block " + block.index.ToString() + " and its " + block.objects.Length.ToString() + " messages.", "Processing...");
                foreach (string message in block.objects)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = message;
                    listReadChain.Items.Add(lvi);
                }
            }
        }
    }
}
