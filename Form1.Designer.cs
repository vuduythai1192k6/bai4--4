namespace bai4_4
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lstMenu = new ListBox();
            lstSelected = new ListBox();
            btnThem = new Button();
            btnXoa = new Button();
            lblTotal = new Label();
            lblMenu = new Label();
            lblSelected = new Label();
            SuspendLayout();

            // lblMenu
            lblMenu.AutoSize = true;
            lblMenu.Location = new Point(40, 30);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(87, 20);
            lblMenu.Text = "Danh sách món";

            // lstMenu
            lstMenu.FormattingEnabled = true;
            lstMenu.Location = new Point(40, 60);
            lstMenu.Name = "lstMenu";
            lstMenu.Size = new Size(220, 180);
            lstMenu.TabIndex = 0;

            // lblSelected
            lblSelected.AutoSize = true;
            lblSelected.Location = new Point(420, 30);
            lblSelected.Name = "lblSelected";
            lblSelected.Size = new Size(112, 20);
            lblSelected.Text = "Món đã chọn";

            // lstSelected
            lstSelected.FormattingEnabled = true;
            lstSelected.Location = new Point(420, 60);
            lstSelected.Name = "lstSelected";
            lstSelected.Size = new Size(220, 180);
            lstSelected.TabIndex = 1;

            // btnThem
            btnThem.Location = new Point(300, 90);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(70, 45);
            btnThem.TabIndex = 2;
            btnThem.Text = ">";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;

            // btnXoa
            btnXoa.Location = new Point(300, 155);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(70, 45);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "<";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;

            // lblTotal
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.Location = new Point(420, 270);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(125, 28);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Tổng tiền: 0k";

            // Form1
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 350);
            Controls.Add(lblTotal);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(lstSelected);
            Controls.Add(lblSelected);
            Controls.Add(lstMenu);
            Controls.Add(lblMenu);
            Name = "Form1";
            Text = "Quan ly mon an";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstMenu;
        private ListBox lstSelected;
        private Button btnThem;
        private Button btnXoa;
        private Label lblTotal;
        private Label lblMenu;
        private Label lblSelected;
    }
}
