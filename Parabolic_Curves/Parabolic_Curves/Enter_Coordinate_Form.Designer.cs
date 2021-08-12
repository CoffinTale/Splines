
namespace Parabolic_Curves
{
    partial class Enter_Coordinate_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.Coordinate_number = new System.Windows.Forms.TextBox();
            this.x_coordinate = new System.Windows.Forms.TextBox();
            this.y_coordinate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Next_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Координата";
            this.label1.UseWaitCursor = true;
            // 
            // Coordinate_number
            // 
            this.Coordinate_number.Location = new System.Drawing.Point(133, 6);
            this.Coordinate_number.Name = "Coordinate_number";
            this.Coordinate_number.ReadOnly = true;
            this.Coordinate_number.Size = new System.Drawing.Size(34, 20);
            this.Coordinate_number.TabIndex = 1;
            this.Coordinate_number.Text = "1";
            this.Coordinate_number.UseWaitCursor = true;
            // 
            // x_coordinate
            // 
            this.x_coordinate.Location = new System.Drawing.Point(39, 32);
            this.x_coordinate.Name = "x_coordinate";
            this.x_coordinate.Size = new System.Drawing.Size(52, 20);
            this.x_coordinate.TabIndex = 2;
            this.x_coordinate.UseWaitCursor = true;
            this.x_coordinate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.x_coordinate_KeyDown);
            // 
            // y_coordinate
            // 
            this.y_coordinate.Location = new System.Drawing.Point(115, 32);
            this.y_coordinate.Name = "y_coordinate";
            this.y_coordinate.Size = new System.Drawing.Size(52, 20);
            this.y_coordinate.TabIndex = 3;
            this.y_coordinate.UseWaitCursor = true;
            this.y_coordinate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.y_coordinate_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "x";
            this.label2.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "y";
            this.label3.UseWaitCursor = true;
            // 
            // Next_button
            // 
            this.Next_button.Location = new System.Drawing.Point(54, 71);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(75, 23);
            this.Next_button.TabIndex = 6;
            this.Next_button.Text = "Далее";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.UseWaitCursor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // Enter_Coordinate
            // 
            this.AcceptButton = this.Next_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 106);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.y_coordinate);
            this.Controls.Add(this.x_coordinate);
            this.Controls.Add(this.Coordinate_number);
            this.Controls.Add(this.label1);
            this.Name = "Enter_Coordinate";
            this.Text = "Введите координату";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Enter_Coordinate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Coordinate_number;
        private System.Windows.Forms.TextBox x_coordinate;
        private System.Windows.Forms.TextBox y_coordinate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Next_button;
    }
}