
namespace GroupAssignment
{
    partial class ServiceRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServiceRequest));
            this.BtnSRequestMainCus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnSRequestContinueCus = new System.Windows.Forms.Button();
            this.CbSRequestMonthTech = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datagridServiceRequested = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridServiceRequested)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSRequestMainCus
            // 
            this.BtnSRequestMainCus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSRequestMainCus.BackgroundImage")));
            this.BtnSRequestMainCus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSRequestMainCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSRequestMainCus.ForeColor = System.Drawing.Color.White;
            this.BtnSRequestMainCus.Location = new System.Drawing.Point(35, 563);
            this.BtnSRequestMainCus.Name = "BtnSRequestMainCus";
            this.BtnSRequestMainCus.Size = new System.Drawing.Size(209, 61);
            this.BtnSRequestMainCus.TabIndex = 93;
            this.BtnSRequestMainCus.UseVisualStyleBackColor = true;
            this.BtnSRequestMainCus.Click += new System.EventHandler(this.BtnSRequestMainCus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(338, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(301, 46);
            this.label2.TabIndex = 91;
            this.label2.Text = "Service Requested";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 59);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 90;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(75, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 46);
            this.label4.TabIndex = 89;
            this.label4.Text = "FixComp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(976, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 88;
            this.pictureBox1.TabStop = false;
            // 
            // BtnSRequestContinueCus
            // 
            this.BtnSRequestContinueCus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSRequestContinueCus.BackgroundImage")));
            this.BtnSRequestContinueCus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSRequestContinueCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSRequestContinueCus.ForeColor = System.Drawing.Color.White;
            this.BtnSRequestContinueCus.Location = new System.Drawing.Point(808, 563);
            this.BtnSRequestContinueCus.Name = "BtnSRequestContinueCus";
            this.BtnSRequestContinueCus.Size = new System.Drawing.Size(132, 61);
            this.BtnSRequestContinueCus.TabIndex = 94;
            this.BtnSRequestContinueCus.UseVisualStyleBackColor = true;
            this.BtnSRequestContinueCus.Click += new System.EventHandler(this.BtnSRequestContinueCus_Click);
            // 
            // CbSRequestMonthTech
            // 
            this.CbSRequestMonthTech.FormattingEnabled = true;
            this.CbSRequestMonthTech.Items.AddRange(new object[] {
            "",
            "January",
            "February",
            "March ",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.CbSRequestMonthTech.Location = new System.Drawing.Point(819, 138);
            this.CbSRequestMonthTech.Name = "CbSRequestMonthTech";
            this.CbSRequestMonthTech.Size = new System.Drawing.Size(121, 29);
            this.CbSRequestMonthTech.TabIndex = 98;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(744, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 21);
            this.label3.TabIndex = 97;
            this.label3.Text = "Month:";
            // 
            // datagridServiceRequested
            // 
            this.datagridServiceRequested.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.datagridServiceRequested.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridServiceRequested.Location = new System.Drawing.Point(30, 185);
            this.datagridServiceRequested.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.datagridServiceRequested.Name = "datagridServiceRequested";
            this.datagridServiceRequested.RowHeadersWidth = 72;
            this.datagridServiceRequested.Size = new System.Drawing.Size(919, 361);
            this.datagridServiceRequested.TabIndex = 100;
            // 
            // ServiceRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 636);
            this.Controls.Add(this.datagridServiceRequested);
            this.Controls.Add(this.CbSRequestMonthTech);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnSRequestContinueCus);
            this.Controls.Add(this.BtnSRequestMainCus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ServiceRequest";
            this.Text = "Service Requested";
            this.Load += new System.EventHandler(this.ServiceRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datagridServiceRequested)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSRequestMainCus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnSRequestContinueCus;
        private System.Windows.Forms.ComboBox CbSRequestMonthTech;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView datagridServiceRequested;
    }
}