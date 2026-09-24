namespace bai4_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            lstMenu.Items.Add("Hamburger: 50k");
            lstMenu.Items.Add("Pizza: 120k");
            lstMenu.Items.Add("Gà Rán: 35k");
            lstMenu.Items.Add("Pepsi: 15k");

            CapNhatTongTien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem != null)
            {
                lstSelected.Items.Add(lstMenu.SelectedItem);
                CapNhatTongTien();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItem != null)
            {
                lstSelected.Items.Remove(lstSelected.SelectedItem);
                CapNhatTongTien();
            }
        }

        private void CapNhatTongTien()
        {
            int tongTien = 0;

            foreach (string mon in lstSelected.Items)
            {
                if (mon.Contains("50k"))
                    tongTien += 50;
                else if (mon.Contains("120k"))
                    tongTien += 120;
                else if (mon.Contains("35k"))
                    tongTien += 35;
                else if (mon.Contains("15k"))
                    tongTien += 15;
            }

            lblTotal.Text = "Tổng tiền: " + tongTien + "k";
        }
    }
}