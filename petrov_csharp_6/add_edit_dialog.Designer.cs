using System.Drawing;
using System.Windows.Forms;

namespace petrov_csharp_6
{
    partial class add_edit_dialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_edit_dialog));
            this.text_description = new System.Windows.Forms.TextBox();
            this.text_age = new System.Windows.Forms.TextBox();
            this.text_price = new System.Windows.Forms.TextBox();
            this.text_height = new System.Windows.Forms.TextBox();
            this.text_width = new System.Windows.Forms.TextBox();
            this.text_weight = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.description_label = new System.Windows.Forms.Label();
            this.condition_label = new System.Windows.Forms.Label();
            this.age_label = new System.Windows.Forms.Label();
            this.stock_label = new System.Windows.Forms.Label();
            this.price_label = new System.Windows.Forms.Label();
            this.height_label = new System.Windows.Forms.Label();
            this.width_label = new System.Windows.Forms.Label();
            this.weight_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.check_stock = new System.Windows.Forms.CheckBox();
            this.text_condition = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text_description
            // 
            this.text_description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_description.Location = new System.Drawing.Point(215, 567);
            this.text_description.Multiline = true;
            this.text_description.Name = "text_description";
            this.text_description.Size = new System.Drawing.Size(345, 112);
            this.text_description.TabIndex = 42;
            // 
            // text_age
            // 
            this.text_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_age.Location = new System.Drawing.Point(215, 435);
            this.text_age.Name = "text_age";
            this.text_age.Size = new System.Drawing.Size(345, 29);
            this.text_age.TabIndex = 40;
            // 
            // text_price
            // 
            this.text_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_price.Location = new System.Drawing.Point(215, 307);
            this.text_price.Name = "text_price";
            this.text_price.Size = new System.Drawing.Size(345, 29);
            this.text_price.TabIndex = 38;
            // 
            // text_height
            // 
            this.text_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_height.Location = new System.Drawing.Point(215, 236);
            this.text_height.Name = "text_height";
            this.text_height.Size = new System.Drawing.Size(345, 29);
            this.text_height.TabIndex = 37;
            // 
            // text_width
            // 
            this.text_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_width.Location = new System.Drawing.Point(215, 170);
            this.text_width.Name = "text_width";
            this.text_width.Size = new System.Drawing.Size(345, 29);
            this.text_width.TabIndex = 36;
            // 
            // text_weight
            // 
            this.text_weight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_weight.Location = new System.Drawing.Point(215, 107);
            this.text_weight.Name = "text_weight";
            this.text_weight.Size = new System.Drawing.Size(345, 29);
            this.text_weight.TabIndex = 35;
            // 
            // text_name
            // 
            this.text_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_name.Location = new System.Drawing.Point(215, 41);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(345, 29);
            this.text_name.TabIndex = 34;
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.description_label.Location = new System.Drawing.Point(24, 567);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(111, 25);
            this.description_label.TabIndex = 33;
            this.description_label.Text = "Описание";
            // 
            // condition_label
            // 
            this.condition_label.AutoSize = true;
            this.condition_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.condition_label.Location = new System.Drawing.Point(24, 500);
            this.condition_label.Name = "condition_label";
            this.condition_label.Size = new System.Drawing.Size(119, 25);
            this.condition_label.TabIndex = 32;
            this.condition_label.Text = "Состояние";
            // 
            // age_label
            // 
            this.age_label.AutoSize = true;
            this.age_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_label.Location = new System.Drawing.Point(24, 437);
            this.age_label.Name = "age_label";
            this.age_label.Size = new System.Drawing.Size(94, 25);
            this.age_label.TabIndex = 31;
            this.age_label.Text = "Возраст";
            // 
            // stock_label
            // 
            this.stock_label.AutoSize = true;
            this.stock_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stock_label.Location = new System.Drawing.Point(24, 369);
            this.stock_label.Name = "stock_label";
            this.stock_label.Size = new System.Drawing.Size(98, 25);
            this.stock_label.TabIndex = 30;
            this.stock_label.Text = "Наличие";
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price_label.Location = new System.Drawing.Point(24, 307);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(64, 25);
            this.price_label.TabIndex = 29;
            this.price_label.Text = "Цена";
            // 
            // height_label
            // 
            this.height_label.AutoSize = true;
            this.height_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.height_label.Location = new System.Drawing.Point(24, 236);
            this.height_label.Name = "height_label";
            this.height_label.Size = new System.Drawing.Size(86, 25);
            this.height_label.TabIndex = 28;
            this.height_label.Text = "Высота";
            // 
            // width_label
            // 
            this.width_label.AutoSize = true;
            this.width_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.width_label.Location = new System.Drawing.Point(24, 170);
            this.width_label.Name = "width_label";
            this.width_label.Size = new System.Drawing.Size(90, 25);
            this.width_label.TabIndex = 27;
            this.width_label.Text = "Ширина";
            // 
            // weight_label
            // 
            this.weight_label.AutoSize = true;
            this.weight_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weight_label.Location = new System.Drawing.Point(24, 107);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(49, 25);
            this.weight_label.TabIndex = 26;
            this.weight_label.Text = "Вес";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_label.Location = new System.Drawing.Point(24, 41);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(109, 25);
            this.name_label.TabIndex = 25;
            this.name_label.Text = "Название";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(29, 722);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(260, 31);
            this.save_button.TabIndex = 44;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click_1);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(300, 722);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(260, 31);
            this.cancel_button.TabIndex = 43;
            this.cancel_button.Text = "Отменить";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // check_stock
            // 
            this.check_stock.AutoSize = true;
            this.check_stock.Location = new System.Drawing.Point(215, 377);
            this.check_stock.Size = new System.Drawing.Size(30, 30);  // Увеличиваем размеры
            this.check_stock.Font = new Font(this.check_stock.Font.FontFamily, 16);  // Увеличиваем шрифт
            this.check_stock.TabIndex = 25;
            this.check_stock.UseVisualStyleBackColor = true;
            this.check_stock.Appearance = Appearance.Button;
            this.check_stock.Font = new Font("Microsoft Sans Serif", 16);
            this.check_stock.AutoSize = false;
            this.check_stock.Size = new Size(25, 25);
            // text_condition
            // 
            this.text_condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.text_condition.Location = new System.Drawing.Point(215, 500);
            this.text_condition.Name = "text_condition";
            this.text_condition.Size = new System.Drawing.Size(345, 29);
            this.text_condition.TabIndex = 41;
            // 
            // add_edit_dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 765);
            this.Controls.Add(this.check_stock);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.text_description);
            this.Controls.Add(this.text_condition);
            this.Controls.Add(this.text_age);
            this.Controls.Add(this.text_price);
            this.Controls.Add(this.text_height);
            this.Controls.Add(this.text_width);
            this.Controls.Add(this.text_weight);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.condition_label);
            this.Controls.Add(this.age_label);
            this.Controls.Add(this.stock_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.height_label);
            this.Controls.Add(this.width_label);
            this.Controls.Add(this.weight_label);
            this.Controls.Add(this.name_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 800);
            this.MinimumSize = new System.Drawing.Size(600, 800);
            this.Name = "add_edit_dialog";
            this.Text = "Петров АС-22-04 лр6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_description;
        private System.Windows.Forms.TextBox text_age;
        private System.Windows.Forms.TextBox text_price;
        private System.Windows.Forms.TextBox text_height;
        private System.Windows.Forms.TextBox text_width;
        private System.Windows.Forms.TextBox text_weight;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label description_label;
        private System.Windows.Forms.Label condition_label;
        private System.Windows.Forms.Label age_label;
        private System.Windows.Forms.Label stock_label;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label height_label;
        private System.Windows.Forms.Label width_label;
        private System.Windows.Forms.Label weight_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.CheckBox check_stock;
        private System.Windows.Forms.TextBox text_condition;
    }
}