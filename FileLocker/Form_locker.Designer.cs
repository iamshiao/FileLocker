namespace FileLocker
{
    partial class Form_locker
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
            this.components = new System.ComponentModel.Container();
            this.textBox_path = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button_unlock = new System.Windows.Forms.Button();
            this.button_lock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_path
            // 
            this.textBox_path.Location = new System.Drawing.Point(12, 15);
            this.textBox_path.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_path.Name = "textBox_path";
            this.textBox_path.Size = new System.Drawing.Size(613, 27);
            this.textBox_path.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button_unlock
            // 
            this.button_unlock.Location = new System.Drawing.Point(550, 50);
            this.button_unlock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_unlock.Name = "button_unlock";
            this.button_unlock.Size = new System.Drawing.Size(75, 29);
            this.button_unlock.TabIndex = 2;
            this.button_unlock.Text = "unlock";
            this.button_unlock.UseVisualStyleBackColor = true;
            this.button_unlock.Click += new System.EventHandler(this.button_unlock_Click);
            // 
            // button_lock
            // 
            this.button_lock.Location = new System.Drawing.Point(12, 50);
            this.button_lock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_lock.Name = "button_lock";
            this.button_lock.Size = new System.Drawing.Size(75, 29);
            this.button_lock.TabIndex = 3;
            this.button_lock.Text = "lock";
            this.button_lock.UseVisualStyleBackColor = true;
            this.button_lock.Click += new System.EventHandler(this.button_lock_Click);
            // 
            // Form_locker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 158);
            this.Controls.Add(this.button_lock);
            this.Controls.Add(this.button_unlock);
            this.Controls.Add(this.textBox_path);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form_locker";
            this.Text = "FileLocker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_path;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button_unlock;
        private System.Windows.Forms.Button button_lock;
    }
}

