using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal class Print
    {
        DataGridView datagrid = new();
         
        public Print(DataGridView datagrid)
        {
            this.datagrid = datagrid;
        }

        public void print()
        {
            StringBuilder sb = new();

            sb.Append("<table cellpadding='5' cellspacing='0' style='border: 1px solid #ccc;font-size: 9pt;font-family:arial'>");
            sb.Append("<tr>");

            foreach (DataGridViewColumn col in datagrid.Columns)
            {
                sb.Append("<th style='background-color: #B8DBFD;border: 1px solid #ccc'>" + col.HeaderText + "</th>");
            }
            sb.Append("</tr>");

            foreach (DataGridViewRow row in datagrid.Rows)
            {
                sb.Append("<tr>");
                foreach (DataGridViewCell cell in row.Cells)
                {
                    sb.Append("<td style='width:120px;border: 1px solid #ccc'>" + cell.Value.ToString() + "</td>");
                }
                sb.Append("</tr>");
            }

            sb.Append("</table>");

            File.WriteAllText("index.html",sb.ToString());

            Process process = new Process();
            process.StartInfo.FileName = "index.html";
            process.StartInfo.UseShellExecute = true;
            process.Start();

        }
    }
    

}
