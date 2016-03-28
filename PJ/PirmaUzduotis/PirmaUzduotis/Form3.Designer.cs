namespace PirmaUzduotis
{
    partial class Form3
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
            this.laukas = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laukas
            // 
            this.laukas.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laukas.Location = new System.Drawing.Point(12, 12);
            this.laukas.Multiline = true;
            this.laukas.Name = "laukas";
            this.laukas.Size = new System.Drawing.Size(170, 282);
            this.laukas.TabIndex = 0;
            this.laukas.TextChanged += new System.EventHandler(this.laukas_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Uzdaryti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 331);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.laukas);
            this.MaximumSize = new System.Drawing.Size(210, 370);
            this.MinimumSize = new System.Drawing.Size(210, 370);
            this.Name = "Form3";
            this.ShowIcon = false;
            this.Text = "Numeriai";
            this.Load += new System.EventHandler(this.loads);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox laukas;
        private System.Windows.Forms.Button button1;
    }
}