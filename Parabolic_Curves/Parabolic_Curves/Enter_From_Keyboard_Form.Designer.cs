
namespace Parabolic_Curves
{
    partial class Enter_From_Keyboard_Form
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
            this.Coordinate_count = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Enter_Coordinates_Button = new System.Windows.Forms.Button();
            this.KeyboardCoordinates = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Curve_Picture_Box = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Method = new System.Windows.Forms.ListBox();
            this.Calculate_Curve_Button = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Method_Time = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Curve_Picture_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Coordinate_count
            // 
            this.Coordinate_count.Location = new System.Drawing.Point(165, 4);
            this.Coordinate_count.Name = "Coordinate_count";
            this.Coordinate_count.Size = new System.Drawing.Size(45, 20);
            this.Coordinate_count.TabIndex = 0;
            this.Coordinate_count.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите количество точек";
            // 
            // Enter_Coordinates_Button
            // 
            this.Enter_Coordinates_Button.Location = new System.Drawing.Point(56, 30);
            this.Enter_Coordinates_Button.Name = "Enter_Coordinates_Button";
            this.Enter_Coordinates_Button.Size = new System.Drawing.Size(116, 23);
            this.Enter_Coordinates_Button.TabIndex = 2;
            this.Enter_Coordinates_Button.Text = "Ввести координаты";
            this.Enter_Coordinates_Button.UseVisualStyleBackColor = true;
            this.Enter_Coordinates_Button.Click += new System.EventHandler(this.Enter_Coordinates_Button_Click);
            // 
            // KeyboardCoordinates
            // 
            this.KeyboardCoordinates.Location = new System.Drawing.Point(21, 90);
            this.KeyboardCoordinates.Multiline = true;
            this.KeyboardCoordinates.Name = "KeyboardCoordinates";
            this.KeyboardCoordinates.ReadOnly = true;
            this.KeyboardCoordinates.Size = new System.Drawing.Size(185, 149);
            this.KeyboardCoordinates.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Полученные координаты";
            // 
            // Curve_Picture_Box
            // 
            this.Curve_Picture_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Curve_Picture_Box.Location = new System.Drawing.Point(260, 39);
            this.Curve_Picture_Box.Name = "Curve_Picture_Box";
            this.Curve_Picture_Box.Size = new System.Drawing.Size(553, 395);
            this.Curve_Picture_Box.TabIndex = 5;
            this.Curve_Picture_Box.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Выберите метод";
            // 
            // Method
            // 
            this.Method.FormattingEnabled = true;
            this.Method.Items.AddRange(new object[] {
            "Оверхаузер",
            "Бревер-Андерсон",
            "Лячек"});
            this.Method.Location = new System.Drawing.Point(21, 282);
            this.Method.Name = "Method";
            this.Method.Size = new System.Drawing.Size(120, 95);
            this.Method.TabIndex = 6;
            // 
            // Calculate_Curve_Button
            // 
            this.Calculate_Curve_Button.Location = new System.Drawing.Point(56, 445);
            this.Calculate_Curve_Button.Name = "Calculate_Curve_Button";
            this.Calculate_Curve_Button.Size = new System.Drawing.Size(113, 23);
            this.Calculate_Curve_Button.TabIndex = 8;
            this.Calculate_Curve_Button.Text = "Расчитать кривую";
            this.Calculate_Curve_Button.UseVisualStyleBackColor = true;
            this.Calculate_Curve_Button.Click += new System.EventHandler(this.Calculate_Curve_Button_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Время выполнения";
            // 
            // Method_Time
            // 
            this.Method_Time.Location = new System.Drawing.Point(129, 402);
            this.Method_Time.Name = "Method_Time";
            this.Method_Time.ReadOnly = true;
            this.Method_Time.Size = new System.Drawing.Size(100, 20);
            this.Method_Time.TabIndex = 9;
            // 
            // Enter_From_Keyboard_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 490);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Method_Time);
            this.Controls.Add(this.Calculate_Curve_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Method);
            this.Controls.Add(this.Curve_Picture_Box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KeyboardCoordinates);
            this.Controls.Add(this.Enter_Coordinates_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Coordinate_count);
            this.Name = "Enter_From_Keyboard_Form";
            this.Text = "Ввод с клавиатуры";
            ((System.ComponentModel.ISupportInitialize)(this.Curve_Picture_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Coordinate_count;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Enter_Coordinates_Button;
        private System.Windows.Forms.TextBox KeyboardCoordinates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Curve_Picture_Box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox Method;
        private System.Windows.Forms.Button Calculate_Curve_Button;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Method_Time;
    }
}