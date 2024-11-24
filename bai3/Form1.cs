using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnxoa_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                
                lvNhanVien.Items.Remove(lvNhanVien.SelectedItems[0]);
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
      

        private void btnsua_Click(object sender, EventArgs e)
        {
            if (lvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = lvNhanVien.SelectedItems[0];

            
                selectedItem.Text = txtLastName.Text;
                selectedItem.SubItems[1].Text = txtFileName.Text;
                selectedItem.SubItems[2].Text = txtPhone.Text;

                MessageBox.Show("Sửa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem(txtLastName.Text);
            lvi.SubItems.Add(txtFileName.Text);
            lvi.SubItems.Add(txtPhone.Text);

            lvNhanVien.Items.Add(lvi);
        }

        private void lvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
