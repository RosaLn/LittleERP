namespace ExampleDataBase.Presentacion
{
    partial class Logs
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkDeleted = new System.Windows.Forms.CheckBox();
            this.checkModified = new System.Windows.Forms.CheckBox();
            this.checkInserted = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 22);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 233);
            this.textBox1.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(260, 22);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 233);
            this.vScrollBar1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter by Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter by:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 264);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // checkDeleted
            // 
            this.checkDeleted.AutoSize = true;
            this.checkDeleted.Location = new System.Drawing.Point(78, 306);
            this.checkDeleted.Name = "checkDeleted";
            this.checkDeleted.Size = new System.Drawing.Size(63, 17);
            this.checkDeleted.TabIndex = 5;
            this.checkDeleted.Text = "Deleted";
            this.checkDeleted.UseVisualStyleBackColor = true;
            // 
            // checkModified
            // 
            this.checkModified.AutoSize = true;
            this.checkModified.Location = new System.Drawing.Point(147, 306);
            this.checkModified.Name = "checkModified";
            this.checkModified.Size = new System.Drawing.Size(66, 17);
            this.checkModified.TabIndex = 6;
            this.checkModified.Text = "Modified";
            this.checkModified.UseVisualStyleBackColor = true;
            // 
            // checkInserted
            // 
            this.checkInserted.AutoSize = true;
            this.checkInserted.Location = new System.Drawing.Point(219, 306);
            this.checkInserted.Name = "checkInserted";
            this.checkInserted.Size = new System.Drawing.Size(64, 17);
            this.checkInserted.TabIndex = 7;
            this.checkInserted.Text = "Inserted";
            this.checkInserted.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(260, 329);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Logs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 359);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.checkInserted);
            this.Controls.Add(this.checkModified);
            this.Controls.Add(this.checkDeleted);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.textBox1);
            this.Name = "Logs";
            this.Text = "Logs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkDeleted;
        private System.Windows.Forms.CheckBox checkModified;
        private System.Windows.Forms.CheckBox checkInserted;
        private System.Windows.Forms.Button btnExit;
    }
}