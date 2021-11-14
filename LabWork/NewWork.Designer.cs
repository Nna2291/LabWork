using System.Windows.Forms;
namespace LabWork
{
    partial class NewWork
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SaveButton = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.SavwAs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exp1 = new System.Windows.Forms.Button();
            this.InfoButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Export = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mainInfoPanel1 = new MainInfoPanel();
            this.experiment1 = new Force();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveButton.Location = new System.Drawing.Point(266, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(266, 64);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // back
            // 
            this.back.Dock = System.Windows.Forms.DockStyle.Left;
            this.back.Location = new System.Drawing.Point(532, 0);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(266, 64);
            this.back.TabIndex = 10;
            this.back.Text = "В главное меню";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // SavwAs
            // 
            this.SavwAs.Dock = System.Windows.Forms.DockStyle.Left;
            this.SavwAs.Location = new System.Drawing.Point(0, 0);
            this.SavwAs.Name = "SavwAs";
            this.SavwAs.Size = new System.Drawing.Size(266, 64);
            this.SavwAs.TabIndex = 11;
            this.SavwAs.Text = "Сохранить как";
            this.SavwAs.UseVisualStyleBackColor = true;
            this.SavwAs.Click += new System.EventHandler(this.SavwAs_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Exp1);
            this.panel1.Controls.Add(this.InfoButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 939);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Exp1
            // 
            this.Exp1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Exp1.Location = new System.Drawing.Point(0, 91);
            this.Exp1.Name = "Exp1";
            this.Exp1.Size = new System.Drawing.Size(400, 91);
            this.Exp1.TabIndex = 1;
            this.Exp1.Text = "Лабораторная работа на динамику";
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
            this.InfoButton.Text = "Титульный лист";
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Export);
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Controls.Add(this.SavwAs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(400, 875);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2244, 64);
            this.panel2.TabIndex = 13;
            // 
            // Export
            // 
            this.Export.Dock = System.Windows.Forms.DockStyle.Left;
            this.Export.Location = new System.Drawing.Point(798, 0);
            this.Export.Name = "Export";
            this.Export.Size = new System.Drawing.Size(266, 64);
            this.Export.TabIndex = 12;
            this.Export.Text = "Экспорт в pdf";
            this.Export.UseVisualStyleBackColor = true;
            this.Export.Click += new System.EventHandler(this.Export_Click);
            // 
            // mainInfoPanel1
            // 
            this.mainInfoPanel1.AimText = "";
            this.mainInfoPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.mainInfoPanel1.EquipmentText = "";
            this.mainInfoPanel1.grouptext = "";
            this.mainInfoPanel1.LabNameText = "";
            this.mainInfoPanel1.lastnametext = "";
            this.mainInfoPanel1.Location = new System.Drawing.Point(406, -18);
            this.mainInfoPanel1.Name = "mainInfoPanel1";
            this.mainInfoPanel1.nametext = "";
            this.mainInfoPanel1.Size = new System.Drawing.Size(2244, 869);
            this.mainInfoPanel1.TabIndex = 14;
            // 
            // experiment1
            // 
            this.experiment1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.experiment1.Location = new System.Drawing.Point(400, 0);
            this.experiment1.Name = "experiment1";
            this.experiment1.Size = new System.Drawing.Size(2241, 880);
            this.experiment1.TabIndex = 15;
            this.experiment1.Load += new System.EventHandler(this.experiment1_Load_1);
            // 
            // NewWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(2644, 939);
            this.Controls.Add(this.experiment1);
            this.Controls.Add(this.mainInfoPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewWork";
            this.Text = "NewWork";
            this.Load += new System.EventHandler(this.NewWork_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private Button SaveButton;
        private Button back;
        private Button SavwAs;
        private Panel panel1;
        private Button Exp1;
        private Button InfoButton;
        private Panel panel2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MainInfoPanel mainInfoPanel1;
        private Button Export;
        private Force experiment1;
        private SaveFileDialog saveFileDialog2;
    }
}