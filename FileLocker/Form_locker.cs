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
            _fs = new FileStream(textBox_path.Text, FileMode.Open, FileAccess.Read, FileShare.None);
        }

        private void button_unlock_Click(object sender, EventArgs e)
        {
            _fs.Close();
            _fs.Dispose();
        }
    }
}
