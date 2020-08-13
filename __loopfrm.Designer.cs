using System.Windows.Forms;

namespace Interface_RADAR
{
    partial class __loopfrm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(@__loopfrm));
            this.iconClose = new System.Windows.Forms.PictureBox();
            this.iconDimin = new System.Windows.Forms.PictureBox();
            this.iconMaxim = new System.Windows.Forms.PictureBox();
            this.iconMinim = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
<<<<<<< HEAD
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
=======
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
>>>>>>> 956c7660214fb55d0c6cf0328334f03e7c9cf64e
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDimin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaxim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinim)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
<<<<<<< HEAD
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1057, 541);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
=======
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
>>>>>>> 956c7660214fb55d0c6cf0328334f03e7c9cf64e
            // iconClose
            // 
            this.iconClose.BackColor = System.Drawing.Color.Red;
            this.iconClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconClose.Image = ((System.Drawing.Image)(resources.GetObject("iconClose.Image")));
            this.iconClose.Location = new System.Drawing.Point(579, 3);
            this.iconClose.Name = "iconClose";
            this.iconClose.Size = new System.Drawing.Size(23, 23);
            this.iconClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconClose.TabIndex = 3;
            this.iconClose.TabStop = false;
            this.iconClose.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // iconDimin
            // 
            this.iconDimin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconDimin.Image = ((System.Drawing.Image)(resources.GetObject("iconDimin.Image")));
            this.iconDimin.Location = new System.Drawing.Point(521, 3);
            this.iconDimin.Name = "iconDimin";
            this.iconDimin.Size = new System.Drawing.Size(23, 23);
            this.iconDimin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconDimin.TabIndex = 4;
            this.iconDimin.TabStop = false;
            this.iconDimin.Visible = false;
            this.iconDimin.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // iconMaxim
            // 
            this.iconMaxim.BackColor = System.Drawing.Color.Lime;
            this.iconMaxim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMaxim.Image = ((System.Drawing.Image)(resources.GetObject("iconMaxim.Image")));
            this.iconMaxim.Location = new System.Drawing.Point(550, 3);
            this.iconMaxim.Name = "iconMaxim";
            this.iconMaxim.Size = new System.Drawing.Size(23, 23);
            this.iconMaxim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMaxim.TabIndex = 5;
            this.iconMaxim.TabStop = false;
            this.iconMaxim.Click += new System.EventHandler(this.iconMaxim_Click);
            // 
            // iconMinim
            // 
            this.iconMinim.BackColor = System.Drawing.Color.Lime;
            this.iconMinim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMinim.Image = ((System.Drawing.Image)(resources.GetObject("iconMinim.Image")));
            this.iconMinim.Location = new System.Drawing.Point(492, 3);
            this.iconMinim.Name = "iconMinim";
            this.iconMinim.Size = new System.Drawing.Size(23, 23);
            this.iconMinim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMinim.TabIndex = 6;
            this.iconMinim.TabStop = false;
            this.iconMinim.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.iconClose);
            this.flowLayoutPanel1.Controls.Add(this.iconMaxim);
            this.flowLayoutPanel1.Controls.Add(this.iconDimin);
            this.flowLayoutPanel1.Controls.Add(this.iconMinim);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(989, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(605, 32);
            this.flowLayoutPanel1.TabIndex = 9;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
<<<<<<< HEAD
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(250, 164);
=======
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 120);
            this.label1.TabIndex = 1;
            this.label1.Text = "79 GHz RADAR  IHM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1054, 59);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(243, 440);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(261, 81);
>>>>>>> 956c7660214fb55d0c6cf0328334f03e7c9cf64e
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1063, 552);
            this.flowLayoutPanel3.TabIndex = 11;
            this.flowLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel3_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(3, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(295, 164);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel4.Controls.Add(this.pictureBox4);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(-5, 740);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(307, 172);
            this.flowLayoutPanel4.TabIndex = 15;
            this.flowLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel4_Paint);
            // 
<<<<<<< HEAD
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 72);
            this.label1.TabIndex = 1;
            this.label1.Text = "79 GHz RADAR  IHM";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(1316, 59);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(281, 111);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel5.Controls.Add(this.label7);
            this.flowLayoutPanel5.Controls.Add(this.label8);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(1316, 219);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(281, 40);
            this.flowLayoutPanel5.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "└: Zone tolérable";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(198, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "label8";
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel6.Controls.Add(this.label4);
            this.flowLayoutPanel6.Controls.Add(this.label6);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(1316, 175);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(281, 38);
            this.flowLayoutPanel6.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = " !: Zone à risque";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel7.Controls.Add(this.label9);
            this.flowLayoutPanel7.Controls.Add(this.label10);
            this.flowLayoutPanel7.Location = new System.Drawing.Point(1316, 265);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Size = new System.Drawing.Size(281, 40);
            this.flowLayoutPanel7.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = " ■: Véhicule";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(148, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "label10";
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel8.Controls.Add(this.label11);
            this.flowLayoutPanel8.Controls.Add(this.label12);
            this.flowLayoutPanel8.Location = new System.Drawing.Point(1316, 311);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Size = new System.Drawing.Size(281, 40);
            this.flowLayoutPanel8.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = " ▲: Humain";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(128, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "label12";
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel9.Controls.Add(this.label13);
            this.flowLayoutPanel9.Controls.Add(this.label14);
            this.flowLayoutPanel9.Location = new System.Drawing.Point(1316, 357);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Size = new System.Drawing.Size(281, 40);
            this.flowLayoutPanel9.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(249, 20);
            this.label13.TabIndex = 2;
            this.label13.Text = " ○: Cible non identifié";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 20);
            this.label14.TabIndex = 3;
            this.label14.Text = "label14";
=======
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(719, 400);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
>>>>>>> 956c7660214fb55d0c6cf0328334f03e7c9cf64e
            // 
            // __loopfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.flowLayoutPanel9);
            this.Controls.Add(this.flowLayoutPanel8);
            this.Controls.Add(this.flowLayoutPanel7);
            this.Controls.Add(this.flowLayoutPanel6);
            this.Controls.Add(this.flowLayoutPanel5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "__loopfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Interface";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.@__loopfrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconDimin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMaxim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMinim)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
<<<<<<< HEAD
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
=======
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
>>>>>>> 956c7660214fb55d0c6cf0328334f03e7c9cf64e
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        

        #endregion
        private PictureBox iconClose;
        private PictureBox iconDimin;
        private PictureBox iconMaxim;
        private PictureBox iconMinim;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label2;
        private PictureBox pictureBox4;
        private FlowLayoutPanel flowLayoutPanel4;
<<<<<<< HEAD
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label3;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label7;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label4;
        private Label label6;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label label9;
        private Label label10;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label label11;
        private Label label12;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label label13;
        private Label label14;
=======
        private PictureBox pictureBox2;
>>>>>>> 956c7660214fb55d0c6cf0328334f03e7c9cf64e
    }
}

