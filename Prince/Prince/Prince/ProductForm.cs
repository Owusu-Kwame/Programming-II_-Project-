using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prince
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ADD GOODS
            try
            {
                if (prodId.Text == "" || prodName.Text == "" || prodQty.Text == "" || prodDate.Text == "" || expDate.Text == "" || prodCb.Text == "")
                {
                    MessageBox.Show("All fields must be filled before you can add category");

                }
                else
                {
                    string connection = "server=localhost;user id = root;password =;database=shopriteapplication";
                    string query = "INSERT INTO product(ID,NAME,QUANTITY,PRICE,PROD_DATE,EXP_DATE,CATEGORY) VALUES('" + this.prodId.Text + "','" + this.prodName.Text + "','" + this.prodQty.Text + "','" + this.prodPrice.Text + "','" + this.prodDate.Text + "','" + this.expDate.Text + "','" + this.prodCb.Text + "')";
                    MySqlConnection conn = new MySqlConnection(connection);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();
                    MySqlDataReader dr = cmd.ExecuteReader();
                    MessageBox.Show("Product successfully added");
                    conn.Close();
                    // populate();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
