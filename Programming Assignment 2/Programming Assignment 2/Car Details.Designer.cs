namespace Programming_Assignment_2
{
    partial class Car_Details
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
            this.cb_makes = new System.Windows.Forms.ComboBox();
            this.l_make = new System.Windows.Forms.Label();
            this.l_model = new System.Windows.Forms.Label();
            this.cb_models = new System.Windows.Forms.ComboBox();
            this.l_price = new System.Windows.Forms.Label();
            this.l_mpg = new System.Windows.Forms.Label();
            this.l_city = new System.Windows.Forms.Label();
            this.l_highway = new System.Windows.Forms.Label();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_city = new System.Windows.Forms.TextBox();
            this.tb_highway = new System.Windows.Forms.TextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.l_number = new System.Windows.Forms.Label();
            this.l_counter = new System.Windows.Forms.Label();
            this.btn_prev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cb_makes
            // 
            this.cb_makes.FormattingEnabled = true;
            this.cb_makes.Location = new System.Drawing.Point(99, 69);
            this.cb_makes.Name = "cb_makes";
            this.cb_makes.Size = new System.Drawing.Size(126, 21);
            this.cb_makes.TabIndex = 0;
            this.cb_makes.SelectedIndexChanged += new System.EventHandler(this.cb_makes_SelectedIndexChanged);
            // 
            // l_make
            // 
            this.l_make.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_make.AutoSize = true;
            this.l_make.Font = new System.Drawing.Font("Arial", 9.75F);
            this.l_make.Location = new System.Drawing.Point(37, 70);
            this.l_make.Name = "l_make";
            this.l_make.Size = new System.Drawing.Size(48, 16);
            this.l_make.TabIndex = 1;
            this.l_make.Text = "Make: ";
            // 
            // l_model
            // 
            this.l_model.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_model.AutoSize = true;
            this.l_model.Enabled = false;
            this.l_model.Font = new System.Drawing.Font("Arial", 9.75F);
            this.l_model.Location = new System.Drawing.Point(37, 120);
            this.l_model.Name = "l_model";
            this.l_model.Size = new System.Drawing.Size(51, 16);
            this.l_model.TabIndex = 2;
            this.l_model.Text = "Model: ";
            // 
            // cb_models
            // 
            this.cb_models.Enabled = false;
            this.cb_models.FormattingEnabled = true;
            this.cb_models.Location = new System.Drawing.Point(99, 119);
            this.cb_models.Name = "cb_models";
            this.cb_models.Size = new System.Drawing.Size(126, 21);
            this.cb_models.TabIndex = 1;
            // 
            // l_price
            // 
            this.l_price.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_price.AutoSize = true;
            this.l_price.Font = new System.Drawing.Font("Arial", 9.75F);
            this.l_price.Location = new System.Drawing.Point(259, 70);
            this.l_price.Name = "l_price";
            this.l_price.Size = new System.Drawing.Size(80, 16);
            this.l_price.TabIndex = 4;
            this.l_price.Text = "Initial Price: ";
            // 
            // l_mpg
            // 
            this.l_mpg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_mpg.AutoSize = true;
            this.l_mpg.Font = new System.Drawing.Font("Arial", 9.75F);
            this.l_mpg.Location = new System.Drawing.Point(259, 120);
            this.l_mpg.Name = "l_mpg";
            this.l_mpg.Size = new System.Drawing.Size(46, 16);
            this.l_mpg.TabIndex = 5;
            this.l_mpg.Text = "MPG: ";
            // 
            // l_city
            // 
            this.l_city.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_city.AutoSize = true;
            this.l_city.Font = new System.Drawing.Font("Arial", 9.75F);
            this.l_city.Location = new System.Drawing.Point(336, 150);
            this.l_city.Name = "l_city";
            this.l_city.Size = new System.Drawing.Size(39, 16);
            this.l_city.TabIndex = 6;
            this.l_city.Text = "City: ";
            // 
            // l_highway
            // 
            this.l_highway.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_highway.AutoSize = true;
            this.l_highway.Font = new System.Drawing.Font("Arial", 9.75F);
            this.l_highway.Location = new System.Drawing.Point(310, 120);
            this.l_highway.Name = "l_highway";
            this.l_highway.Size = new System.Drawing.Size(65, 16);
            this.l_highway.TabIndex = 7;
            this.l_highway.Text = "Highway: ";
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(353, 69);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(94, 20);
            this.tb_price.TabIndex = 2;
            // 
            // tb_city
            // 
            this.tb_city.Location = new System.Drawing.Point(389, 149);
            this.tb_city.Name = "tb_city";
            this.tb_city.Size = new System.Drawing.Size(58, 20);
            this.tb_city.TabIndex = 4;
            // 
            // tb_highway
            // 
            this.tb_highway.Location = new System.Drawing.Point(389, 119);
            this.tb_highway.Name = "tb_highway";
            this.tb_highway.Size = new System.Drawing.Size(58, 20);
            this.tb_highway.TabIndex = 3;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btn_cancel.Location = new System.Drawing.Point(12, 203);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(83, 30);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_next
            // 
            this.btn_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_next.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btn_next.Location = new System.Drawing.Point(383, 203);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(83, 30);
            this.btn_next.TabIndex = 5;
            this.btn_next.Text = "Next Car";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // l_number
            // 
            this.l_number.AutoSize = true;
            this.l_number.Font = new System.Drawing.Font("Arial", 12F);
            this.l_number.Location = new System.Drawing.Point(37, 20);
            this.l_number.Name = "l_number";
            this.l_number.Size = new System.Drawing.Size(98, 18);
            this.l_number.TabIndex = 105;
            this.l_number.Text = "Car number: ";
            // 
            // l_counter
            // 
            this.l_counter.AutoSize = true;
            this.l_counter.Font = new System.Drawing.Font("Arial", 12F);
            this.l_counter.Location = new System.Drawing.Point(141, 20);
            this.l_counter.Name = "l_counter";
            this.l_counter.Size = new System.Drawing.Size(17, 18);
            this.l_counter.TabIndex = 106;
            this.l_counter.Text = "1";
            // 
            // btn_prev
            // 
            this.btn_prev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_prev.Enabled = false;
            this.btn_prev.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btn_prev.Location = new System.Drawing.Point(245, 203);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(94, 30);
            this.btn_prev.TabIndex = 6;
            this.btn_prev.Text = "Previous Car";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.b_prev_Click);
            // 
            // Car_Details
            // 
            this.AcceptButton = this.btn_next;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(478, 245);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.l_counter);
            this.Controls.Add(this.l_number);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.tb_highway);
            this.Controls.Add(this.tb_city);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.l_highway);
            this.Controls.Add(this.l_city);
            this.Controls.Add(this.l_mpg);
            this.Controls.Add(this.l_price);
            this.Controls.Add(this.cb_models);
            this.Controls.Add(this.l_model);
            this.Controls.Add(this.l_make);
            this.Controls.Add(this.cb_makes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Car_Details";
            this.Text = "Car Details";
            this.Load += new System.EventHandler(this.Car_Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_makes;
        private System.Windows.Forms.Label l_make;
        private System.Windows.Forms.Label l_model;
        private System.Windows.Forms.ComboBox cb_models;
        private System.Windows.Forms.Label l_price;
        private System.Windows.Forms.Label l_mpg;
        private System.Windows.Forms.Label l_city;
        private System.Windows.Forms.Label l_highway;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_city;
        private System.Windows.Forms.TextBox tb_highway;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Label l_number;
        private System.Windows.Forms.Label l_counter;
        private System.Windows.Forms.Button btn_prev;
    }
}