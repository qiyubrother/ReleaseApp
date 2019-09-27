using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReleaseApp
{
    public partial class FrmCheckList : Form
    {
        public string FileListName = string.Empty;
        public FrmCheckList()
        {
            InitializeComponent();
        }
        bool isAllofOK = true;
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            listView1.FullRowSelect = true;
            listView1.View = View.Details;
            ColumnHeader clh;

            clh = new ColumnHeader();
            clh.Text = "文件名";
            clh.Width = 600;
            listView1.Columns.Add(clh);

            clh = new ColumnHeader();
            clh.Text = "状态";
            clh.Width = 40;
            listView1.Columns.Add(clh);

            var lines = File.ReadAllLines(FileListName);

            foreach (var line in lines)
            {
                var sb = new ListViewItem();
                sb.Text = line;
                var status = File.Exists(line) ? "OK" : "Lost";
                if (status == "Lost")
                {
                    isAllofOK = false;
                }
                sb.SubItems.Add(status);
                this.listView1.Items.Add(sb);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            if (isAllofOK)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            if (isAllofOK)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
