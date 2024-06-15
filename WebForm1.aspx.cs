using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PS3Lib;
using PS3ManagerAPI;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public static PS3API PS3 = new PS3API();
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<h1>Web Page RTM Tool<h1>");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (PS3.ConnectTarget(TextBox1.Text))
            {
                Label1.Text = "Connected";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Label1.Text = "Failed to connect";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (PS3.AttachProcess())
            {
                Label1.Text = "Attached";
                Label1.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                Label1.Text = "Failed to attach";
                Label1.ForeColor = System.Drawing.Color.Red;
            }
            Label1.Text = "Welcome : " + PS3.Extension.ReadString(0x02000934);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            PS3.Extension.WriteString(0x02000934, TextBox1.Text);
        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.ControlConsole);
        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            PS3.ChangeAPI(SelectAPI.TargetManager);
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked)
            {
                PS3.SetMemory(0xEBDF4, new byte[] { 0x40, 0x9A, 0x00, 0xC4 });
            }
            else
            {
                PS3.SetMemory(0xEBDF4, new byte[] { 0x41, 0x9A, 0x00, 0xC4 });
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(0xEBDF4, new byte[] { 0x40, 0x9A, 0x00, 0xC4 });
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(0xEBDF4, new byte[] { 0x41, 0x9A, 0x00, 0xC4 });
        }
    }
}