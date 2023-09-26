using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter($"{Server.MapPath(".")}/archivo.txt", true);
            string rta1 = CheckBox1.Checked.ToString();
            string rta2 = CheckBox1.Checked.ToString();
            streamWriter.WriteLine(rta1);
            streamWriter.WriteLine(rta2);
            string rta3 = RadioButtonList1.SelectedItem.Value;
            streamWriter.WriteLine(rta3);
            streamWriter.Close();

        }
    }
}