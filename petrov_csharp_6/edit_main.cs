using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace petrov_csharp_6
{
    public partial class edit_main : Form
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public struct ItemStruct
        {
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Name;

            [MarshalAs(UnmanagedType.R8)]
            public double Weight;

            [MarshalAs(UnmanagedType.R8)]
            public double Width;

            [MarshalAs(UnmanagedType.R8)]
            public double Height;

            [MarshalAs(UnmanagedType.I4)]
            public int Price;

            [MarshalAs(UnmanagedType.Bool)]
            public bool Stock;

            [MarshalAs(UnmanagedType.I4)]
            public int Age;

            [MarshalAs(UnmanagedType.R8)]
            public double Condition;

            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
            public string Description;
        }

        [DllImport("C:/Users/s1ash/source/repos/petrov_csharp_6/x64/Release/cpp6.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern void shop_get_item(ref ItemStruct itemData, int id);

        [DllImport("C:/Users/s1ash/source/repos/petrov_csharp_6/x64/Release/cpp6.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern void shop_read(IntPtr filePath);

        [DllImport("C:/Users/s1ash/source/repos/petrov_csharp_6/x64/Release/cpp6.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void shop_write(StringBuilder filePath);

        [DllImport("C:/Users/s1ash/source/repos/petrov_csharp_6/x64/Release/cpp6.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern int GetShopSize();

        [DllImport("C:/Users/s1ash/source/repos/petrov_csharp_6/x64/Release/cpp6.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        public static extern void ClearShop();

        [DllImport("C:/Users/s1ash/source/repos/petrov_csharp_6/x64/Release/cpp6.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern void shop_delete(int id);

        [DllImport("C:/Users/s1ash/source/repos/petrov_csharp_6/x64/Release/cpp6.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern void shop_update_item(ref ItemStruct itemData, int id);

        [DllImport("C:/Users/s1ash/source/repos/petrov_csharp_6/x64/Release/cpp6.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        private static extern void shop_add_item(ref ItemStruct itemData, int is_used);


        public edit_main()
        {
            InitializeComponent();
            ToggleFields(true);
        }

        private void UpdateListBox()
        {
            listbox.Items.Clear();
            for (int i = 0; i < GetShopSize(); i++)
            {
                var item = new ItemStruct();
                shop_get_item(ref item, i);
                listbox.Items.Add(item.Name);
            }

        }

        private void read_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;

                IntPtr ptr = Marshal.StringToHGlobalAnsi(filename);

                try
                {
                    MessageBox.Show("Файл успешно загружен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    shop_read(ptr);
                    UpdateListBox();
                    listbox.SelectedIndex = listbox.Items.Count - 1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при чтении файла: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Marshal.FreeHGlobal(ptr);
                }
            }
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (listbox.Items.Count == 0)
            {
                MessageBox.Show("Невозможно сохранить файл: список товаров пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFileDialog.Title = "Выберите путь для сохранения файла";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    try
                    {
                        StringBuilder sb = new StringBuilder(filePath);
                        shop_write(sb);

                        MessageBox.Show("Файл успешно сохранён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}\n{ex.StackTrace}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            if (listbox.Items.Count == 0)
            {
                MessageBox.Show("Невозможно очистить: список товаров пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                listbox.Items.Clear();
                ClearShop();
                ClearFields();

                MessageBox.Show("Список товаров очищен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void ClearFields()
        {
            text_name.Text = "";
            text_weight.Text = "";
            text_width.Text = "";
            text_height.Text = "";
            text_price.Text = "";
            check_stock.Checked = false;

            text_age.Text = "";
            text_condition.Text = "";
            text_description.Text = "";
        }

        private void ToggleFields(bool enable)
        {
            text_name.ReadOnly = enable;
            text_weight.ReadOnly = enable;
            text_width.ReadOnly = enable;
            text_height.ReadOnly = enable;
            text_price.ReadOnly = enable;
            check_stock.Enabled = !enable;
            text_age.ReadOnly = enable;
            text_condition.ReadOnly = enable;
            text_description.ReadOnly = enable;
        }

        private void listbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox.SelectedIndex == -1)
            {
                ClearFields();
                ToggleFields(false);
                return;
            }

            var item = new ItemStruct();
            shop_get_item(ref item, listbox.SelectedIndex);
            text_name.Text = item.Name;
            text_weight.Text = item.Weight.ToString();
            text_width.Text = item.Width.ToString();
            text_height.Text = item.Height.ToString();
            text_price.Text = item.Price.ToString();
            check_stock.Checked = item.Stock;

            if (!string.IsNullOrEmpty(item.Description))
            {
                text_age.Text = item.Age.ToString();
                text_condition.Text = item.Condition.ToString();
                text_description.Text = item.Description;


                text_age.Visible = true;
                text_condition.Visible = true;
                text_description.Visible = true;

                age_label.Visible = true;
                condition_label.Visible = true;
                description_label.Visible = true;


            }
            else
            {
                text_age.Visible = false;
                text_condition.Visible = false;
                text_description.Visible = false;

                age_label.Visible = false;
                condition_label.Visible = false;
                description_label.Visible = false;
            }
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (listbox.Items.Count == 0)
            {
                MessageBox.Show("Невозможно удалить: список товаров пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                shop_delete(listbox.SelectedIndex);
                int beforeDelete = listbox.SelectedIndex;

                UpdateListBox();

                if (beforeDelete < listbox.Items.Count)
                {
                    listbox.SelectedIndex = beforeDelete;
                }
                else if (listbox.Items.Count > 0)
                {
                    listbox.SelectedIndex = beforeDelete - 1;
                }
                else
                {
                    ClearFields();
                    ToggleFields(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении товара: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void edit_button_Click(object sender, EventArgs e)
        {
            if (listbox.Items.Count == 0)
            {
                MessageBox.Show("Невозможно редактировать: список товаров пуст", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (listbox.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, выберите элемент для редактирования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var item = new ItemStruct();
            shop_get_item(ref item, listbox.SelectedIndex);

            int itemType = string.IsNullOrEmpty(item.Description) ? 0 : 1;

            add_edit_dialog editWindow = new add_edit_dialog(item, isAdding: false, itemType: itemType);
            if (editWindow.ShowDialog() == DialogResult.OK)
            {
                var updatedItem = editWindow.GetUpdatedItem();

                try
                {
                    shop_update_item(ref updatedItem, listbox.SelectedIndex);

                    UpdateListBox();

                    listbox.SelectedIndex = listbox.Items.IndexOf(updatedItem.Name);

                    MessageBox.Show("Товар успешно обновлён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при обновлении товара: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void add_new_Click(object sender, EventArgs e)
        {
            var addWindow = new add_edit_dialog(new ItemStruct(), isAdding: true, itemType: 0);
            if (addWindow.ShowDialog() == DialogResult.OK)
            {
                var newItem = addWindow.GetUpdatedItem();
                shop_add_item(ref newItem, 0);
                UpdateListBox();
                listbox.SelectedIndex = listbox.Items.Count - 1;
            }
        }

        private void add_used_Click(object sender, EventArgs e)
        {
            var addWindow = new add_edit_dialog(new ItemStruct(), isAdding: true, itemType: 1);
            if (addWindow.ShowDialog() == DialogResult.OK)
            {
                var usedItem = addWindow.GetUpdatedItem();
                shop_add_item(ref usedItem, 1);
                UpdateListBox();
                listbox.SelectedIndex = listbox.Items.Count - 1;
            }
        }
    }
}
