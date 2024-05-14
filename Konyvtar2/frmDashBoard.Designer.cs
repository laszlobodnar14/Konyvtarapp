namespace Konyvtar2
{
    partial class frmDashBoard
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
            this.btnhome = new System.Windows.Forms.Button();
            this.pnNavigation = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnPublisher = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnTotalStudents = new System.Windows.Forms.Panel();
            this.lblTotalStudent = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnCategoriak = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnKiadok = new System.Windows.Forms.Panel();
            this.lbKiadok = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnKonyv = new System.Windows.Forms.Panel();
            this.lbKonyvek = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnTotalStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pnCategoriak.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnKiadok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnKonyv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // btnhome
            // 
            this.btnhome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhome.Location = new System.Drawing.Point(12, 10);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(170, 43);
            this.btnhome.TabIndex = 0;
            this.btnhome.Text = "Home";
            this.btnhome.UseVisualStyleBackColor = true;
            this.btnhome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnNavigation
            // 
            this.pnNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnNavigation.Controls.Add(this.btnLogOut);
            this.pnNavigation.Controls.Add(this.btnPublisher);
            this.pnNavigation.Controls.Add(this.btnCategory);
            this.pnNavigation.Controls.Add(this.btnStudent);
            this.pnNavigation.Controls.Add(this.btnBook);
            this.pnNavigation.Controls.Add(this.btnhome);
            this.pnNavigation.Location = new System.Drawing.Point(0, 2);
            this.pnNavigation.Name = "pnNavigation";
            this.pnNavigation.Size = new System.Drawing.Size(200, 562);
            this.pnNavigation.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(12, 490);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(169, 44);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnPublisher
            // 
            this.btnPublisher.Location = new System.Drawing.Point(12, 290);
            this.btnPublisher.Name = "btnPublisher";
            this.btnPublisher.Size = new System.Drawing.Size(169, 44);
            this.btnPublisher.TabIndex = 4;
            this.btnPublisher.Text = "Publisher";
            this.btnPublisher.UseVisualStyleBackColor = true;
            this.btnPublisher.Click += new System.EventHandler(this.btnPublisher_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(12, 222);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(169, 44);
            this.btnCategory.TabIndex = 3;
            this.btnCategory.Text = "Categoty";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(14, 153);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(169, 44);
            this.btnStudent.TabIndex = 2;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(12, 80);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(169, 44);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Books";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(206, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 17);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(206, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Konyvtar Management System";
            // 
            // pnTotalStudents
            // 
            this.pnTotalStudents.Controls.Add(this.lblTotalStudent);
            this.pnTotalStudents.Controls.Add(this.pictureBox2);
            this.pnTotalStudents.Location = new System.Drawing.Point(218, 99);
            this.pnTotalStudents.Name = "pnTotalStudents";
            this.pnTotalStudents.Size = new System.Drawing.Size(257, 100);
            this.pnTotalStudents.TabIndex = 4;
            // 
            // lblTotalStudent
            // 
            this.lblTotalStudent.AutoSize = true;
            this.lblTotalStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudent.Location = new System.Drawing.Point(106, 72);
            this.lblTotalStudent.Name = "lblTotalStudent";
            this.lblTotalStudent.Size = new System.Drawing.Size(69, 20);
            this.lblTotalStudent.TabIndex = 1;
            this.lblTotalStudent.Text = "Tanulok:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnCategoriak
            // 
            this.pnCategoriak.Controls.Add(this.lblCategory);
            this.pnCategoriak.Controls.Add(this.pictureBox3);
            this.pnCategoriak.Location = new System.Drawing.Point(699, 99);
            this.pnCategoriak.Name = "pnCategoriak";
            this.pnCategoriak.Size = new System.Drawing.Size(257, 100);
            this.pnCategoriak.TabIndex = 5;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(106, 72);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(89, 20);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Kategoriak:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pnKiadok
            // 
            this.pnKiadok.Controls.Add(this.lbKiadok);
            this.pnKiadok.Controls.Add(this.pictureBox4);
            this.pnKiadok.Location = new System.Drawing.Point(218, 332);
            this.pnKiadok.Name = "pnKiadok";
            this.pnKiadok.Size = new System.Drawing.Size(257, 100);
            this.pnKiadok.TabIndex = 6;
            // 
            // lbKiadok
            // 
            this.lbKiadok.AutoSize = true;
            this.lbKiadok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKiadok.Location = new System.Drawing.Point(106, 72);
            this.lbKiadok.Name = "lbKiadok";
            this.lbKiadok.Size = new System.Drawing.Size(61, 20);
            this.lbKiadok.TabIndex = 1;
            this.lbKiadok.Text = "Kiadok:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pnKonyv
            // 
            this.pnKonyv.Controls.Add(this.lbKonyvek);
            this.pnKonyv.Controls.Add(this.pictureBox5);
            this.pnKonyv.Location = new System.Drawing.Point(699, 332);
            this.pnKonyv.Name = "pnKonyv";
            this.pnKonyv.Size = new System.Drawing.Size(257, 100);
            this.pnKonyv.TabIndex = 6;
            // 
            // lbKonyvek
            // 
            this.lbKonyvek.AutoSize = true;
            this.lbKonyvek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKonyvek.Location = new System.Drawing.Point(106, 72);
            this.lbKonyvek.Name = "lbKonyvek";
            this.lbKonyvek.Size = new System.Drawing.Size(68, 20);
            this.lbKonyvek.TabIndex = 1;
            this.lbKonyvek.Text = "Konyvek";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox5.Location = new System.Drawing.Point(0, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 100);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 564);
            this.Controls.Add(this.pnKonyv);
            this.Controls.Add(this.pnKiadok);
            this.Controls.Add(this.pnCategoriak);
            this.Controls.Add(this.pnTotalStudents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnNavigation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.pnNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnTotalStudents.ResumeLayout(false);
            this.pnTotalStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pnCategoriak.ResumeLayout(false);
            this.pnCategoriak.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnKiadok.ResumeLayout(false);
            this.pnKiadok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnKonyv.ResumeLayout(false);
            this.pnKonyv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnNavigation;
        private System.Windows.Forms.Button btnPublisher;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnTotalStudents;
        private System.Windows.Forms.Label lblTotalStudent;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnCategoriak;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnKiadok;
        private System.Windows.Forms.Label lbKiadok;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pnKonyv;
        private System.Windows.Forms.Label lbKonyvek;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btnhome;
    }
}