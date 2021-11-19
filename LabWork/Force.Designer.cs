
namespace LabWork
{
    partial class Force
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.road_text = new System.Windows.Forms.TextBox();
            this.Normal_force = new System.Windows.Forms.TextBox();
            this.number_weights = new System.Windows.Forms.TextBox();
            this.Force_tr = new System.Windows.Forms.TextBox();
            this.plu_1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.plu_2 = new System.Windows.Forms.TextBox();
            this.update = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(1005, 524);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(970, 526);
            this.dataGridView1.TabIndex = 0;
            // 
            // road_text
            // 
            this.road_text.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.road_text.Location = new System.Drawing.Point(34, 70);
            this.road_text.Name = "road_text";
            this.road_text.PlaceholderText = "Вид поверхности";
            this.road_text.Size = new System.Drawing.Size(474, 40);
            this.road_text.TabIndex = 1;
            // 
            // Normal_force
            // 
            this.Normal_force.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Normal_force.Location = new System.Drawing.Point(34, 230);
            this.Normal_force.Name = "Normal_force";
            this.Normal_force.PlaceholderText = "Сила нормальной реакции опоры N, Н";
            this.Normal_force.Size = new System.Drawing.Size(512, 40);
            this.Normal_force.TabIndex = 2;
            // 
            // number_weights
            // 
            this.number_weights.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_weights.Location = new System.Drawing.Point(34, 148);
            this.number_weights.Name = "number_weights";
            this.number_weights.PlaceholderText = "Число грузов";
            this.number_weights.Size = new System.Drawing.Size(474, 40);
            this.number_weights.TabIndex = 3;
            // 
            // Force_tr
            // 
            this.Force_tr.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Force_tr.Location = new System.Drawing.Point(34, 302);
            this.Force_tr.Name = "Force_tr";
            this.Force_tr.PlaceholderText = "Сила трения F, Н";
            this.Force_tr.Size = new System.Drawing.Size(236, 40);
            this.Force_tr.TabIndex = 4;
            // 
            // plu_1
            // 
            this.plu_1.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plu_1.Location = new System.Drawing.Point(552, 230);
            this.plu_1.Name = "plu_1";
            this.plu_1.PlaceholderText = "Погрешность";
            this.plu_1.Size = new System.Drawing.Size(238, 40);
            this.plu_1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(34, 433);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 39);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 524);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // plotView1
            // 
            this.plotView1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.plotView1.Location = new System.Drawing.Point(815, 3);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(1160, 515);
            this.plotView1.TabIndex = 9;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plu_2
            // 
            this.plu_2.Font = new System.Drawing.Font("Segoe UI Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.plu_2.Location = new System.Drawing.Point(276, 302);
            this.plu_2.Name = "plu_2";
            this.plu_2.PlaceholderText = "Погрешность";
            this.plu_2.Size = new System.Drawing.Size(246, 40);
            this.plu_2.TabIndex = 7;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(34, 364);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(150, 46);
            this.update.TabIndex = 10;
            this.update.Text = "button2";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click_1);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Segoe MDL2 Assets", 34.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.error.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error.Location = new System.Drawing.Point(65, 603);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 91);
            this.error.TabIndex = 11;
            // 
            // Force
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.error);
            this.Controls.Add(this.update);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.plu_2);
            this.Controls.Add(this.Force_tr);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.road_text);
            this.Controls.Add(this.plu_1);
            this.Controls.Add(this.number_weights);
            this.Controls.Add(this.Normal_force);
            this.Name = "Force";
            this.Size = new System.Drawing.Size(1978, 1054);
            this.Load += new System.EventHandler(this.Force_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox road_text;
        private System.Windows.Forms.TextBox Normal_force;
        private System.Windows.Forms.TextBox number_weights;
        private System.Windows.Forms.TextBox Force_tr;
        private System.Windows.Forms.TextBox plu_1;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox plu_2;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label error;
    }
}
