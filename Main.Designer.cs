namespace empApp
{
    partial class Main
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btn_add = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            panel1 = new Panel();
            txt_search = new TextBox();
            btn_search = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Image = Properties.Resources.Add_2;
            btn_add.ImageAlign = ContentAlignment.MiddleLeft;
            btn_add.Location = new Point(555, 5);
            btn_add.Margin = new Padding(5);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(98, 39);
            btn_add.TabIndex = 0;
            btn_add.Text = "إضافة";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Image = Properties.Resources.Edit_1;
            btn_edit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_edit.Location = new Point(447, 5);
            btn_edit.Margin = new Padding(5);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(98, 39);
            btn_edit.TabIndex = 1;
            btn_edit.Text = "تعديل";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Image = Properties.Resources.Delete_1;
            btn_delete.ImageAlign = ContentAlignment.MiddleLeft;
            btn_delete.Location = new Point(339, 5);
            btn_delete.Margin = new Padding(5);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(98, 39);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "حذف";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txt_search);
            panel1.Controls.Add(btn_search);
            panel1.Location = new Point(42, 5);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 41);
            panel1.TabIndex = 3;
            // 
            // txt_search
            // 
            txt_search.Dock = DockStyle.Fill;
            txt_search.Font = new Font("Cairo", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txt_search.Location = new Point(0, 0);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(243, 40);
            txt_search.TabIndex = 5;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // btn_search
            // 
            btn_search.Dock = DockStyle.Right;
            btn_search.Image = Properties.Resources.Search_1;
            btn_search.Location = new Point(243, 0);
            btn_search.Margin = new Padding(5);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(44, 41);
            btn_search.TabIndex = 4;
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btn_add);
            flowLayoutPanel1.Controls.Add(btn_edit);
            flowLayoutPanel1.Controls.Add(btn_delete);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel1.Size = new Size(658, 58);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RightToLeft = RightToLeft.Yes;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(658, 266);
            dataGridView1.TabIndex = 5;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 324);
            Controls.Add(dataGridView1);
            Controls.Add(flowLayoutPanel1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 6, 3, 6);
            Name = "Main";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employee App";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_add;
        private Button btn_edit;
        private Button btn_delete;
        private Panel panel1;
        private TextBox txt_search;
        private Button btn_search;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView dataGridView1;
    }
}