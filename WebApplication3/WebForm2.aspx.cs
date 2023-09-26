using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = string.Empty;
            StreamReader streamReader = new StreamReader(Server.MapPath(".") + "/archivo.txt");
            string[] lines = (streamReader.ReadToEnd()).Split('\n');
            streamReader.Close();
            int lineCount = 0;
            foreach (string line in lines)
            {
                lineCount++;
                if (lineCount %3 == 0)
                {
                    string check1 = "0";
                    string check2 = "0";
                    if (lines[lineCount - 3].ToString() == "True")
                    {
                        check1 = "1";
                    }
                    if(
                        lines[lineCount - 2].ToString() == "True"){
                        check2 = "1";

                    }
                    Label1.Text += $"{check1} - {check2} <br>";
                    if(lines[lineCount - 1].ToString() == "1")
                    {
                        Label1.Text += $"1 - 0 <br> <hr>";

                    }
                    else
                    {
                        Label1.Text += $"0 - 1 <br> <hr>";

                    }

                }
            }
        }
    }
}