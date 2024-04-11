namespace QLBH
{
    partial class frm_category
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
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.txt_cate_name = new System.Windows.Forms.TextBox();
            this.lbl_cate_name = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhậpDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thểLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_category
            // 
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Location = new System.Drawing.Point(289, 164);
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.RowHeadersWidth = 51;
            this.dgv_category.RowTemplate.Height = 24;
            this.dgv_category.Size = new System.Drawing.Size(600, 184);
            this.dgv_category.TabIndex = 1;
            this.dgv_category.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_category_CellContentClick);
            this.dgv_category.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_category_CellContentClick);
            // 
            // txt_cate_name
            // 
            this.txt_cate_name.Location = new System.Drawing.Point(472, 116);
            this.txt_cate_name.Name = "txt_cate_name";
            this.txt_cate_name.Size = new System.Drawing.Size(403, 22);
            this.txt_cate_name.TabIndex = 2;
            // 
            // lbl_cate_name
            // 
            this.lbl_cate_name.AutoSize = true;
            this.lbl_cate_name.Location = new System.Drawing.Point(286, 119);
            this.lbl_cate_name.Name = "lbl_cate_name";
            this.lbl_cate_name.Size = new System.Drawing.Size(89, 16);
            this.lbl_cate_name.TabIndex = 4;
            this.lbl_cate_name.Text = "Tên loại hàng";
            this.lbl_cate_name.Click += new System.EventHandler(this.lbl_cate_name_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_create.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_create.Location = new System.Drawing.Point(145, 383);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(113, 38);
            this.btn_create.TabIndex = 5;
            this.btn_create.Text = "create";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_edit.Location = new System.Drawing.Point(320, 383);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(105, 38);
            this.btn_edit.TabIndex = 6;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(502, 383);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(106, 38);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_reset.Location = new System.Drawing.Point(702, 383);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(103, 38);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(909, 383);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(100, 38);
            this.btn_exit.TabIndex = 9;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã loại hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(472, 44);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(403, 22);
            this.txt_id.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpDữLiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1144, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhậpDữLiệuToolStripMenuItem
            // 
            this.nhậpDữLiệuToolStripMenuItem.BackColor = System.Drawing.SystemColors.Highlight;
            this.nhậpDữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sảnPhẩmToolStripMenuItem,
            this.thểLoạiToolStripMenuItem});
            this.nhậpDữLiệuToolStripMenuItem.Name = "nhậpDữLiệuToolStripMenuItem";
            this.nhậpDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.nhậpDữLiệuToolStripMenuItem.Text = "Nhập dữ liệu";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click_1);
            // 
            // thểLoạiToolStripMenuItem
            // 
            this.thểLoạiToolStripMenuItem.Name = "thểLoạiToolStripMenuItem";
            this.thểLoạiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.thểLoạiToolStripMenuItem.Text = "Thể loại";
            // 
            // frm_category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 470);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lbl_cate_name);
            this.Controls.Add(this.txt_cate_name);
            this.Controls.Add(this.dgv_category);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_category";
            this.Text = "Thể loại";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_category;
        private System.Windows.Forms.TextBox txt_cate_name;
        private System.Windows.Forms.Label lbl_cate_name;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhậpDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thểLoạiToolStripMenuItem;
    }
}

