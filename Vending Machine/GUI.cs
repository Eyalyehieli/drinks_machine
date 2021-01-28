using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Vending_Machine
{
    public partial class GUI : Form
    {
        string path = Directory.GetCurrentDirectory() + "\\drinks.xml";
        XmlDocument document = new XmlDocument();
        
        public GUI()
        {
            InitializeComponent();
            InitMenus();

            if(File.Exists(path))
            {
                document.Load(path);
                showDrinks();
            }
            else
            {
                XmlNode root = document.CreateElement("drinks");
                document.AppendChild(root);
            }
        }

        private void InitMenus()
        {
            dataGridView1.Columns.Add("name", "name");
            dataGridView1.Columns.Add("sugar", "sugar");
            dataGridView1.Columns.Add("cacao", "cacao");
            dataGridView1.Columns.Add("cofee", "cofee");
            dataGridView1.Columns.Add("milk", "milk");
            dataGridView1.Columns.Add("price", "price");

            for (double i = 0; i < 3.5; i += 0.5)
            {
                cmbCacao.Items.Add(i);
                cmbCofee.Items.Add(i);
                cmbMilk.Items.Add(i);
                cmbSugar.Items.Add(i);
            }
        }

        private void btnUp_Click(object sender, System.EventArgs e)
        {
            txtPrice.Text = (double.Parse(txtPrice.Text) + 0.5).ToString();
        }

        private void btnDown_Click(object sender, System.EventArgs e)
        {
            txtPrice.Text = (double.Parse(txtPrice.Text) - 0.5).ToString();
        }

        private void txtPrice_TextChanged(object sender, System.EventArgs e)
        {
            if(txtPrice.Text == "" || txtPrice.Text == "0" || txtPrice.Text[0] == '-')
            {
                txtPrice.Text = "1";
            }
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show(document.InnerXml);
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            document.Save(path);
            showDrinks();
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            XmlNode root = document.GetElementsByTagName("drinks")[0];
            XmlNode drink = document.CreateElement("drink");

            drink.AppendChild(document.CreateElement("name")).InnerText  = txtBoxName.Text;
            drink.AppendChild(document.CreateElement("sugar")).InnerText = cmbSugar.Text;
            drink.AppendChild(document.CreateElement("cacao")).InnerText = cmbCacao.Text;
            drink.AppendChild(document.CreateElement("cofee")).InnerText = cmbCofee.Text;
            drink.AppendChild(document.CreateElement("milk")).InnerText  = cmbMilk.Text;
            drink.AppendChild(document.CreateElement("price")).InnerText = txtPrice.Text;

            root.AppendChild(drink);
            showDrinks();
        }

        private void showDrinks()
        {
            XmlNodeList list = document.GetElementsByTagName("drink");
            string name="", sugar = "", cacao = "", cofee = "", milk = "", price = "";

            dataGridView1.Rows.Clear();

            foreach (XmlNode node in list)
            {
                foreach(XmlNode type in node.ChildNodes)
                {
                    switch (type.Name)
                    {
                        case "name":
                            name = type.InnerText;
                            break;
                        case "sugar":
                            sugar = type.InnerText;
                            break;
                        case "cacao":
                            cacao = type.InnerText;
                            break;
                        case "cofee":
                            cofee = type.InnerText;
                            break;
                        case "milk":
                            milk = type.InnerText;
                            break;
                        case "price":
                            price = type.InnerText;
                            break;
                    }
                }
                dataGridView1.Rows.Add(name, sugar, cacao, cofee, milk, price);
            }

        }

        private void clearAllControls()
        {
            foreach (Control control in this.Controls)
            {
                if (control is ComboBox)
                    control.Text = "0";
                if (control is TextBox)
                    control.Text = "";
            }
        }

        private void txtBoxName_TextChanged(object sender, System.EventArgs e)
        {
            XmlNode drink = SearchNodeByNameDrink(txtBoxName.Text);
            if (drink != null)
            {
                var result = MessageBox.Show($"Would you like to update {txtBoxName.Text} ?", "Update drink", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    foreach (XmlNode type in drink.ChildNodes)
                    {
                        switch (type.Name)
                        {
                            case "sugar":
                                cmbSugar.Text = type.InnerText;
                                break;
                            case "name":
                                txtBoxName.Text = type.InnerText;
                                break;
                            case "cacao":
                                cmbCacao.Text = type.InnerText;
                                break;
                            case "cofee":
                                cmbCofee.Text = type.InnerText;
                                break;
                            case "milk":
                                cmbMilk.Text = type.InnerText;
                                break;
                            case "price":
                                txtPrice.Text = type.InnerText;
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
        }
        private XmlNode SearchNodeByNameDrink(string drinkName)
        {
            XmlNodeList list = document.GetElementsByTagName("name");
            foreach (XmlNode name in list)
            {
                if (name.InnerText == drinkName)
                    return name.ParentNode;
            }
            return null;
        }

        private void btnUpdate_Click(object sender, System.EventArgs e)
        {
            XmlNode drink = SearchNodeByNameDrink(txtBoxName.Text);

            foreach(XmlNode xmlNode in drink.ChildNodes)
            {
                switch(xmlNode.Name)
                {
                    case "sugar":
                        xmlNode.InnerText = cmbSugar.Text;
                        break;
                    case "cacao":
                        xmlNode.InnerText = cmbCacao.Text;
                        break;
                    case "cofee":
                        xmlNode.InnerText = cmbCofee.Text;
                        break;
                    case "milk":
                        xmlNode.InnerText = cmbMilk.Text;
                        break;
                    case "price":
                        xmlNode.InnerText = txtPrice.Text;
                        break;
                    default:
                        break;
                }
            }
            showDrinks();
        }

        private void btnDelete_Click(object sender, System.EventArgs e)
        {
            var result = MessageBox.Show($"Would you like to delete {txtBoxName.Text}", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                XmlNode drink = SearchNodeByNameDrink(txtBoxName.Text);
                if(drink != null)
                {
                    drink.ParentNode.RemoveChild(drink);
                    showDrinks();
                }
            }
        }
    }
}