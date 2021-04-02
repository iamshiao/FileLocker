using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileLocker
{
    public partial class Form_locker : Form
    {
        FileStream _fs;

        public Form_locker()
        {
            InitializeComponent();
        }

        private void button_lock_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(textBox_path.Text))
                {
                    throw new Exception("Can't find a valid file from provided path");
                }

                _fs = new FileStream(textBox_path.Text, FileMode.Open, FileAccess.Read, FileShare.None);
                MessageBox.Show("File locked successfully", "File Locker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to lock the file. {ex.Message}", "File Locker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_unlock_Click(object sender, EventArgs e)
        {
            try
            {
                _fs.Close();
                _fs.Dispose();
                MessageBox.Show("File unlocked successfully", "File Locker", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to unlock the file. {ex.Message}", "File Locker", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
