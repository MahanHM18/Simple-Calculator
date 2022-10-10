namespace SimpleCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ResultLbl = new System.Windows.Forms.Label();
            this.SumBtn = new System.Windows.Forms.Button();
            this.MinusBtn = new System.Windows.Forms.Button();
            this.MultipleBtn = new System.Windows.Forms.Button();
            this.DivisionBtn = new System.Windows.Forms.Button();
            this.Numeric1 = new System.Windows.Forms.NumericUpDown();
            this.Numeric2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric2)).BeginInit();
            this.SuspendLayout();
            // 
            // ResultLbl
            // 
            resources.ApplyResources(this.ResultLbl, "ResultLbl");
            this.ResultLbl.Name = "ResultLbl";
            this.ResultLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // SumBtn
            // 
            resources.ApplyResources(this.SumBtn, "SumBtn");
            this.SumBtn.Name = "SumBtn";
            this.SumBtn.UseVisualStyleBackColor = true;
            this.SumBtn.Click += new System.EventHandler(this.SumBtn_Click);
            // 
            // MinusBtn
            // 
            resources.ApplyResources(this.MinusBtn, "MinusBtn");
            this.MinusBtn.Name = "MinusBtn";
            this.MinusBtn.UseVisualStyleBackColor = true;
            this.MinusBtn.Click += new System.EventHandler(this.MinusBtn_Click);
            // 
            // MultipleBtn
            // 
            resources.ApplyResources(this.MultipleBtn, "MultipleBtn");
            this.MultipleBtn.Name = "MultipleBtn";
            this.MultipleBtn.UseVisualStyleBackColor = true;
            this.MultipleBtn.Click += new System.EventHandler(this.MultipleBtn_Click);
            // 
            // DivisionBtn
            // 
            resources.ApplyResources(this.DivisionBtn, "DivisionBtn");
            this.DivisionBtn.Name = "DivisionBtn";
            this.DivisionBtn.UseVisualStyleBackColor = true;
            this.DivisionBtn.Click += new System.EventHandler(this.DivisionBtn_Click);
            // 
            // Numeric1
            // 
            this.Numeric1.DecimalPlaces = 3;
            resources.ApplyResources(this.Numeric1, "Numeric1");
            this.Numeric1.Name = "Numeric1";
            // 
            // Numeric2
            // 
            this.Numeric2.DecimalPlaces = 3;
            resources.ApplyResources(this.Numeric2, "Numeric2");
            this.Numeric2.Name = "Numeric2";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Numeric2);
            this.Controls.Add(this.Numeric1);
            this.Controls.Add(this.DivisionBtn);
            this.Controls.Add(this.MultipleBtn);
            this.Controls.Add(this.MinusBtn);
            this.Controls.Add(this.SumBtn);
            this.Controls.Add(this.ResultLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Numeric1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Numeric2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultLbl;
        private System.Windows.Forms.Button SumBtn;
        private System.Windows.Forms.Button MinusBtn;
        private System.Windows.Forms.Button MultipleBtn;
        private System.Windows.Forms.Button DivisionBtn;
        private System.Windows.Forms.NumericUpDown Numeric1;
        private System.Windows.Forms.NumericUpDown Numeric2;
    }
}

