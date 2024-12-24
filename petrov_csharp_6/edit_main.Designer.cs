using System.Drawing;
using System.Windows.Forms;

namespace petrov_csharp_6
{
    partial class edit_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_main));
            this.read_button = new System.Windows.Forms.Button();
            this.listbox = new System.Windows.Forms.ListBox();
            this.clear_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.weight_label = new System.Windows.Forms.Label();
            this.width_label = new System.Windows.Forms.Label();
            this.height_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.stock_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.condition_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.edit_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_used = new System.Windows.Forms.Button();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_weight = new System.Windows.Forms.TextBox();
            this.text_width = new System.Windows.Forms.TextBox();
            this.text_height = new System.Windows.Forms.TextBox();
            this.text_price = new System.Windows.Forms.TextBox();
            this.text_age = new System.Windows.Forms.TextBox();
            this.text_condition = new System.Windows.Forms.TextBox();
            this.text_description = new System.Windows.Forms.TextBox();
            this.check_stock = new System.Windows.Forms.CheckBox();
            this.add_new = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // read_button
            // 
            this.read_button.Location = new System.Drawing.Point(12, 722);
            this.read_button.Name = "read_button";
            this.read_button.Size = new System.Drawing.Size(198, 31);
            this.read_button.TabIndex = 0;
            this.read_button.Text = "Открыть файл";
            this.read_button.UseVisualStyleBackColor = true;
            this.read_button.Click += new System.EventHandler(this.read_button_Click);
            // 
            // listbox
            // 
            this.listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listbox.FormattingEnabled = true;
            this.listbox.ItemHeight = 25;
            this.listbox.Location = new System.Drawing.Point(12, 12);
            this.listbox.Name = "listbox";
            this.listbox.Size = new System.Drawing.Size(606, 704);
            this.listbox.TabIndex = 1;
            this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(216, 722);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(198, 31);
            this.clear_button.TabIndex = 2;
            this.clear_button.Text = "Очистить список";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(420, 722);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(198, 31);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "Сохранить файл";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(624, 24);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(109, 25);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "Название";
            // 
            // weight_label
            // 
            this.weight_label.AutoSize = true;
            this.weight_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weight_label.Location = new System.Drawing.Point(624, 90);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(49, 25);
            this.weight_label.TabIndex = 5;
            this.weight_label.Text = "Вес";
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.width_label.Location = new System.Drawing.Point(624, 153);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(90, 25);
            this.width_label.TabIndex = 6;
            this.width_label.Text = "Ширина";
            // 
            // height_label
            // 
            this.height_label.AutoSize = true;
            this.height_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.height_label.Location = new System.Drawing.Point(624, 219);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(86, 25);
            this.height_label.TabIndex = 7;
            this.height_label.Text = "Высота";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_label.Location = new System.Drawing.Point(624, 290);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(64, 25);
            this.price_label.TabIndex = 8;
            this.price_label.Text = "Цена";
            // 
            // stock_label
            // 
            this.stock_label.AutoSize = true;
            this.stock_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stock_label.Location = new System.Drawing.Point(624, 352);
            this.stock_label.Name = "stock_label";
            this.stock_label.Size = new System.Drawing.Size(98, 25);
            this.stock_label.TabIndex = 9;
            this.stock_label.Text = "Наличие";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_label.Location = new System.Drawing.Point(624, 420);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(94, 25);
            this.age_label.TabIndex = 10;
            this.age_label.Text = "Возраст";
            // 
            // condition_label
            // 
            this.condition_label.AutoSize = true;
            this.condition_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.condition_label.Location = new System.Drawing.Point(624, 483);
            this.condition_label.Name = "condition_label";
            this.condition_label.Size = new System.Drawing.Size(119, 25);
            this.condition_label.TabIndex = 11;
            this.condition_label.Text = "Состояние";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description_label.Location = new System.Drawing.Point(624, 550);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(111, 25);
            this.description_label.TabIndex = 12;
            this.description_label.Text = "Описание";
            // 
            // edit_button
            // 
            this.edit_button.Location = new System.Drawing.Point(810, 722);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(118, 31);
            this.edit_button.TabIndex = 13;
            this.edit_button.Text = "Редактировать";
            this.edit_button.UseVisualStyleBackColor = true;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(624, 722);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(180, 31);
            this.delete_button.TabIndex = 14;
            this.delete_button.Text = "Удалить";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // add_used
            // 
            this.add_used.Location = new System.Drawing.Point(1058, 722);
            this.add_used.Name = "add_used";
            this.add_used.Size = new System.Drawing.Size(118, 31);
            this.add_used.TabIndex = 15;
            this.add_used.Text = "Добавить Б/У";
            this.add_used.UseVisualStyleBackColor = true;
            this.add_used.Click += new System.EventHandler(this.add_used_Click);
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_name.Location = new System.Drawing.Point(815, 24);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(345, 29);
            this.text_name.TabIndex = 16;
            // 
            // text_weight
            // 
            this.text_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_weight.Location = new System.Drawing.Point(815, 90);
            this.text_weight.Name = "text_weight";
            this.text_weight.Size = new System.Drawing.Size(345, 29);
            this.text_weight.TabIndex = 17;
            // 
            // text_width
            // 
            this.text_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_width.Location = new System.Drawing.Point(815, 153);
            this.text_width.Name = "text_width";
            this.text_width.Size = new System.Drawing.Size(345, 29);
            this.text_width.TabIndex = 18;
            // 
            // text_height
            // 
            this.text_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_height.Location = new System.Drawing.Point(815, 219);
            this.text_height.Name = "text_height";
            this.text_height.Size = new System.Drawing.Size(345, 29);
            this.text_height.TabIndex = 19;
            // 
            // text_price
            // 
            this.text_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_price.Location = new System.Drawing.Point(815, 290);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(345, 29);
            this.text_price.TabIndex = 20;
            // 
            // text_age
            // 
            this.text_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_age.Location = new System.Drawing.Point(815, 418);
            this.text_age.Name = "text_age";
            this.text_age.Size = new System.Drawing.Size(345, 29);
            this.text_age.TabIndex = 22;
            // 
            // text_condition
            // 
            this.text_condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_condition.Location = new System.Drawing.Point(815, 483);
            this.text_condition.Name = "text_condition";
            this.text_condition.Size = new System.Drawing.Size(345, 29);
            this.text_condition.TabIndex = 23;
            // 
            // text_description
            // 
            this.text_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_description.Location = new System.Drawing.Point(815, 550);
            this.text_description.Multiline = true;
            this.text_description.Name = "text_description";
            this.text_description.Size = new System.Drawing.Size(345, 112);
            this.text_description.TabIndex = 24;
            // 
            // check_stock
            // 
            this.check_stock.Appearance = System.Windows.Forms.Appearance.Button;
            this.check_stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.check_stock.Location = new System.Drawing.Point(815, 359);
            this.check_stock.Name = "check_stock";
            this.check_stock.Size = new System.Drawing.Size(25, 25);
            this.check_stock.TabIndex = 25;
            this.check_stock.UseVisualStyleBackColor = true;
            // 
            // add_new
            // 
            this.add_new.Location = new System.Drawing.Point(934, 722);
            this.add_new.Name = "add_new";
            this.add_new.Size = new System.Drawing.Size(118, 31);
            this.add_new.TabIndex = 26;
            this.add_new.Text = "Добавить новый";
            this.add_new.UseVisualStyleBackColor = true;
            this.add_new.Click += new System.EventHandler(this.add_new_Click);
            // 
            // edit_main
            // 
            this.ClientSize = new System.Drawing.Size(1184, 765);
            this.Controls.Add(this.add_new);
            this.Controls.Add(this.check_stock);
            this.Controls.Add(this.text_description);
            this.Controls.Add(this.text_condition);
            this.Controls.Add(this.text_age);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.text_height);
            this.Controls.Add(this.text_width);
            this.Controls.Add(this.text_weight);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.add_used);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.condition_label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.stock_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.height_label);
            this.Controls.Add(this.width_label);
            this.Controls.Add(this.weight_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.listbox);
            this.Controls.Add(this.read_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "edit_main";
            this.Text = "Петров АС-22-04 лр6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button read_button;
        private System.Windows.Forms.ListBox listbox;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label weight_label;
        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.Label height_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label stock_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label condition_label;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button add_used;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_weight;
        private System.Windows.Forms.TextBox text_width;
        private System.Windows.Forms.TextBox text_height;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.TextBox text_age;
        private System.Windows.Forms.TextBox text_condition;
        private System.Windows.Forms.TextBox text_description;
        private System.Windows.Forms.CheckBox check_stock;
        private Button add_new;
    }
}

