using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//For Binary Serialization
using System.Runtime.Serialization.Formatters.Binary;

//For XMl Serialization
using System.Xml.Serialization;

//For SOAP serialization
using System.Runtime.Serialization.Formatters.Soap;

//For JSON serialization
using System.Text.Json;
using System.IO;

namespace WindowsFormsAppSerilization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBinaryWriter_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Serilization\productBinaryDemo.dat", FileMode.Create, FileAccess.Write);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);

                binaryFormatter.Serialize(fs, prod);
                fs.Close();

                MessageBox.Show("Done");
                txtId.Clear();
                txtName.Clear();
                txtPrice.Clear();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryReader_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Serilization\productBinaryDemo.dat", FileMode.Open, FileAccess.Read);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                Product prod = new Product();
                prod = (Product)binaryFormatter.Deserialize(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();

                fs.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtPrice.Clear();
        }

        private void btnXMLWriter_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Serilization\ProductXmlDemo.xml", FileMode.Create, FileAccess.Write);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);

                xmlSerializer.Serialize(fs, prod);
                fs.Close();
                MessageBox.Show("Done");
                txtId.Clear();
                txtName.Clear();
                txtPrice.Clear();
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXmlReader_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Serilization\ProductXmlDemo.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Product));
                Product prod = new Product();
                prod = (Product)xmlSerializer.Deserialize(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();

                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWriter_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Serilization\productSoapDemo.soap", FileMode.Create, FileAccess.Write);
                SoapFormatter soapFormatter = new SoapFormatter();
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);

                soapFormatter.Serialize(fs, prod);
                fs.Close();
                MessageBox.Show("Done");
                txtId.Clear();
                txtName.Clear();
                txtPrice.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPReader_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Serilization\productSoapDemo.soap", FileMode.Open, FileAccess.Read);
                SoapFormatter soapFormatter = new SoapFormatter();
                Product prod = new Product();
                prod = (Product)soapFormatter.Deserialize(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();

                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJSONWriter_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Serilization\ProductJsonDemo.json", FileMode.Create, FileAccess.Write);
                
                Product prod = new Product();
                prod.Id = Convert.ToInt32(txtId.Text);
                prod.Name = txtName.Text;
                prod.Price = Convert.ToInt32(txtPrice.Text);

                JsonSerializer.Serialize<Product>(fs, prod);
                fs.Close();
                MessageBox.Show("Done");
                txtId.Clear();
                txtName.Clear();
                txtPrice.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONReader_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\Serilization\ProductJsonDemo.json", FileMode.Open, FileAccess.Read);
                
                Product prod = new Product();
                prod = JsonSerializer.Deserialize<Product>(fs);
                txtId.Text = prod.Id.ToString();
                txtName.Text = prod.Name;
                txtPrice.Text = prod.Price.ToString();

                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
