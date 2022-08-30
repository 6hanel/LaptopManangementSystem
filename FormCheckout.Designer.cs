
namespace GroupAssignment
{
    partial class FormCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckout));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RtxtOrders = new System.Windows.Forms.RichTextBox();
            this.BtnRmvsrvc = new System.Windows.Forms.Button();
            this.radAgreed = new System.Windows.Forms.RadioButton();
            this.LblDsptotal = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnConfirmpay = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RtxtOrders);
            this.groupBox1.Controls.Add(this.BtnRmvsrvc);
            this.groupBox1.Controls.Add(this.radAgreed);
            this.groupBox1.Controls.Add(this.LblDsptotal);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.BtnConfirmpay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(29, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 584);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 44);
            this.label1.TabIndex = 21;
            this.label1.Text = "Checkout";
            // 
            // RtxtOrders
            // 
            this.RtxtOrders.Location = new System.Drawing.Point(50, 79);
            this.RtxtOrders.Name = "RtxtOrders";
            this.RtxtOrders.Size = new System.Drawing.Size(712, 263);
            this.RtxtOrders.TabIndex = 28;
            this.RtxtOrders.Text = "";
            this.RtxtOrders.TextChanged += new System.EventHandler(this.RtxtOrders_TextChanged_1);
            // 
            // BtnRmvsrvc
            // 
            this.BtnRmvsrvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRmvsrvc.Location = new System.Drawing.Point(50, 506);
            this.BtnRmvsrvc.Name = "BtnRmvsrvc";
            this.BtnRmvsrvc.Size = new System.Drawing.Size(212, 41);
            this.BtnRmvsrvc.TabIndex = 27;
            this.BtnRmvsrvc.Text = "Remove Service";
            this.BtnRmvsrvc.UseVisualStyleBackColor = true;
            this.BtnRmvsrvc.Click += new System.EventHandler(this.BtnRmvsrvc_Click_1);
            // 
            // radAgreed
            // 
            this.radAgreed.AutoSize = true;
            this.radAgreed.Location = new System.Drawing.Point(50, 439);
            this.radAgreed.Name = "radAgreed";
            this.radAgreed.Size = new System.Drawing.Size(528, 34);
            this.radAgreed.TabIndex = 26;
            this.radAgreed.TabStop = true;
            this.radAgreed.Text = "I have agreed with all terms and conditions.";
            this.radAgreed.UseVisualStyleBackColor = true;
            this.radAgreed.CheckedChanged += new System.EventHandler(this.radAgreed_CheckedChanged);
            // 
            // LblDsptotal
            // 
            this.LblDsptotal.AutoSize = true;
            this.LblDsptotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblDsptotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDsptotal.Location = new System.Drawing.Point(710, 371);
            this.LblDsptotal.Name = "LblDsptotal";
            this.LblDsptotal.Size = new System.Drawing.Size(2, 32);
            this.LblDsptotal.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(45, 371);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 30);
            this.label9.TabIndex = 17;
            this.label9.Text = "Total:";
            // 
            // BtnConfirmpay
            // 
            this.BtnConfirmpay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmpay.Location = new System.Drawing.Point(550, 506);
            this.BtnConfirmpay.Name = "BtnConfirmpay";
            this.BtnConfirmpay.Size = new System.Drawing.Size(212, 41);
            this.BtnConfirmpay.TabIndex = 5;
            this.BtnConfirmpay.Text = "Proceed Payment";
            this.BtnConfirmpay.UseVisualStyleBackColor = true;
            this.BtnConfirmpay.Click += new System.EventHandler(this.BtnConfirmpay_Click_1);
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
            this.pictureBox3.TabIndex = 89;
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(75, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 46);
            this.label5.TabIndex = 88;
            this.label5.Text = "FixComp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(866, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 87;
            this.pictureBox1.TabStop = false;
            // 
            // FormCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 690);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormCheckout";
            this.Text = "Checkout";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox RtxtOrders;
        private System.Windows.Forms.Button BtnRmvsrvc;
        private System.Windows.Forms.RadioButton radAgreed;
        private System.Windows.Forms.Label LblDsptotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnConfirmpay;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}