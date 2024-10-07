namespace project_phase_1
{
    partial class deletepop
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 60);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(722, 338);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(293, 34);
            label1.Name = "label1";
            label1.Size = new Size(200, 23);
            label1.TabIndex = 1;
            label1.Text = "The List of Found Viruses";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(288, 404);
            button1.Name = "button1";
            button1.Size = new Size(205, 43);
            button1.TabIndex = 2;
            button1.Text = "Delete All";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // deletepop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 475);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            MaximizeBox = false;
            Name = "deletepop";
            Text = "deletepop";
            Load += deletepop_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
    }
}