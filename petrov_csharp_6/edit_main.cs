using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petrov_csharp_6
{
    public partial class edit_main : Form
    {
        [DllImport("C:/Users/s1ash/source/repos/petrov_csharp_6/x64/Release/cpp6.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern string items_read(string filePath); // теперь возвращаем строку

        

        public edit_main()
        {
            InitializeComponent();

           
           

            
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_main));
            this.read_button = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // read_button
            // 
            this.read_button.Location = new System.Drawing.Point(127, 724);
            this.read_button.Name = "read_button";
            this.read_button.Size = new System.Drawing.Size(103, 29);
            this.read_button.TabIndex = 0;
            this.read_button.Text = "Открыть файл";
            this.read_button.UseVisualStyleBackColor = true;
            this.read_button.Click += new System.EventHandler(this.read_button_Click);
            // 
            // listbox
            // 
            this.listbox.FormattingEnabled = true;
            this.listbox.Location = new System.Drawing.Point(12, 12);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(606, 706);
            this.listbox.TabIndex = 1;
            // 
            // edit_main
            // 
            this.ClientSize = new System.Drawing.Size(1184, 765);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.read_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "edit_main";
            this.Text = "Петров АС-22-04 лр6";
            this.Load += new System.EventHandler(this.edit_main_Load);
            this.ResumeLayout(false);

        }

        private void edit_main_Load(object sender, EventArgs e)
        {

        }

        private void read_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                openFileDialog.Title = "Выберите файл для десериализации";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    try
                    {
                        string result = items_read(filePath);

                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }






    }
}
