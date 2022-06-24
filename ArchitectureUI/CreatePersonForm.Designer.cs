namespace ArchitectureUI
{
    partial class CreatePersonForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateValue = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateValue
            // 
            this.dateValue.Location = new System.Drawing.Point(275, 160);
            this.dateValue.Name = "dateValue";
            this.dateValue.Size = new System.Drawing.Size(250, 27);
            this.dateValue.TabIndex = 1;
            this.dateValue.Value = new System.DateTime(2000, 1, 1, 11, 0, 0, 0);
            // 
            // CreatePersonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateValue);
            this.Controls.Add(this.button1);
            this.Name = "CreatePersonForm";
            this.Text = "CreatePersonForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private DateTimePicker dateValue;
    }
}