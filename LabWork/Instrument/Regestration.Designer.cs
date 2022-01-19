
namespace Application
{
    partial class Regestration
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.data_view = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dimension = new System.Windows.Forms.TextBox();
            this.add_button = new System.Windows.Forms.Button();
            this.column_name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.value2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.value1 = new System.Windows.Forms.TextBox();
            this.pogr1 = new System.Windows.Forms.TextBox();
            this.pogr2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // data_view
            // 
            this.data_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_view.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.data_view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data_view.DefaultCellStyle = dataGridViewCellStyle1;
            this.data_view.Dock = System.Windows.Forms.DockStyle.Right;
            this.data_view.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.data_view.Location = new System.Drawing.Point(1154, 0);
            this.data_view.Name = "data_view";
            this.data_view.ReadOnly = true;
            this.data_view.RowHeadersWidth = 82;
            this.data_view.RowTemplate.Height = 41;
            this.data_view.Size = new System.Drawing.Size(830, 1082);
            this.data_view.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dimension);
            this.panel3.Controls.Add(this.add_button);
            this.panel3.Controls.Add(this.column_name);
            this.panel3.Location = new System.Drawing.Point(44, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(512, 196);
            this.panel3.TabIndex = 10;
            // 
            // dimension
            // 
            this.dimension.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dimension.Location = new System.Drawing.Point(3, 78);
            this.dimension.Name = "dimension";
            this.dimension.PlaceholderText = "Еденицы измерения";
            this.dimension.Size = new System.Drawing.Size(512, 40);
            this.dimension.TabIndex = 8;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(0, 156);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(252, 40);
            this.add_button.TabIndex = 7;
            this.add_button.Text = "Добавить столбец";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // column_name
            // 
            this.column_name.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.column_name.Location = new System.Drawing.Point(3, 0);
            this.column_name.Name = "column_name";
            this.column_name.PlaceholderText = "Измеряемая велечина";
            this.column_name.Size = new System.Drawing.Size(512, 40);
            this.column_name.TabIndex = 6;
            this.column_name.TextChanged += new System.EventHandler(this.column_name_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pogr2);
            this.panel2.Controls.Add(this.pogr1);
            this.panel2.Controls.Add(this.value2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.value1);
            this.panel2.Location = new System.Drawing.Point(44, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(512, 506);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // value2
            // 
            this.value2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.value2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.value2.Location = new System.Drawing.Point(0, 252);
            this.value2.Name = "value2";
            this.value2.PlaceholderText = "Значение";
            this.value2.Size = new System.Drawing.Size(512, 40);
            this.value2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 447);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // value1
            // 
            this.value1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.value1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.value1.Location = new System.Drawing.Point(0, 80);
            this.value1.Name = "value1";
            this.value1.PlaceholderText = "Значение";
            this.value1.Size = new System.Drawing.Size(512, 40);
            this.value1.TabIndex = 6;
            this.value1.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pogr1
            // 
            this.pogr1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pogr1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pogr1.Location = new System.Drawing.Point(-3, 166);
            this.pogr1.Name = "pogr1";
            this.pogr1.PlaceholderText = "Погрешность измерения";
            this.pogr1.Size = new System.Drawing.Size(512, 40);
            this.pogr1.TabIndex = 14;
            // 
            // pogr2
            // 
            this.pogr2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pogr2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pogr2.Location = new System.Drawing.Point(-3, 338);
            this.pogr2.Name = "pogr2";
            this.pogr2.PlaceholderText = "Погрешность измерения";
            this.pogr2.Size = new System.Drawing.Size(512, 40);
            this.pogr2.TabIndex = 15;
            // 
            // Regestration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.data_view);
            this.Name = "Regestration";
            this.Size = new System.Drawing.Size(1984, 1082);
            this.Load += new System.EventHandler(this.Regestration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_view;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox dimension;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.TextBox column_name;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox value1;
        private System.Windows.Forms.TextBox value2;
        private System.Windows.Forms.TextBox pogr2;
        private System.Windows.Forms.TextBox pogr1;
    }
}
