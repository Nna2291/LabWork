
namespace Application
{
    partial class MainInfoPanel
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
            this.Label = new System.Windows.Forms.Label();
            this.EquipmentField = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AimField = new System.Windows.Forms.RichTextBox();
            this.LabName = new System.Windows.Forms.TextBox();
            this.group = new System.Windows.Forms.TextBox();
            this.lastname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Final = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label.Location = new System.Drawing.Point(710, 357);
            this.Label.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(261, 45);
            this.Label.TabIndex = 60;
            this.Label.Text = "Оборудование";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Label.Click += new System.EventHandler(this.Label_Click);
            // 
            // EquipmentField
            // 
            this.EquipmentField.Location = new System.Drawing.Point(710, 438);
            this.EquipmentField.Name = "EquipmentField";
            this.EquipmentField.Size = new System.Drawing.Size(562, 376);
            this.EquipmentField.TabIndex = 59;
            this.EquipmentField.Text = "";
            this.EquipmentField.TextChanged += new System.EventHandler(this.EquipmentField_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(26, 357);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 45);
            this.label1.TabIndex = 58;
            this.label1.Text = "Цель работы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AimField
            // 
            this.AimField.Location = new System.Drawing.Point(26, 438);
            this.AimField.Name = "AimField";
            this.AimField.Size = new System.Drawing.Size(562, 376);
            this.AimField.TabIndex = 57;
            this.AimField.Text = "";
            this.AimField.TextChanged += new System.EventHandler(this.AimField_TextChanged);
            // 
            // LabName
            // 
            this.LabName.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabName.Location = new System.Drawing.Point(792, 44);
            this.LabName.Name = "LabName";
            this.LabName.PlaceholderText = "Название лабораторной работы";
            this.LabName.Size = new System.Drawing.Size(900, 51);
            this.LabName.TabIndex = 56;
            this.LabName.TextChanged += new System.EventHandler(this.LabName_TextChanged);
            // 
            // group
            // 
            this.group.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.group.Location = new System.Drawing.Point(26, 244);
            this.group.Name = "group";
            this.group.PlaceholderText = "Группа";
            this.group.Size = new System.Drawing.Size(562, 51);
            this.group.TabIndex = 55;
            this.group.TextChanged += new System.EventHandler(this.group_TextChanged);
            // 
            // lastname
            // 
            this.lastname.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lastname.Location = new System.Drawing.Point(26, 144);
            this.lastname.Name = "lastname";
            this.lastname.PlaceholderText = "Фамилия";
            this.lastname.Size = new System.Drawing.Size(562, 51);
            this.lastname.TabIndex = 54;
            this.lastname.TextChanged += new System.EventHandler(this.lastname_TextChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.name.Location = new System.Drawing.Point(26, 44);
            this.name.Name = "name";
            this.name.PlaceholderText = "Имя";
            this.name.Size = new System.Drawing.Size(562, 51);
            this.name.TabIndex = 53;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(1394, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 45);
            this.label2.TabIndex = 62;
            this.label2.Text = "Вывод";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Final
            // 
            this.Final.Location = new System.Drawing.Point(1394, 438);
            this.Final.Name = "Final";
            this.Final.Size = new System.Drawing.Size(562, 376);
            this.Final.TabIndex = 61;
            this.Final.Text = "";
            this.Final.TextChanged += new System.EventHandler(this.Final_TextChanged);
            // 
            // MainInfoPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Final);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.EquipmentField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AimField);
            this.Controls.Add(this.LabName);
            this.Controls.Add(this.group);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.name);
            this.Name = "MainInfoPanel";
            this.Size = new System.Drawing.Size(1978, 1054);
            this.Load += new System.EventHandler(this.MainInfoPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.RichTextBox EquipmentField;
        public string EquipmentText
        {
            get { return EquipmentField.Text; }
            set { EquipmentField.Text = value; }
        }
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox AimField;
        public string AimText
        {
            get { return AimField.Text; }
            set { AimField.Text = value;}
        }
        private System.Windows.Forms.TextBox LabName;
        public string LabNameText
        {
            get { return LabName.Text; }
            set { LabName.Text = value; }
        }
        private System.Windows.Forms.TextBox group;
        public string grouptext
        {
            get { return group.Text; }
            set { group.Text = value; }
        }

        private System.Windows.Forms.TextBox lastname;
        public string lastnametext
        {
            get { return lastname.Text; }
            set { lastname.Text = value; }
        }
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox Final;
        public string Finaltext
        {
            get { return Final.Text; }
            set { Final.Text = value; }
        }
        public string nametext
        {
            get { return name.Text; }
            set { name.Text = value; }
        }
    }
}
