namespace Tugas_Week_2
{
    public partial class FormCoba : Form
    {
        public FormCoba()
        {
            InitializeComponent();
        }

        private void btnProses_Click(object sender, EventArgs e)
        {
      
            if(txtBox1.Text == "SHOWN")
            {
                lblGanti.Visible = true;
            }
            else if(txtBox1.Text == "HIDE")
            {
                lblGanti.Visible= false;
            }
            else if (txtBox1.Text == "WARNA:DEFAULT")
            {
                lblGanti.ForeColor = Color.Black;
            }
            else if (txtBox1.Text == "WARNA:MERAH")
            {
                lblGanti.ForeColor = Color.Red;
            }
            else if (txtBox1.Text == "WARNA:HIJAU")
            {
                lblGanti.ForeColor = Color.Green;
            }
            else if (txtBox1.Text == "WARNA:BIRU")
            {
                lblGanti.ForeColor = Color.Blue;
            }
            else if (txtBox1.Text == "RESTART")
            {
                lblGanti.ForeColor = Color.Black;
                lblGanti.Text = "[EMPTY]";
                lblGanti.Font = new Font("Arial", 14);
            }
            else if (txtBox1.Text.Substring(0,4) == "ISI:")
            {
                lblGanti.Text = txtBox1.Text.Substring(4);
            }
            else if (txtBox1.Text == "BESARKAN")
            {
                var cobabesar = lblGanti.Font.Size;
                cobabesar += 1;
                lblGanti.Font = new Font(lblGanti.Font.FontFamily, cobabesar);
            }
            else if (txtBox1.Text == "KECILKAN")
            {
                var cobakecil = lblGanti.Font.Size;
                cobakecil -= 1;
                lblGanti.Font = new Font(lblGanti.Font.FontFamily, cobakecil);
            }
            else
            {
                MessageBox.Show("Syntax Tidak Terdaftar!");
            }
            
        }
    }
}