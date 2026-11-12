namespace empApp
{
    partial class empAddForm
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
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            lbl_birthdate = new Label();
            txt_mothername = new TextBox();
            lbl_mothername = new Label();
            txt_name = new TextBox();
            lbl_name = new Label();
            groupBox2 = new GroupBox();
            txt_email = new TextBox();
            lbl_email = new Label();
            txt_phone = new TextBox();
            lbl_phone = new Label();
            txt_address = new TextBox();
            lbl_address = new Label();
            btn_empsave = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(lbl_birthdate);
            groupBox1.Controls.Add(txt_mothername);
            groupBox1.Controls.Add(lbl_mothername);
            groupBox1.Controls.Add(txt_name);
            groupBox1.Controls.Add(lbl_name);
            groupBox1.Location = new Point(14, 14);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(608, 171);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "البيانات الشخصية";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(153, 122);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.RightToLeft = RightToLeft.No;
            dateTimePicker1.Size = new Size(291, 37);
            dateTimePicker1.TabIndex = 5;
            // 
            // lbl_birthdate
            // 
            lbl_birthdate.AutoSize = true;
            lbl_birthdate.Location = new Point(514, 122);
            lbl_birthdate.Name = "lbl_birthdate";
            lbl_birthdate.Size = new Size(88, 30);
            lbl_birthdate.TabIndex = 4;
            lbl_birthdate.Text = "تاريخ الميلاد";
            // 
            // txt_mothername
            // 
            txt_mothername.Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_mothername.Location = new Point(153, 78);
            txt_mothername.Name = "txt_mothername";
            txt_mothername.RightToLeft = RightToLeft.No;
            txt_mothername.Size = new Size(291, 32);
            txt_mothername.TabIndex = 3;
            txt_mothername.TextAlign = HorizontalAlignment.Right;
            // 
            // lbl_mothername
            // 
            lbl_mothername.AutoSize = true;
            lbl_mothername.Location = new Point(496, 78);
            lbl_mothername.Name = "lbl_mothername";
            lbl_mothername.Size = new Size(106, 30);
            lbl_mothername.TabIndex = 2;
            lbl_mothername.Text = "اسم الأم ثلاثي";
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(153, 33);
            txt_name.Name = "txt_name";
            txt_name.RightToLeft = RightToLeft.No;
            txt_name.Size = new Size(291, 32);
            txt_name.TabIndex = 1;
            txt_name.TextAlign = HorizontalAlignment.Right;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new Point(446, 33);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new Size(156, 30);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "اسم الموظف بالكامل";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txt_email);
            groupBox2.Controls.Add(lbl_email);
            groupBox2.Controls.Add(txt_phone);
            groupBox2.Controls.Add(lbl_phone);
            groupBox2.Controls.Add(txt_address);
            groupBox2.Controls.Add(lbl_address);
            groupBox2.Location = new Point(14, 195);
            groupBox2.Margin = new Padding(5);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(608, 171);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "بيانات الاتصال";
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(153, 124);
            txt_email.Name = "txt_email";
            txt_email.RightToLeft = RightToLeft.No;
            txt_email.Size = new Size(291, 32);
            txt_email.TabIndex = 5;
            txt_email.TextAlign = HorizontalAlignment.Right;
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Location = new Point(487, 124);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(115, 30);
            lbl_email.TabIndex = 4;
            lbl_email.Text = "البريد الالكتروني";
            // 
            // txt_phone
            // 
            txt_phone.Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phone.Location = new Point(153, 78);
            txt_phone.Name = "txt_phone";
            txt_phone.RightToLeft = RightToLeft.No;
            txt_phone.Size = new Size(291, 32);
            txt_phone.TabIndex = 3;
            txt_phone.TextAlign = HorizontalAlignment.Right;
            // 
            // lbl_phone
            // 
            lbl_phone.AutoSize = true;
            lbl_phone.Location = new Point(515, 80);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new Size(87, 30);
            lbl_phone.TabIndex = 2;
            lbl_phone.Text = "رقم الهاتف";
            // 
            // txt_address
            // 
            txt_address.Font = new Font("Cairo", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_address.Location = new Point(153, 33);
            txt_address.Name = "txt_address";
            txt_address.RightToLeft = RightToLeft.No;
            txt_address.Size = new Size(291, 32);
            txt_address.TabIndex = 1;
            txt_address.TextAlign = HorizontalAlignment.Right;
            // 
            // lbl_address
            // 
            lbl_address.AutoSize = true;
            lbl_address.Location = new Point(542, 35);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new Size(60, 30);
            lbl_address.TabIndex = 0;
            lbl_address.Text = "العنوان";
            // 
            // btn_empsave
            // 
            btn_empsave.Image = Properties.Resources.Save;
            btn_empsave.ImageAlign = ContentAlignment.MiddleLeft;
            btn_empsave.Location = new Point(20, 374);
            btn_empsave.Name = "btn_empsave";
            btn_empsave.Size = new Size(106, 42);
            btn_empsave.TabIndex = 7;
            btn_empsave.Text = "حفظ";
            btn_empsave.UseVisualStyleBackColor = true;
            btn_empsave.Click += btn_empsave_Click;
            // 
            // empAddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 417);
            Controls.Add(btn_empsave);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 6, 3, 6);
            Name = "empAddForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "إضافة موظف";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label lbl_name;
        private Label lbl_mothername;
        private Label lbl_birthdate;
        private GroupBox groupBox2;
        private Label lbl_email;
        private Label lbl_phone;
        private Label lbl_address;
        private Button btn_empsave;
        public TextBox txt_name;
        public TextBox txt_mothername;
        public DateTimePicker dateTimePicker1;
        public TextBox txt_email;
        public TextBox txt_phone;
        public TextBox txt_address;
    }
}