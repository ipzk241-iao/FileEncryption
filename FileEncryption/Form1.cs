using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;

namespace FileEncryption
{
    public partial class Form1 : Form
    {
        private string currentFilePath;
        private string currentKey;
        private bool isEncoding;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_ChooseFileEncoding_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tb_4FileEncoding.Text = dlg.FileName;
            }
        }

        private async void btn_encoding_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_4FileEncoding.Text) || string.IsNullOrEmpty(tb_keyEncoding.Text))
            {
                MessageBox.Show("Please select a file and enter a key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isEncoding = true;
            currentFilePath = tb_4FileEncoding.Text;
            currentKey = tb_keyEncoding.Text;


            try
            {
                await Task.Run(() => EncryptDecryptFile(currentFilePath, currentKey));
                string operation = isEncoding ? "encrypted" : "decrypted";
                MessageBox.Show($"File successfully {operation}: {currentFilePath}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btn_decoding_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_4FileEncoding.Text) || string.IsNullOrEmpty(tb_keyEncoding.Text))
            {
                MessageBox.Show("Please select a file and enter a key.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            isEncoding = false;
            currentFilePath = tb_4FileEncoding.Text;
            currentKey = tb_keyEncoding.Text;


            try
            {
                await Task.Run(() => EncryptDecryptFile(currentFilePath, currentKey));
                string operation = isEncoding ? "encrypted" : "decrypted";
                MessageBox.Show($"File successfully {operation}: {currentFilePath}", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EncryptDecryptFile(string filePath, string key)
        {
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            string tempFile = Path.GetTempFileName();

            using (FileStream inputStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (FileStream tempStream = new FileStream(tempFile, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[8192];
                long totalBytes = inputStream.Length;
                long processedBytes = 0;
                int bytesRead;

                while ((bytesRead = inputStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    for (int i = 0; i < bytesRead; i++)
                    {
                        buffer[i] ^= keyBytes[i % keyBytes.Length];
                    }
                    tempStream.Write(buffer, 0, bytesRead);

                    processedBytes += bytesRead;
                    int progressPercentage = (int)((processedBytes * 100) / totalBytes);
                }
            }

            File.Copy(tempFile, filePath, overwrite: true);
            File.Delete(tempFile);
        }
    }
}
