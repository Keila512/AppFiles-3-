using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFiles_3_
{
    public partial class Form1 : Form
    {

        private string filePath;
        private List<string> name;
        private Dictionary<int, string> indexedData;
        private int recordSize = 50;
        private Dictionary<int, string> directData;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
            }
        }
        private void ReadFilesSequential(string fileName)
        {
            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    name = new List<string>();
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        name.Add(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading the sequential file: {ex.Message}");
            }
        }
        private void ShowData(List<string> dataList)
        {
            listBox1.Items.Clear();
            foreach (var item in dataList)
            {
                listBox1.Items.Add(item);
            }
        }
        private void btnSequential_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                ReadFilesSequential(filePath);
                ShowData(name);
            }
            else
            {
                MessageBox.Show("Please open a sequential file before performing operations.");
            }
        }
        private void ReadFilesIndex(string fileName)
        {
            try
            {
                indexedData = new Dictionary<int, string>();
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] parts = line.Split(',');
                        if (parts.Length >= 2 && int.TryParse(parts[0], out int index))
                        {
                            indexedData[index] = line.Substring(parts[0].Length + 1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading the indexed file: {ex.Message}");
            }
        }
        private void ShowDataIndex(Dictionary<int, string> indexedData)
        {
            listBox1.Items.Clear();
            foreach (var kvp in indexedData)
            {
                listBox1.Items.Add($"{kvp.Key}: {kvp.Value}");
            }
        }
        private void btnIndex_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                ReadFilesIndex(filePath);
                ShowDataIndex(indexedData);
            }
            else
            {
                MessageBox.Show("Please open an indexed file before performing operations.");
            }
        }
        private void ReadFilesDirect(string fileName)
        {
            try
            {
                directData = new Dictionary<int, string>();
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        int key = reader.ReadInt32();
                        byte[] dataBytes = reader.ReadBytes(recordSize - sizeof(int));
                        string data = System.Text.Encoding.UTF8.GetString(dataBytes);
                        directData[key] = data;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error reading shortcut file: {ex.Message}");
            }
        }
        private void ShowDataDirect(Dictionary<int, string> directData)
        {
            listBox1.Items.Clear();
            foreach (var kvp in directData)
            {
                listBox1.Items.Add($"{kvp.Key}: {kvp.Value}");
            }
        }
        private void btnDirect_Click(object sender, EventArgs e)
        {
            if (filePath != null)
            {
                ReadFilesDirect(filePath);
                ShowDataDirect(directData);
            }
            else
            {
                MessageBox.Show("Please open a shortcut file before making trades.");
            }
        }
    }
}
