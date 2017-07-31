namespace Programming_Assignment_2
{
    partial class Amortization_Report
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
            this.cb_cars = new System.Windows.Forms.ComboBox();
            this.l_cars = new System.Windows.Forms.Label();
            this.l_downpmt = new System.Windows.Forms.Label();
            this.tb_downpmt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.l_period = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_cars
            // 
            this.cb_cars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_cars.CausesValidation = false;
            this.cb_cars.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cars.FormattingEnabled = true;
            this.cb_cars.Location = new System.Drawing.Point(100, 16);
            this.cb_cars.Name = "cb_cars";
            this.cb_cars.Size = new System.Drawing.Size(196, 21);
            this.cb_cars.TabIndex = 1;
            // 
            // l_cars
            // 
            this.l_cars.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_cars.AutoSize = true;
            this.l_cars.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_cars.Location = new System.Drawing.Point(12, 17);
            this.l_cars.Name = "l_cars";
            this.l_cars.Size = new System.Drawing.Size(82, 16);
            this.l_cars.TabIndex = 2;
            this.l_cars.Text = "Select a car:";
            // 
            // l_downpmt
            // 
            this.l_downpmt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_downpmt.AutoSize = true;
            this.l_downpmt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_downpmt.Location = new System.Drawing.Point(367, 17);
            this.l_downpmt.Name = "l_downpmt";
            this.l_downpmt.Size = new System.Drawing.Size(145, 16);
            this.l_downpmt.TabIndex = 3;
            this.l_downpmt.Text = "Down payment amount:";
            // 
            // tb_downpmt
            // 
            this.tb_downpmt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_downpmt.Location = new System.Drawing.Point(518, 16);
            this.tb_downpmt.Name = "tb_downpmt";
            this.tb_downpmt.Size = new System.Drawing.Size(94, 20);
            this.tb_downpmt.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(518, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(431, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Interest rate:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(518, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(94, 20);
            this.textBox2.TabIndex = 8;
            // 
            // l_period
            // 
            this.l_period.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_period.AutoSize = true;
            this.l_period.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_period.Location = new System.Drawing.Point(431, 81);
            this.l_period.Name = "l_period";
            this.l_period.Size = new System.Drawing.Size(79, 16);
            this.l_period.TabIndex = 7;
            this.l_period.Text = "Loan period:";
            // 
            // Amortization_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 257);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.l_period);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_downpmt);
            this.Controls.Add(this.l_downpmt);
            this.Controls.Add(this.l_cars);
            this.Controls.Add(this.cb_cars);
            this.Name = "Amortization_Report";
            this.Text = "Amortization Report";
            this.Load += new System.EventHandler(this.Amortization_Report_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_cars;
        private System.Windows.Forms.Label l_cars;
        private System.Windows.Forms.Label l_downpmt;
        private System.Windows.Forms.TextBox tb_downpmt;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label l_period;
    }
}