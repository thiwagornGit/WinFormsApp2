namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, user", "First Message");

            //MessageBox.Show("Hello, User", "Second Message",MessageBoxButtons.YesNo, MessageBoxIcon.Error);

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("ต้องหารปิดจริงหรือไม่", "แน่ใจนะ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;    //ยกเลิกคำสั่งปิดฟอร์ม
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Random rn = new Random();
            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);

            this.BackColor = Color.FromArgb(r, g, b);
            this.Text = r.ToString() + "," + g.ToString() + "," + b.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.HotPink;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;

        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.PeachPuff;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.Plum;

        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackColor = Color.MediumSeaGreen;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackColor = Color.SkyBlue;

        }




        private void label2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "มหาวิทยาลัยราชภัฎอุดรธานี")
            {
                label2.Text = "Udon Rajabphat University";
            }
            else
            {
                label2.Text = "มหาวิทยาลัยราชภัฎอุดรธานี";
            }

        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = Color.PeachPuff;

        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Orchid;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label2.Text = textBox1.Text;
            Random rn = new Random();
            int r = rn.Next(0, 255);
            int g = rn.Next(0, 255);
            int b = rn.Next(0, 255);
            label2.ForeColor = Color.FromArgb(r, g, b);


        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = "";
            //textBox1.Text = string.Empty;         //คำสั่งข้อความ text 1 ให้มีค่าว่าง
            //textBox1.Text = null;
        }
    }
}
