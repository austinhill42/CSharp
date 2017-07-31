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
            this.tb_rate = new System.Windows.Forms.TextBox();
            this.l_rate = new System.Windows.Forms.Label();
            this.tb_period = new System.Windows.Forms.TextBox();
            this.l_period = new System.Windows.Forms.Label();
            this.btn_done = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
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
            // tb_rate
            // 
            this.tb_rate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_rate.Location = new System.Drawing.Point(518, 47);
            this.tb_rate.Name = "tb_rate";
            this.tb_rate.Size = new System.Drawing.Size(94, 20);
            this.tb_rate.TabIndex = 6;
            // 
            // l_rate
            // 
            this.l_rate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_rate.AutoSize = true;
            this.l_rate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_rate.Location = new System.Drawing.Point(415, 48);
            this.l_rate.Name = "l_rate";
            this.l_rate.Size = new System.Drawing.Size(97, 16);
            this.l_rate.TabIndex = 5;
            this.l_rate.Text = "Interest rate %:";
            // 
            // tb_period
            // 
            this.tb_period.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_period.Location = new System.Drawing.Point(518, 80);
            this.tb_period.Name = "tb_period";
            this.tb_period.Size = new System.Drawing.Size(94, 20);
            this.tb_period.TabIndex = 8;
            // 
            // l_period
            // 
            this.l_period.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.l_period.AutoSize = true;
            this.l_period.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_period.Location = new System.Drawing.Point(433, 81);
            this.l_period.Name = "l_period";
            this.l_period.Size = new System.Drawing.Size(79, 16);
            this.l_period.TabIndex = 7;
            this.l_period.Text = "Loan period:";
            // 
            // btn_done
            // 
            this.btn_done.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_done.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_done.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btn_done.Location = new System.Drawing.Point(12, 215);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(90, 30);
            this.btn_done.TabIndex = 201;
            this.btn_done.TabStop = false;
            this.btn_done.Text = "Done";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_report
            // 
            this.btn_report.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_report.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_report.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btn_report.Location = new System.Drawing.Point(463, 215);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(149, 30);
            this.btn_report.TabIndex = 100;
            this.btn_report.TabStop = false;
            this.btn_report.Text = "Generate Report";
            this.btn_report.UseVisualStyleBackColor = true;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // Amortization_Report
            // 
            this.AcceptButton = this.btn_report;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_done;
            this.ClientSize = new System.Drawing.Size(624, 257);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.tb_period);
            this.Controls.Add(this.l_period);
            this.Controls.Add(this.tb_rate);
            this.Controls.Add(this.l_rate);
            this.Controls.Add(this.tb_downpmt);
            this.Controls.Add(this.l_downpmt);
            this.Controls.Add(this.l_cars);
            this.Controls.Add(this.cb_cars);
            this.Name = "Amortization_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
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
        private System.Windows.Forms.TextBox tb_rate;
        private System.Windows.Forms.Label l_rate;
        private System.Windows.Forms.TextBox tb_period;
        private System.Windows.Forms.Label l_period;
        private System.Windows.Forms.Button btn_done;
        private System.Windows.Forms.Button btn_report;
    }
}