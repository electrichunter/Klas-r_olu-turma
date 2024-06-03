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

namespace şaka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderName = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(folderName))
            {
                int folderCount;
                if (int.TryParse(folderName, out folderCount) && folderCount > 0 && folderCount <= 99999999999999999)
                {
                    for (int i = 1; i <= folderCount; i++)
                    {
                        string folderPath = Path.Combine(desktopPath, $"klasör-name{i}");

                        if (!Directory.Exists(folderPath))
                        {
                            Directory.CreateDirectory(folderPath);
                        }
                    }
                    MessageBox.Show($"{folderCount}  başarıyla oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Geçerli bir sayı girin (1-99999999999999999 arası).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir sayı girin (1-99999999999999999 arası).", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
  
