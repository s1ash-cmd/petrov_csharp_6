using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static petrov_csharp_6.edit_main;

namespace petrov_csharp_6
{
    public partial class add_edit_dialog : Form
    {
        private ItemStruct _item;
        private bool _isAdding;
        private int _itemType;

        public add_edit_dialog(ItemStruct item, bool isAdding, int itemType)
        {
            InitializeComponent();
            _item = item;
            _isAdding = isAdding;
            _itemType = itemType;

            if (_isAdding)
            {
                InitializeAddingMode();
            }
            else
            {
                InitializeEditingMode();
            }
        }

        private void InitializeAddingMode()
        {
            text_name.Text = "";
            text_weight.Text = "";
            text_width.Text = "";
            text_height.Text = "";
            text_price.Text = "";
            check_stock.Checked = false;

            SetOptionalFieldsVisibility(_itemType == 1);
        }

        private void InitializeEditingMode()
        {
            text_name.Text = _item.Name;
            text_weight.Text = _item.Weight.ToString();
            text_width.Text = _item.Width.ToString();
            text_height.Text = _item.Height.ToString();
            text_price.Text = _item.Price.ToString();
            check_stock.Checked = _item.Stock;

            if (!string.IsNullOrEmpty(_item.Description))
            {
                text_age.Text = _item.Age.ToString();
                text_condition.Text = _item.Condition.ToString();
                text_description.Text = _item.Description;

                SetOptionalFieldsVisibility(true);
            }
            else
            {
                SetOptionalFieldsVisibility(false);
            }
        }

        private void SetOptionalFieldsVisibility(bool isVisible)
        {
            text_age.Visible = isVisible;
            text_condition.Visible = isVisible;
            text_description.Visible = isVisible;
            age_label.Visible = isVisible;
            condition_label.Visible = isVisible;
            description_label.Visible = isVisible;
        }

        public ItemStruct GetUpdatedItem()
        {
            _item.Name = text_name.Text;
            _item.Weight = double.TryParse(text_weight.Text, out double weight) ? weight : 0;
            _item.Width = double.TryParse(text_width.Text, out double width) ? width : 0;
            _item.Height = double.TryParse(text_height.Text, out double height) ? height : 0;
            _item.Price = int.TryParse(text_price.Text, out int price) ? price : 0;
            _item.Stock = check_stock.Checked;

            if (!string.IsNullOrWhiteSpace(text_description.Text))
            {
                _item.Age = int.TryParse(text_age.Text, out int age) ? age : 0;
                _item.Condition = double.TryParse(text_condition.Text, out double condition) ? condition : 0;
                _item.Description = text_description.Text;
            }

            return _item;
        }


        private bool ValidateInput(out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(text_name.Text))
            {
                errorMessage = "Имя товара не может быть пустым.";
                return false;
            }

            if (!ValidatePositiveDouble(text_weight.Text, "Вес", out errorMessage)) return false;
            if (!ValidatePositiveDouble(text_height.Text, "Высота", out errorMessage)) return false;
            if (!ValidatePositiveDouble(text_width.Text, "Ширина", out errorMessage)) return false;
            if (!ValidatePositiveDouble(text_price.Text, "Цена", out errorMessage)) return false;

            if (description_label.Visible)
            {
                if (string.IsNullOrWhiteSpace(text_description.Text))
                {
                    errorMessage = "Описание не может быть пустым.";
                    return false;
                }

                if (!ValidateNonNegativeInt(text_age.Text, "Возраст", out errorMessage)) return false;
                if (!ValidateConditionRange(text_condition.Text, out errorMessage)) return false;
            }

            errorMessage = null;
            return true;
        }

        private bool ValidatePositiveDouble(string input, string fieldName, out string errorMessage)
        {
            if (!double.TryParse(input, out double value) || value <= 0)
            {
                errorMessage = $"{fieldName} должен быть числом больше нуля.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        private bool ValidateNonNegativeInt(string input, string fieldName, out string errorMessage)
        {
            if (!int.TryParse(input, out int value) || value < 0)
            {
                errorMessage = $"{fieldName} должен быть числом больше или равным нулю.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        private bool ValidateConditionRange(string input, out string errorMessage)
        {
            if (!double.TryParse(input, out double value) || value < 0 || value > 10)
            {
                errorMessage = "Состояние должно быть в диапазоне от 0,0 до 10,0.";
                return false;
            }

            errorMessage = null;
            return true;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void save_button_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInput(out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
