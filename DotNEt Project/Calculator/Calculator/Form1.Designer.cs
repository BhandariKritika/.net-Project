namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            n7 = new Button();
            n8 = new Button();
            n9 = new Button();
            ndivide = new Button();
            nAC = new Button();
            n4 = new Button();
            n5 = new Button();
            n6 = new Button();
            nmulti = new Button();
            nC = new Button();
            n1 = new Button();
            n2 = new Button();
            n3 = new Button();
            nadd = new Button();
            nequal = new Button();
            n0 = new Button();
            ndecimal = new Button();
            nminus = new Button();
            textBox = new TextBox();
            lcurrentop = new Label();
            SuspendLayout();
            // 
            // n7
            // 
            n7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            n7.Location = new Point(12, 166);
            n7.Name = "n7";
            n7.Size = new Size(71, 60);
            n7.TabIndex = 0;
            n7.Text = "7";
            n7.UseVisualStyleBackColor = true;
            n7.Click += n_Click;
            // 
            // n8
            // 
            n8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            n8.Location = new Point(89, 166);
            n8.Name = "n8";
            n8.Size = new Size(71, 60);
            n8.TabIndex = 0;
            n8.Text = "8";
            n8.UseVisualStyleBackColor = true;
            n8.Click += n_Click;
            // 
            // n9
            // 
            n9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            n9.Location = new Point(166, 166);
            n9.Name = "n9";
            n9.Size = new Size(71, 60);
            n9.TabIndex = 0;
            n9.Text = "9";
            n9.UseVisualStyleBackColor = true;
            n9.Click += n_Click;
            // 
            // ndivide
            // 
            ndivide.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ndivide.Location = new Point(243, 166);
            ndivide.Name = "ndivide";
            ndivide.Size = new Size(71, 60);
            ndivide.TabIndex = 0;
            ndivide.Text = "/";
            ndivide.UseVisualStyleBackColor = true;
            ndivide.Click += op_Click;
            // 
            // nAC
            // 
            nAC.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nAC.Location = new Point(334, 166);
            nAC.Name = "nAC";
            nAC.Size = new Size(71, 60);
            nAC.TabIndex = 0;
            nAC.Text = "AC";
            nAC.UseVisualStyleBackColor = true;
            nAC.Click += nAC_Click;
            // 
            // n4
            // 
            n4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            n4.Location = new Point(12, 242);
            n4.Name = "n4";
            n4.Size = new Size(71, 60);
            n4.TabIndex = 0;
            n4.Text = "4";
            n4.UseVisualStyleBackColor = true;
            n4.Click += n_Click;
            n4.MouseCaptureChanged += button5_Click;
            // 
            // n5
            // 
            n5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            n5.Location = new Point(89, 242);
            n5.Name = "n5";
            n5.Size = new Size(71, 60);
            n5.TabIndex = 0;
            n5.Text = "5";
            n5.UseVisualStyleBackColor = true;
            n5.Click += n_Click;
            // 
            // n6
            // 
            n6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            n6.Location = new Point(166, 242);
            n6.Name = "n6";
            n6.Size = new Size(71, 60);
            n6.TabIndex = 0;
            n6.Text = "6";
            n6.UseVisualStyleBackColor = true;
            n6.Click += n_Click;
            // 
            // nmulti
            // 
            nmulti.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nmulti.Location = new Point(243, 242);
            nmulti.Name = "nmulti";
            nmulti.Size = new Size(71, 60);
            nmulti.TabIndex = 0;
            nmulti.Text = "*";
            nmulti.UseVisualStyleBackColor = true;
            nmulti.Click += op_Click;
            // 
            // nC
            // 
            nC.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nC.Location = new Point(334, 242);
            nC.Name = "nC";
            nC.Size = new Size(71, 60);
            nC.TabIndex = 0;
            nC.Text = "C";
            nC.UseVisualStyleBackColor = true;
            nC.Click += nC_Click;
            // 
            // n1
            // 
            n1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            n1.Location = new Point(12, 321);
            n1.Name = "n1";
            n1.Size = new Size(71, 60);
            n1.TabIndex = 0;
            n1.Text = "1";
            n1.UseVisualStyleBackColor = true;
            n1.Click += n_Click;
            // 
            // n2
            // 
            n2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            n2.Location = new Point(89, 321);
            n2.Name = "n2";
            n2.Size = new Size(71, 60);
            n2.TabIndex = 0;
            n2.Text = "2";
            n2.UseVisualStyleBackColor = true;
            n2.Click += n_Click;
            // 
            // n3
            // 
            n3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            n3.Location = new Point(166, 321);
            n3.Name = "n3";
            n3.Size = new Size(71, 60);
            n3.TabIndex = 0;
            n3.Text = "3";
            n3.UseVisualStyleBackColor = true;
            n3.Click += n_Click;
            // 
            // nadd
            // 
            nadd.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nadd.Location = new Point(243, 319);
            nadd.Name = "nadd";
            nadd.Size = new Size(71, 60);
            nadd.TabIndex = 0;
            nadd.Text = "+";
            nadd.UseVisualStyleBackColor = true;
            nadd.Click += op_Click;
            // 
            // nequal
            // 
            nequal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nequal.Location = new Point(334, 321);
            nequal.Name = "nequal";
            nequal.Size = new Size(71, 142);
            nequal.TabIndex = 0;
            nequal.Text = "=";
            nequal.UseVisualStyleBackColor = true;
            nequal.Click += nequal_Click;
            // 
            // n0
            // 
            n0.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            n0.Location = new Point(12, 403);
            n0.Name = "n0";
            n0.Size = new Size(148, 60);
            n0.TabIndex = 0;
            n0.Text = "0";
            n0.UseVisualStyleBackColor = true;
            n0.Click += n_Click;
            // 
            // ndecimal
            // 
            ndecimal.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            ndecimal.Location = new Point(166, 403);
            ndecimal.Name = "ndecimal";
            ndecimal.Size = new Size(71, 60);
            ndecimal.TabIndex = 0;
            ndecimal.Text = ".";
            ndecimal.UseVisualStyleBackColor = true;
            ndecimal.Click += n_Click;
            // 
            // nminus
            // 
            nminus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            nminus.Location = new Point(243, 403);
            nminus.Name = "nminus";
            nminus.Size = new Size(71, 60);
            nminus.TabIndex = 0;
            nminus.Text = "-";
            nminus.UseVisualStyleBackColor = true;
            nminus.Click += op_Click;
            // 
            // textBox
            // 
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            textBox.Location = new Point(12, 101);
            textBox.MaximumSize = new Size(705, 35);
            textBox.MaxLength = 32769;
            textBox.Name = "textBox";
            textBox.Size = new Size(393, 35);
            textBox.TabIndex = 1;
            textBox.Text = "0";
            textBox.TextAlign = HorizontalAlignment.Right;
            // 
            // lcurrentop
            // 
            lcurrentop.AutoSize = true;
            lcurrentop.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lcurrentop.ForeColor = SystemColors.GrayText;
            lcurrentop.Location = new Point(24, 57);
            lcurrentop.Name = "lcurrentop";
            lcurrentop.Size = new Size(0, 32);
            lcurrentop.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(417, 490);
            Controls.Add(lcurrentop);
            Controls.Add(textBox);
            Controls.Add(nequal);
            Controls.Add(nC);
            Controls.Add(nAC);
            Controls.Add(nminus);
            Controls.Add(ndecimal);
            Controls.Add(nadd);
            Controls.Add(n3);
            Controls.Add(nmulti);
            Controls.Add(n6);
            Controls.Add(n2);
            Controls.Add(ndivide);
            Controls.Add(n0);
            Controls.Add(n5);
            Controls.Add(n1);
            Controls.Add(n9);
            Controls.Add(n4);
            Controls.Add(n8);
            Controls.Add(n7);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button n7;
        private Button n8;
        private Button n9;
        private Button ndivide;
        private Button nAC;
        private Button n4;
        private Button n5;
        private Button n6;
        private Button nmulti;
        private Button nC;
        private Button n1;
        private Button n2;
        private Button n3;
        private Button nadd;
        private Button nequal;
        private Button n0;
        private Button ndecimal;
        private Button nminus;
        private TextBox textBox;
        private Label lcurrentop;
    }
}