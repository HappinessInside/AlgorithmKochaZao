using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Алгоритм_Коха_Жао
{
    public partial class Algorithm_Koha_Zao : Form
    {
        Image initialImage;
        
        public Algorithm_Koha_Zao()
        {
            InitializeComponent();
            initialImage = OriginalPictureBox.BackgroundImage;
        }
        
        //Bitmap _image;
       // Bitmap _modifImage;
        //int Length;
        private void OriginalPictureBox_Click(object sender, EventArgs e)
        {
           
            var ofd = new OpenFileDialog();
            ofd.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.bmp)|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                Bitmap image = (Bitmap)Image.FromFile(ofd.FileName);
                OriginalPictureBox.BackgroundImage = image;
                modifPictureBox.BackgroundImage = initialImage;
                embedButton.Enabled = true;
              
            }
        }

        private void embedButton_Click(object sender, EventArgs e)
        {

            modifPictureBox.BackgroundImage = initialImage;
            bool flag = true;
            string message = String.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(pathBox.Text,Encoding.Default))
                {
                    message = sr.ReadToEnd();
                    if (message.Length == 0)
                        flag = false;
                }
            }
            catch (Exception ex)
            {
                flag = false;
                MessageBox.Show("Opening file error or invalid content");
            }
            if (flag)
            {   if (Componenta1.SelectedItem != null && SizeOfBlocks1.SelectedItem != null && coeffDifference1.SelectedItem != null)
                {
                   int sizeOfSegment= DetermineSizeOfSegment(SizeOfBlocks1.SelectedItem.ToString());
                   // Length = message.Length;
                    Algorithm alg = new Algorithm(sizeOfSegment, int.Parse(coeffDifference1.SelectedItem.ToString()), Componenta1.SelectedItem.ToString(), this);  
                    alg.LengthOfMessage = message.Length;
                    Bitmap image = (Bitmap)OriginalPictureBox.BackgroundImage;
                    modifPictureBox.BackgroundImage = alg.Integration(image, message);
                    extractButton.Enabled = true;
                    keyBox1.Text = alg.LengthOfMessage.ToString();
                    MakeParametersOfEmbeddingEqual();
                }
                else
                {
                    MessageBox.Show("Choose all parameters of embedding!");
                }
            }
        }
        private int DetermineSizeOfSegment(string size)
        {
            int result = 0;
            switch (size)
            {
                case "2x2":
                result= 2;
                break;
                case "4x4":
                result = 4;
                break;
                case "8x8":
                result = 8;
                break;

            }
            return result;
        }
        private void MakeParametersOfEmbeddingEqual()
        {
            Componenta2.SelectedItem = Componenta1.SelectedItem;
            keyBox2.Text = keyBox1.Text;
            coeffDifference2.SelectedItem = coeffDifference1.SelectedItem;
            SizeOfBlocks2.SelectedItem = SizeOfBlocks1.SelectedItem;
        }
        private void extractButton_Click(object sender, EventArgs e)
        {   if (Componenta2.SelectedItem != null && SizeOfBlocks2.SelectedItem != null && coeffDifference2.SelectedItem != null && keyBox2.Text!=null)
            {
                int sizeOfSegment = DetermineSizeOfSegment(SizeOfBlocks2.SelectedItem.ToString());
                Bitmap modifImage = (Bitmap)modifPictureBox.BackgroundImage;
                Algorithm alg = new Algorithm(sizeOfSegment, int.Parse(coeffDifference2.SelectedItem.ToString()), Componenta2.SelectedItem.ToString(), this);
                alg.LengthOfMessage = int.Parse(keyBox2.Text);
                sendMess("Extracted information: " + alg.Extraction(modifImage)+"\r\n"+"\r\n");
                
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
           
            if (ofd.ShowDialog() == DialogResult.OK)
            
                pathBox.Text = ofd.FileName;
        }

        public void sendMess(String mess)
        {
            this.infoBox.Text += mess + "\n";
            this.infoBox.SelectionStart =infoBox.Text.Length;
            this.infoBox.ScrollToCaret();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {    
             Bitmap imageSave = (Bitmap)modifPictureBox.BackgroundImage;
            if (imageSave != initialImage)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.bmp)|*.bmp";
                if (sfd.ShowDialog() == DialogResult.OK)
                    imageSave.Save(sfd.FileName);
            }
            else
            {
                MessageBox.Show("First insert an image with a digital watermark!");
            }

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearAllFields();

        }
        private void ClearAllFields()
        {
            modifPictureBox.BackgroundImage = initialImage;
            OriginalPictureBox.BackgroundImage = initialImage;
            infoBox.Clear();
            extractButton.Enabled = false;
            embedButton.Enabled = false;
            Componenta1.SelectedItem = null;
            SizeOfBlocks1.SelectedItem = null;
            coeffDifference1.SelectedItem = null;
            keyBox1.Text = null;
            Componenta2.SelectedItem = null;
            SizeOfBlocks2.SelectedItem = null;
            coeffDifference2.SelectedItem = null;
            keyBox2.Text = null;
            pathBox.Text = null;

        }
        private void modifPictureBox_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            var ofd = new OpenFileDialog();
            ofd.Filter = "(*.jpg)|*.jpg|(*.png)|*.png|(*.bmp)|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                Bitmap _modifImage = (Bitmap)Image.FromFile(ofd.FileName);
                modifPictureBox.BackgroundImage = _modifImage;
                extractButton.Enabled = true;

            }


        }
    }

}