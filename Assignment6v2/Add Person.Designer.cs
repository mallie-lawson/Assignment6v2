namespace Assignment6v2
{
    partial class Add_Person
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
            lblName = new Label();
            txtName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(62, 106);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "&Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(62, 129);
            txtName.Name = "txtName";
            txtName.Size = new Size(117, 27);
            txtName.TabIndex = 1;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(237, 106);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 2;
            lblPhone.Text = "&Phone";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(237, 129);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(117, 27);
            txtPhone.TabIndex = 3;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(62, 238);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(116, 59);
            btnOk.TabIndex = 4;
            btnOk.Text = "&Ok";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(238, 238);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(116, 59);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Add_Person
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(txtPhone);
            Controls.Add(lblPhone);
            Controls.Add(txtName);
            Controls.Add(lblName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Add_Person";
            Text = "Add_Person";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private TextBox txtName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Button btnOk;
        private Button btnCancel;
    }
}