
namespace Application
{
    partial class Force_work
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Force_work));
            this.panelmenu = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.solving = new System.Windows.Forms.Button();
            this.Exp1 = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Export = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainInfoPanel1 = new Application.MainInfoPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.force1 = new Application.Force();
            this.button1 = new System.Windows.Forms.Button();
            this.tangens1 = new Application.Tangens();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.panelmenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.Controls.Add(this.button2);
            this.panelmenu.Controls.Add(this.solving);
            this.panelmenu.Controls.Add(this.Exp1);
            this.panelmenu.Controls.Add(this.InfoButton);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(400, 1032);
            this.panelmenu.TabIndex = 13;
            this.panelmenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 273);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(400, 91);
            this.button2.TabIndex = 4;
            this.button2.Text = "Эксперимент №2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // solving
            // 
            this.solving.Dock = System.Windows.Forms.DockStyle.Top;
            this.solving.Location = new System.Drawing.Point(0, 182);
            this.solving.Name = "solving";
            this.solving.Size = new System.Drawing.Size(400, 91);
            this.solving.TabIndex = 2;
            this.solving.Text = "Расчеты";
            this.solving.UseVisualStyleBackColor = true;
            this.solving.Click += new System.EventHandler(this.solving_Click);
            // 
            // Exp1
            // 
            this.Exp1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exp1.Location = new System.Drawing.Point(0, 91);
            this.Exp1.Name = "Exp1";
            this.Exp1.Size = new System.Drawing.Size(400, 91);
            this.Exp1.TabIndex = 1;
            this.Exp1.Text = "Эксперимент №1";
            this.Exp1.UseVisualStyleBackColor = true;
            this.Exp1.Click += new System.EventHandler(this.Exp1_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.InfoButton.Location = new System.Drawing.Point(0, 0);
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(400, 91);
            this.InfoButton.TabIndex = 0;
            this.InfoButton.Text = "Основная информация";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Export);
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(400, 968);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2296, 64);
            this.panel2.TabIndex = 14;
            // 
            // Export
            // 
            this.Export.Dock = System.Windows.Forms.DockStyle.Left;
            this.Export.Location = new System.Drawing.Point(532, 0);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(266, 64);
            this.Export.TabIndex = 12;
            this.Export.Text = "Экспорт в HTML";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // back
            // 
            this.back.Dock = System.Windows.Forms.DockStyle.Left;
            this.back.Location = new System.Drawing.Point(266, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(266, 64);
            this.back.TabIndex = 10;
            this.back.Text = "В главное меню";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveButton.Location = new System.Drawing.Point(0, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(266, 64);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mainInfoPanel1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.force1);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.tangens1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(400, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2296, 968);
            this.panel3.TabIndex = 15;
            // 
            // mainInfoPanel1
            // 
            this.mainInfoPanel1.AimText = "";
            this.mainInfoPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.mainInfoPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainInfoPanel1.EquipmentText = "";
            this.mainInfoPanel1.Finaltext = "";
            this.mainInfoPanel1.grouptext = "";
            this.mainInfoPanel1.LabNameText = "";
            this.mainInfoPanel1.lastnametext = "";
            this.mainInfoPanel1.Location = new System.Drawing.Point(0, 0);
            this.mainInfoPanel1.Name = "mainInfoPanel1";
            this.mainInfoPanel1.nametext = "";
            this.mainInfoPanel1.Size = new System.Drawing.Size(2296, 968);
            this.mainInfoPanel1.TabIndex = 1;
            this.mainInfoPanel1.Load += new System.EventHandler(this.mainInfoPanel1_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 273);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(2265, 689);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // force1
            // 
            this.force1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.force1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.force1.Location = new System.Drawing.Point(0, 0);
            this.force1.Name = "force1";
            this.force1.Size = new System.Drawing.Size(2296, 968);
            this.force1.TabIndex = 0;
            this.force1.Load += new System.EventHandler(this.force1_Load);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1074, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(332, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "Произвести расчеты";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tangens1
            // 
            this.tangens1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.tangens1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tangens1.HeightText = null;
            this.tangens1.HeightTextPogr = null;
            this.tangens1.LengthText = null;
            this.tangens1.LengthTextPogr = null;
            this.tangens1.Location = new System.Drawing.Point(0, 0);
            this.tangens1.Name = "tangens1";
            this.tangens1.Size = new System.Drawing.Size(2296, 968);
            this.tangens1.TabIndex = 6;
            // 
            // Force_work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(2696, 1032);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelmenu);
            this.Name = "Force_work";
            this.Text = "Сила трения";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Force_work_FormClosing);
            this.Load += new System.EventHandler(this.Force_work_Load);
            this.panelmenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Button Exp1;
        private System.Windows.Forms.Button InfoButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Export;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Panel panel3;
        private Force force1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MainInfoPanel mainInfoPanel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.Button solving;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Tangens tangens1;
    }
}