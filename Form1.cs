using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport
{
    public partial class Form1 : Form
    {
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                buttonAdd.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Space)
            {
                buttonClear.PerformClick();
                e.SuppressKeyPress = true;
            }
        }
        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateVisibility();
        }

        private void UpdateVisibility()
        {
            string selectedType = comboBoxType.SelectedItem.ToString();

            labelFuelType.Visible = textFuel.Visible = (selectedType == "Car");
            labelRoute.Visible = textRoute.Visible = (selectedType == "Bus");
            labelGears.Visible = checkBoxGears.Visible = (selectedType == "Bicycle");
        }
        private List<Transport> transports = new List<Transport>();
        public Form1()
        {
            InitializeComponent();
            comboBoxType.Items.AddRange(new string[] {"Car", "Bus", "Bicycle"});
            comboBoxType.SelectedIndex = 0;

            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            UpdateVisibility();

            this.KeyPreview = true; 
            this.KeyDown += Form1_KeyDown;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string brand = textBrand.Text;
            if (!int.TryParse(textSpeed.Text, out int speed) || speed <= 0)
            {
                MessageBox.Show("Введіть коректну швидкість (> 0)", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(textCapacity.Text, out int capacity) || capacity <= 0)
            {
                MessageBox.Show("Введіть коректну вмістимість (> 0)", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Transport transport = null;
            string type = comboBoxType.SelectedItem.ToString();

            if (type == "Car")
            {
                transport = new Car(brand, speed, capacity, textFuel.Text);
            }
            else if (type == "Bus")
            {
                if (!int.TryParse(textRoute.Text, out int routeNumber))
                {
                    MessageBox.Show("Введіть коректний номер маршруту", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                transport = new Bus(brand, speed, capacity, routeNumber);
            }
            else if (type == "Bicycle")
            {
                transport = new Bicycle(brand, speed, capacity, checkBoxGears.Checked);
            }

            if (transport != null)
            {
                transports.Add(transport);
                listBoxTransport.Items.Add(transport.GetInfo());
            }
            textBrand.Clear();
            textSpeed.Clear();
            textCapacity.Clear();
            textFuel.Clear();
            textRoute.Clear();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            transports.Clear();
            listBoxTransport.Items.Clear();
        }
    }
}
