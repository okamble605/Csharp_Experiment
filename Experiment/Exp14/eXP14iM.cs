using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
namespace DownloadFile
{
    public partial class Form1 : Form
    {
        WebClient wc = new WebClient();
        public Form1()
        {
            InitializeComponent();
        }

       
        private void FileDownloadComplete(object sender,AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
        }

        private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;

            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double speed = bytesIn / e.ProgressPercentage;

            label1.Text = string.Format("{0} KB/s", (speed / 1024).ToString("0.00"));
            label2.Text = string.Format("{0} / {1} KB", (bytesIn / 1024).ToString("0.00"), (totalBytes / 1024).ToString("0.00"));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadProgressChanged);
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadComplete);

            Uri fileUrl = new Uri(textBox2.Text);
            string fileName = "DownloadedFile";

            // Get the file extension from the URL
            string fileExtension = fileUrl.Segments.Last();
            string[] extensionParts = fileExtension.Split('.');
            if (extensionParts.Length > 1)
            {
                string extension = extensionParts[1].ToLower();
                if (extension == "png" || extension == "jpg" || extension == "jpeg" || extension == "gif")
                {
                    fileName += "." + extension;
                }
                else if (extension == "pdf" || extension == "txt")
                {
                    fileName += "." + extension;
                }
                else
                {
                    MessageBox.Show("Unsupported file extension");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid file URL");
                return;
            }

            wc.DownloadFileAsync(fileUrl, fileName);
        }
    }
}
