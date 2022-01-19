
namespace Application
{
    partial class Tangens
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
            this.update = new System.Windows.Forms.Button();
            this.plu_2 = new System.Windows.Forms.TextBox();
            this.Height = new System.Windows.Forms.TextBox();
            this.plu_1 = new System.Windows.Forms.TextBox();
            this.Length = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.length_text = new System.Windows.Forms.Label();
            this.height_text = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(65, 232);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(488, 46);
            this.update.TabIndex = 15;
            this.update.Text = "Установить данные";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // plu_2
            // 
            this.plu_2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plu_2.Location = new System.Drawing.Point(307, 174);
            this.plu_2.Name = "plu_2";
            this.plu_2.PlaceholderText = "Погрешность";
            this.plu_2.Size = new System.Drawing.Size(246, 40);
            this.plu_2.TabIndex = 14;
            // 
            // Height
            // 
            this.Height.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Height.Location = new System.Drawing.Point(65, 174);
            this.Height.Name = "Height";
            this.Height.PlaceholderText = "Высота, см";
            this.Height.Size = new System.Drawing.Size(236, 40);
            this.Height.TabIndex = 12;
            // 
            // plu_1
            // 
            this.plu_1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plu_1.Location = new System.Drawing.Point(583, 108);
            this.plu_1.Name = "plu_1";
            this.plu_1.PlaceholderText = "Погрешность";
            this.plu_1.Size = new System.Drawing.Size(238, 40);
            this.plu_1.TabIndex = 13;
            // 
            // Length
            // 
            this.Length.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Length.Location = new System.Drawing.Point(65, 108);
            this.Length.Name = "Length";
            this.Length.PlaceholderText = "Длина трибометра, см";
            this.Length.Size = new System.Drawing.Size(512, 40);
            this.Length.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(65, 377);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 62);
            this.label1.TabIndex = 16;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // length_text
            // 
            this.length_text.AutoSize = true;
            this.length_text.Font = new System.Drawing.Font("Segoe UI Black", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.length_text.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.length_text.Location = new System.Drawing.Point(335, 377);
            this.length_text.Name = "length_text";
            this.length_text.Size = new System.Drawing.Size(0, 62);
            this.length_text.TabIndex = 17;
            // 
            // height_text
            // 
            this.height_text.AutoSize = true;
            this.height_text.Font = new System.Drawing.Font("Segoe UI Black", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.height_text.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.height_text.Location = new System.Drawing.Point(335, 500);
            this.height_text.Name = "height_text";
            this.height_text.Size = new System.Drawing.Size(0, 62);
            this.height_text.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Location = new System.Drawing.Point(65, 500);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 62);
            this.label4.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 613);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(488, 46);
            this.button1.TabIndex = 20;
            this.button1.Text = "Произвести расчеты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1552, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(718, 1247);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(65, 665);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(488, 46);
            this.button2.TabIndex = 22;
            this.button2.Text = "Отчистить данные";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Tangens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.height_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.length_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.plu_2);
            this.Controls.Add(this.Height);
            this.Controls.Add(this.plu_1);
            this.Controls.Add(this.Length);
            this.Name = "Tangens";
            this.Size = new System.Drawing.Size(2362, 1247);
            this.Load += new System.EventHandler(this.Tangens_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update;
        private System.Windows.Forms.TextBox plu_2;
        private System.Windows.Forms.TextBox Height;
        private System.Windows.Forms.TextBox plu_1;
        private System.Windows.Forms.TextBox Length;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label length_text;
        private System.Windows.Forms.Label height_text;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}
