using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;

namespace Transport
{
    public partial class Form1 : Form
    {
        private List<Transport> transports = new List<Transport>();

        public Form1()
        {
            InitializeComponent();
            comboBoxFilter.Items.Clear();
            comboBoxFilter.Items.AddRange(new string[] { "Всі", "Car", "Bus", "Bicycle" });
            comboBoxFilter.SelectedIndex = 0;

            comboBoxType.Items.Clear();
            comboBoxType.Items.AddRange(new string[] { "Car", "Bus", "Bicycle" });
            comboBoxType.SelectedIndex = 0;

            comboBoxType.SelectedIndexChanged += comboBoxType_SelectedIndexChanged;
            comboBoxFilter.SelectedIndexChanged += comboBoxFilter_SelectedIndexChanged;

            UpdateVisibility();
            this.KeyPreview = true;
            this.KeyDown += Form1_KeyDown;
        }


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
            if (comboBoxType.SelectedItem == null) return;

            string selectedType = comboBoxType.SelectedItem.ToString();

            labelFuelType.Visible = textFuel.Visible = (selectedType == "Car");
            labelRoute.Visible = textRoute.Visible = (selectedType == "Bus");
            labelGears.Visible = checkBoxGears.Visible = (selectedType == "Bicycle");
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
            UpdateFilteredList();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            if (transports.Count == 0)
            {
                MessageBox.Show("Немає даних для очищення!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            DialogResult result = MessageBox.Show(
                "Дані у списку буде видалено. Бажаєте їх зберегти перед видаленням?",
                "Підтвердження",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                SaveData();
                ClearList();
            }
            else if (result == DialogResult.No)
            {
                ClearList();
            }
        }

        private void ClearList()
        {
            transports.Clear();
            listBoxTransport.Items.Clear();
        }

        private void SaveData()
        {
            if (transports.Count == 0)
            {
                MessageBox.Show("Немає даних для збереження!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON файли (*.json)|*.json|Всі файли (*.*)|*.*";
                saveFileDialog.Title = "Оберіть місце для збереження";
                saveFileDialog.FileName = "transport_data.json";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        var transportData = new List<object>();

                        foreach (var transport in transports)
                        {
                            if (transport is Car car)
                                transportData.Add(new { Type = "Car", car.Brand, car.Speed, car.Capacity, car.FuelType });

                            else if (transport is Bus bus)
                                transportData.Add(new { Type = "Bus", bus.Brand, bus.Speed, bus.Capacity, bus.RouteNumber });

                            else if (transport is Bicycle bicycle)
                                transportData.Add(new { Type = "Bicycle", bicycle.Brand, bicycle.Speed, bicycle.Capacity, bicycle.HasGears });
                        }

                        string jsonData = JsonSerializer.Serialize(transportData, new JsonSerializerOptions { WriteIndented = true });
                        File.WriteAllText(saveFileDialog.FileName, jsonData);

                        MessageBox.Show("Дані успішно збережено!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка збереження: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadData()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "JSON файли (*.json)|*.json|Всі файли (*.*)|*.*";
                openFileDialog.Title = "Оберіть файл для завантаження";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string jsonData = File.ReadAllText(openFileDialog.FileName);
                        var rawData = JsonSerializer.Deserialize<List<JsonElement>>(jsonData);

                        transports.Clear();

                        foreach (var item in rawData)
                        {
                            if (!item.TryGetProperty("Type", out JsonElement typeElement))
                                continue;

                            string type = typeElement.GetString();

                            if (type == "Car")
                            {
                                var car = JsonSerializer.Deserialize<Car>(item.GetRawText());
                                transports.Add(car);
                            }
                            else if (type == "Bus")
                            {
                                var bus = JsonSerializer.Deserialize<Bus>(item.GetRawText());
                                transports.Add(bus);
                            }
                            else if (type == "Bicycle")
                            {
                                var bicycle = JsonSerializer.Deserialize<Bicycle>(item.GetRawText());
                                transports.Add(bicycle);
                            }
                        }

                        listBoxTransport.Items.Clear();
                        foreach (var transport in transports)
                        {
                            listBoxTransport.Items.Add(transport.GetInfo());
                        }
                        UpdateFilteredList();
                        MessageBox.Show("Дані успішно завантажено!", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Помилка завантаження: " + ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void comboBoxFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFilteredList();
        }
        private void UpdateFilteredList()
        {
            if (comboBoxFilter.SelectedItem == null) return; // Перевірка на null

            listBoxTransport.Items.Clear();
            string selectedFilter = comboBoxFilter.SelectedItem.ToString();

            foreach (var transport in transports)
            {
                bool shouldAdd = selectedFilter == "Всі" ||
                                 (selectedFilter == "Car" && transport is Car) ||
                                 (selectedFilter == "Bus" && transport is Bus) ||
                                 (selectedFilter == "Bicycle" && transport is Bicycle);

                if (shouldAdd)
                {
                    listBoxTransport.Items.Add(transport.GetInfo());
                }
            }
        }
    }
}
