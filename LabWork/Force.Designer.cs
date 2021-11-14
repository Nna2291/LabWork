
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
            this.update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(781, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 41;
            this.dataGridView1.Size = new System.Drawing.Size(1166, 558);
            this.dataGridView1.TabIndex = 0;
            // 
            // road_text
            // 
            this.road_text.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.road_text.Location = new System.Drawing.Point(43, 66);
            this.road_text.Name = "road_text";
            this.road_text.PlaceholderText = "Вид поверхности";
            this.road_text.Size = new System.Drawing.Size(474, 51);
            this.road_text.TabIndex = 1;
            // 
            // Normal_force
            // 
            this.Normal_force.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Normal_force.Location = new System.Drawing.Point(43, 292);
            this.Normal_force.Name = "Normal_force";
            this.Normal_force.PlaceholderText = "Сила нормальной реакции опоры N, Н";
            this.Normal_force.Size = new System.Drawing.Size(696, 51);
            this.Normal_force.TabIndex = 2;
            // 
            // number_weights
            // 
            this.number_weights.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_weights.Location = new System.Drawing.Point(43, 190);
            this.number_weights.Name = "number_weights";
            this.number_weights.PlaceholderText = "Число грузов";
            this.number_weights.Size = new System.Drawing.Size(474, 51);
            this.number_weights.TabIndex = 3;
            // 
            // Force_tr
            // 
            this.Force_tr.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Force_tr.Location = new System.Drawing.Point(43, 424);
            this.Force_tr.Name = "Force_tr";
            this.Force_tr.PlaceholderText = "Сила трения F, Н";
            this.Force_tr.Size = new System.Drawing.Size(474, 51);
            this.Force_tr.TabIndex = 4;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(43, 551);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(270, 84);
            this.update.TabIndex = 5;
            this.update.Text = "button1";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // Force
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.update);
            this.Controls.Add(this.Force_tr);
            this.Controls.Add(this.number_weights);
            this.Controls.Add(this.Normal_force);
            this.Controls.Add(this.road_text);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.Button update;
    }
}
