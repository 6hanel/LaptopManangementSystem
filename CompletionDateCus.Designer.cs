
namespace GroupAssignment
{
    partial class FormPurchasesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPurchasesList));
            this.btnReturnDash = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataGridLaptopCmpAndClt = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLaptopCmpAndClt)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReturnDash
            // 
            this.btnReturnDash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturnDash.BackgroundImage")));
            this.btnReturnDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnDash.ForeColor = System.Drawing.Color.White;
            this.btnReturnDash.Location = new System.Drawing.Point(731, 563);
            this.btnReturnDash.Name = "btnReturnDash";
            this.btnReturnDash.Size = new System.Drawing.Size(209, 60);
            this.btnReturnDash.TabIndex = 109;
            this.btnReturnDash.UseVisualStyleBackColor = true;
            this.btnReturnDash.Click += new System.EventHandler(this.btnReturnDash_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(626, 46);
            this.label2.TabIndex = 107;
            this.label2.Text = "Laptop Completion and Collection Date";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 106;
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
            this.label4.TabIndex = 105;
            this.label4.Text = "FixComp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(976, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 104;
            this.pictureBox1.TabStop = false;
            // 
            // DataGridLaptopCmpAndClt
            // 
            this.DataGridLaptopCmpAndClt.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.DataGridLaptopCmpAndClt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridLaptopCmpAndClt.Location = new System.Drawing.Point(30, 185);
            this.DataGridLaptopCmpAndClt.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DataGridLaptopCmpAndClt.Name = "DataGridLaptopCmpAndClt";
            this.DataGridLaptopCmpAndClt.RowHeadersWidth = 72;
            this.DataGridLaptopCmpAndClt.Size = new System.Drawing.Size(919, 361);
            this.DataGridLaptopCmpAndClt.TabIndex = 110;
            this.DataGridLaptopCmpAndClt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridLaptopCmpAndClt_CellContentClick);
            // 
            // FormPurchasesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(976, 636);
            this.Controls.Add(this.DataGridLaptopCmpAndClt);
            this.Controls.Add(this.btnReturnDash);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPurchasesList";
            this.Text = "CompletionDate";
            this.Load += new System.EventHandler(this.FormPurchasesList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridLaptopCmpAndClt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnDash;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DataGridLaptopCmpAndClt;
    }
}