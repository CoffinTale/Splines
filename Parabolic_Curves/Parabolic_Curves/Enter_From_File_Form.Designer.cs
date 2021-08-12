
namespace Parabolic_Curves
{
    partial class Enter_From_File_Form
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
            this.FileCoordinates = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Curve_Picture_Box = new System.Windows.Forms.PictureBox();
            this.Calculate_Curve_Button = new System.Windows.Forms.Button();
            this.Method = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Method_Time = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Curve_Picture_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // FileCoordinates
            // 
            this.FileCoordinates.Location = new System.Drawing.Point(12, 31);
            this.FileCoordinates.Multiline = true;
            this.FileCoordinates.Name = "FileCoordinates";
            this.FileCoordinates.ReadOnly = true;
            this.FileCoordinates.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FileCoordinates.Size = new System.Drawing.Size(185, 149);
            this.FileCoordinates.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Полученные координаты";
            // 
            // Curve_Picture_Box
            // 
            this.Curve_Picture_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Curve_Picture_Box.Location = new System.Drawing.Point(235, 31);
            this.Curve_Picture_Box.Name = "Curve_Picture_Box";
            this.Curve_Picture_Box.Size = new System.Drawing.Size(553, 395);
            this.Curve_Picture_Box.TabIndex = 2;
            this.Curve_Picture_Box.TabStop = false;
            // 
            // Calculate_Curve_Button
            // 
            this.Calculate_Curve_Button.Location = new System.Drawing.Point(48, 403);
            this.Calculate_Curve_Button.Name = "Calculate_Curve_Button";
            this.Calculate_Curve_Button.Size = new System.Drawing.Size(113, 23);
            this.Calculate_Curve_Button.TabIndex = 3;
            this.Calculate_Curve_Button.Text = "Расчитать кривую";
            this.Calculate_Curve_Button.UseVisualStyleBackColor = true;
            this.Calculate_Curve_Button.Click += new System.EventHandler(this.Calculate_Curve_Button_Click);
            // 
            // Method
            // 
            this.Method.FormattingEnabled = true;
            this.Method.Items.AddRange(new object[] {
            "Оверхаузер",
            "Бревер-Андерсон",
            "Лячек"});
            this.Method.Location = new System.Drawing.Point(12, 223);
            this.Method.Name = "Method";
            this.Method.Size = new System.Drawing.Size(120, 95);
            this.Method.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Выберите метод";
            // 
            // Method_Time
            // 
            this.Method_Time.Location = new System.Drawing.Point(118, 354);
            this.Method_Time.Name = "Method_Time";
            this.Method_Time.ReadOnly = true;
            this.Method_Time.Size = new System.Drawing.Size(100, 20);
            this.Method_Time.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Время выполнения";
            // 
            // Enter_From_File_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Method_Time);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Method);
            this.Controls.Add(this.Calculate_Curve_Button);
            this.Controls.Add(this.Curve_Picture_Box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileCoordinates);
            this.Name = "Enter_From_File_Form";
            this.Text = "Ввод из файла";
            this.Load += new System.EventHandler(this.Enter_From_File_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Curve_Picture_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileCoordinates;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Curve_Picture_Box;
        private System.Windows.Forms.Button Calculate_Curve_Button;
        private System.Windows.Forms.ListBox Method;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Method_Time;
        private System.Windows.Forms.Label label3;
    }
}