using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kemimakkeren
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void getDirButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileBrowseDialog = new OpenFileDialog();
            fileBrowseDialog.Title = "Vælg Excel-filen med data";
            fileBrowseDialog.Filter = "Excel filer (*.xlsx; *.csv;)|*.xlsx; *.csv;|All files (*.*)|*.*";
            if (fileBrowseDialog.ShowDialog() == DialogResult.OK)
            {
                values.filePath = fileBrowseDialog.FileName;
            }
            else
            {
                MessageBox.Show("Error browsing for file... Please try again");
            }
        }
    }
}
