
namespace Parabolic_Curves
{
    partial class Parabolic_Curves_Main_Form
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parabolic_Curves_Main_Form));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.Enter_from_file = new System.Windows.Forms.ToolStripMenuItem();
            this.Enter_from_keyboard = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu
            // 
            this.Menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Enter_from_file,
            this.Enter_from_keyboard,
            this.Exit});
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(53, 20);
            this.Menu.Text = "Меню";
            // 
            // Enter_from_file
            // 
            this.Enter_from_file.Name = "Enter_from_file";
            this.Enter_from_file.Size = new System.Drawing.Size(177, 22);
            this.Enter_from_file.Text = "Ввод из файла";
            this.Enter_from_file.Click += new System.EventHandler(this.Enter_from_file_Click);
            // 
            // Enter_from_keyboard
            // 
            this.Enter_from_keyboard.Name = "Enter_from_keyboard";
            this.Enter_from_keyboard.Size = new System.Drawing.Size(177, 22);
            this.Enter_from_keyboard.Text = "Ввод с клавиатуры";
            this.Enter_from_keyboard.Click += new System.EventHandler(this.Enter_from_keyboard_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(177, 22);
            this.Exit.Text = "Выход";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Parabolic_Curves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(654, 436);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Parabolic_Curves";
            this.Text = "Параболические сплайны";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Menu;
        private System.Windows.Forms.ToolStripMenuItem Enter_from_file;
        private System.Windows.Forms.ToolStripMenuItem Enter_from_keyboard;
        private System.Windows.Forms.ToolStripMenuItem Exit;
    }
}

