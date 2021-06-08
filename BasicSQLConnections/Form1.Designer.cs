
namespace BasicSQLConnections
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.description = new System.Windows.Forms.Label();
            this.picture = new System.Windows.Forms.Label();
            this.categoryName = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgCategories = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 214);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(133, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 29);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(268, 214);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(304, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(39, 34);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "+";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Location = new System.Drawing.Point(12, 44);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(85, 20);
            this.description.TabIndex = 5;
            this.description.Text = "Description";
            // 
            // picture
            // 
            this.picture.AutoSize = true;
            this.picture.Location = new System.Drawing.Point(12, 91);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(54, 20);
            this.picture.TabIndex = 6;
            this.picture.Text = "Picture";
            // 
            // categoryName
            // 
            this.categoryName.AutoSize = true;
            this.categoryName.Location = new System.Drawing.Point(12, 9);
            this.categoryName.Name = "categoryName";
            this.categoryName.Size = new System.Drawing.Size(113, 20);
            this.categoryName.TabIndex = 7;
            this.categoryName.Text = "Category Name";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(131, 4);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(167, 27);
            this.txtCategoryName.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(131, 37);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(167, 27);
            this.txtDescription.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(131, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 113);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dgCategories
            // 
            this.dgCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategories.Location = new System.Drawing.Point(12, 270);
            this.dgCategories.Name = "dgCategories";
            this.dgCategories.RowHeadersWidth = 51;
            this.dgCategories.RowTemplate.Height = 29;
            this.dgCategories.Size = new System.Drawing.Size(651, 333);
            this.dgCategories.TabIndex = 12;
            this.dgCategories.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCategories_CellEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 605);
            this.Controls.Add(this.dgCategories);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.categoryName);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.description);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Name = "Form1";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label picture;
        private System.Windows.Forms.Label categoryName;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgCategories;
    }
}

