using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BCC.DotNetUI.Components.Test
{
    public partial class frmMain : Form
    {

        private int logIndex = 1;

        public frmMain()
        {
            InitializeComponent();
        }

        private void chkLVAutoScroll_CheckedChanged(object sender, EventArgs e)
        {
            bccExtendedListView1.EnableAutomaticScroll = chkLVAutoScroll.Checked;
        }

        private void txtLVDisplayLimit_TextChanged(object sender, EventArgs e)
        {
            if (!txtLVDisplayLimit.Text.Trim().Equals(""))
            {
                bccExtendedListView1.LimitDisplayNumber = int.Parse(txtLVDisplayLimit.Text);
            }
        }

        private void txtLVMaxPauseLog_TextChanged(object sender, EventArgs e)
        {
            if (!txtLVMaxPauseLog.Text.Trim().Equals(""))
            {
                bccExtendedListView1.MaxNumberWhenPaused = int.Parse(txtLVMaxPauseLog.Text);
            }
        }

        private void btnStartLogTimer_Click(object sender, EventArgs e)
        {
            tmrLvLog.Enabled = true;
        }

        private void btnStopLogTimer_Click(object sender, EventArgs e)
        {
            tmrLvLog.Enabled = false;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void tmrLvLog_Tick(object sender, EventArgs e)
        {
            ListViewItem lvLogItem = new ListViewItem(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            lvLogItem.SubItems.Add($"Log item: {logIndex}");
            bccExtendedListView1.LimitAdd(lvLogItem);
            logIndex += 1;
        }

        private void btnPauseLogInput_Click(object sender, EventArgs e)
        {
            bccExtendedListView1.PauseInput();
        }

        private void btnResumeLogInput_Click(object sender, EventArgs e)
        {
            bccExtendedListView1.ResumeInput();
        }

        private void btnCBData_Click(object sender, EventArgs e)
        {
            bccExtendedComboBox1.Items.Clear();
            bccExtendedComboBox1.Items.Add(new BCCExtendedComboBox.DropDownItem("The Color Red", "myred", Color.Red));
            bccExtendedComboBox1.Items.Add(new BCCExtendedComboBox.DropDownItem("My Image", "myimage", Image.FromFile(@"data\Arrow-Up-icon.png")));
            bccExtendedComboBox1.Items.Add(new BCCExtendedComboBox.DropDownItem("No Image - Custom Return", "noimagemyreturn"));
            bccExtendedComboBox1.Items.Add(new BCCExtendedComboBox.DropDownItem("Default Handling"));
        }

        private void bccExtendedComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCBValue.Text = bccExtendedComboBox1.Text;
        }
    }
}
