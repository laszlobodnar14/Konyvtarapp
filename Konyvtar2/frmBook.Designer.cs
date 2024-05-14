namespace Konyvtar2
{
    partial class frmBook
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
            this.pnNavigation = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRent = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnPublisher = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvBook = new System.Windows.Forms.DataGridView();
            this.lbid = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbPublisher = new System.Windows.Forms.Label();
            this.lbPubYear = new System.Windows.Forms.Label();
            this.lbACopy = new System.Windows.Forms.Label();
            this.lbCCopy = new System.Windows.Forms.Label();
            this.cmbPublisher = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPubYear = new System.Windows.Forms.TextBox();
            this.txtACopy = new System.Windows.Forms.TextBox();
            this.txtCCopy = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).BeginInit();
            this.SuspendLayout();
            // 
            // pnNavigation
            // 
            this.pnNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnNavigation.Controls.Add(this.btnLogOut);
            this.pnNavigation.Controls.Add(this.btnRent);
            this.pnNavigation.Controls.Add(this.btnAccount);
            this.pnNavigation.Controls.Add(this.btnPublisher);
            this.pnNavigation.Controls.Add(this.btnCategory);
            this.pnNavigation.Controls.Add(this.btnStudent);
            this.pnNavigation.Controls.Add(this.btnBook);
            this.pnNavigation.Controls.Add(this.btnhome);
            this.pnNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnNavigation.Name = "pnNavigation";
            this.pnNavigation.Size = new System.Drawing.Size(203, 669);
            this.pnNavigation.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(12, 563);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(169, 44);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnRent
            // 
            this.btnRent.Location = new System.Drawing.Point(12, 354);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(169, 44);
            this.btnRent.TabIndex = 6;
            this.btnRent.Text = "button2";
            this.btnRent.UseVisualStyleBackColor = true;
            // 
            // btnAccount
            // 
            this.btnAccount.Location = new System.Drawing.Point(12, 419);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(169, 44);
            this.btnAccount.TabIndex = 5;
            this.btnAccount.Text = "button2";
            this.btnAccount.UseVisualStyleBackColor = true;
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
            this.btnCategory.Text = "Category";
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
            this.btnhome.Click += new System.EventHandler(this.btnhome_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(243, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 17);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(371, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Konyvtar Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(243, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dgvBook
            // 
            this.dgvBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBook.Location = new System.Drawing.Point(772, 115);
            this.dgvBook.Name = "dgvBook";
            this.dgvBook.Size = new System.Drawing.Size(514, 541);
            this.dgvBook.TabIndex = 6;
            this.dgvBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBook_CellContentClick);
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbid.Location = new System.Drawing.Point(381, 115);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(30, 20);
            this.lbid.TabIndex = 7;
            this.lbid.Text = "ID:";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(371, 177);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(40, 20);
            this.lbTitle.TabIndex = 8;
            this.lbTitle.Text = "Cim:";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(337, 219);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(81, 20);
            this.lbCategory.TabIndex = 9;
            this.lbCategory.Text = "Kategoria:";
            // 
            // lbPublisher
            // 
            this.lbPublisher.AutoSize = true;
            this.lbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPublisher.Location = new System.Drawing.Point(358, 285);
            this.lbPublisher.Name = "lbPublisher";
            this.lbPublisher.Size = new System.Drawing.Size(53, 20);
            this.lbPublisher.TabIndex = 10;
            this.lbPublisher.Text = "Kiado:";
            // 
            // lbPubYear
            // 
            this.lbPubYear.AutoSize = true;
            this.lbPubYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPubYear.Location = new System.Drawing.Point(319, 346);
            this.lbPubYear.Name = "lbPubYear";
            this.lbPubYear.Size = new System.Drawing.Size(92, 20);
            this.lbPubYear.TabIndex = 11;
            this.lbPubYear.Text = "Kiadas Eve:";
            // 
            // lbACopy
            // 
            this.lbACopy.AutoSize = true;
            this.lbACopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbACopy.Location = new System.Drawing.Point(354, 414);
            this.lbACopy.Name = "lbACopy";
            this.lbACopy.Size = new System.Drawing.Size(57, 20);
            this.lbACopy.TabIndex = 12;
            this.lbACopy.Text = "Raktar";
            // 
            // lbCCopy
            // 
            this.lbCCopy.AutoSize = true;
            this.lbCCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCCopy.Location = new System.Drawing.Point(295, 474);
            this.lbCCopy.Name = "lbCCopy";
            this.lbCCopy.Size = new System.Drawing.Size(116, 20);
            this.lbCCopy.TabIndex = 13;
            this.lbCCopy.Text = "Jelenlegi raktar";
            // 
            // cmbPublisher
            // 
            this.cmbPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPublisher.FormattingEnabled = true;
            this.cmbPublisher.Location = new System.Drawing.Point(464, 282);
            this.cmbPublisher.Name = "cmbPublisher";
            this.cmbPublisher.Size = new System.Drawing.Size(255, 28);
            this.cmbPublisher.TabIndex = 15;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(464, 219);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(255, 28);
            this.cmbCategory.TabIndex = 16;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(464, 114);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(254, 26);
            this.txtID.TabIndex = 17;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(463, 177);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(254, 26);
            this.txtTitle.TabIndex = 18;
            // 
            // txtPubYear
            // 
            this.txtPubYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPubYear.Location = new System.Drawing.Point(463, 343);
            this.txtPubYear.Name = "txtPubYear";
            this.txtPubYear.Size = new System.Drawing.Size(254, 26);
            this.txtPubYear.TabIndex = 19;
            // 
            // txtACopy
            // 
            this.txtACopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtACopy.Location = new System.Drawing.Point(463, 411);
            this.txtACopy.Name = "txtACopy";
            this.txtACopy.Size = new System.Drawing.Size(254, 26);
            this.txtACopy.TabIndex = 20;
            // 
            // txtCCopy
            // 
            this.txtCCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCopy.Location = new System.Drawing.Point(463, 471);
            this.txtCCopy.Name = "txtCCopy";
            this.txtCCopy.Size = new System.Drawing.Size(254, 26);
            this.txtCCopy.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(299, 563);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 28);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(463, 563);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(93, 28);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(624, 563);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 28);
            this.btnDelete.TabIndex = 24;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1313, 668);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtCCopy);
            this.Controls.Add(this.txtACopy);
            this.Controls.Add(this.txtPubYear);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.cmbPublisher);
            this.Controls.Add(this.lbCCopy);
            this.Controls.Add(this.lbACopy);
            this.Controls.Add(this.lbPubYear);
            this.Controls.Add(this.lbPublisher);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.dgvBook);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBook";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.frmBook_Load);
            this.pnNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnNavigation;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnPublisher;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvBook;
        private System.Windows.Forms.Label lbid;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbPublisher;
        private System.Windows.Forms.Label lbPubYear;
        private System.Windows.Forms.Label lbACopy;
        private System.Windows.Forms.Label lbCCopy;
        private System.Windows.Forms.ComboBox cmbPublisher;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPubYear;
        private System.Windows.Forms.TextBox txtACopy;
        private System.Windows.Forms.TextBox txtCCopy;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
    }
}