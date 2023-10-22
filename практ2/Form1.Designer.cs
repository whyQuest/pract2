namespace практ2
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.одновимірнийМасивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.двовимірнийМасивToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.одновимірнийМасивToolStripMenuItem,
            this.двовимірнийМасивToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 26);
            this.toolStripMenuItem1.Text = "Виберіть...";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // одновимірнийМасивToolStripMenuItem
            // 
            this.одновимірнийМасивToolStripMenuItem.Name = "одновимірнийМасивToolStripMenuItem";
            this.одновимірнийМасивToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.одновимірнийМасивToolStripMenuItem.Text = "Одновимірний масив";
            this.одновимірнийМасивToolStripMenuItem.Click += new System.EventHandler(this.одновимірнийМасивToolStripMenuItem_Click_1);
            // 
            // двовимірнийМасивToolStripMenuItem
            // 
            this.двовимірнийМасивToolStripMenuItem.Name = "двовимірнийМасивToolStripMenuItem";
            this.двовимірнийМасивToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.двовимірнийМасивToolStripMenuItem.Text = "Двовимірний масив";
            this.двовимірнийМасивToolStripMenuItem.Click += new System.EventHandler(this.двовимірнийМасивToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem одновимірнийМасивToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem двовимірнийМасивToolStripMenuItem;
    }
}

