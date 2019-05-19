using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Алгоритм_Коха_Жао
{
   public class Algorithm
   {    
        public int LengthOfMessage;
        Bitmap picture;
        int SizeOfSegment=8;  
        int P=25;
        string ComponentOfEmbedding;
       
        private Algorithm_Koha_Zao _form = null;
        Point p1;
        Point p2;
        public Algorithm(int size, int p, string component,Algorithm_Koha_Zao form)
        {
            P = p;
            SizeOfSegment = size;
            ComponentOfEmbedding = component;
            _form = form;
            DeterminePointsOfCoefficients();
        }

        public Bitmap Integration(Image im, string message) // встраивание
        {
            sendMessToForm("Start embedding message...");
            picture= new Bitmap(im);
            if ((picture.Width % SizeOfSegment) != 0 || (picture.Height % SizeOfSegment) != 0)
            {
               trim(ref picture, SizeOfSegment);
            }
            int y = picture.Height, x = picture.Width;
            Byte[,] ArrayForEmbedding = new Byte[x, y];
            
            //выбираем из картинки синюю компоненту RGB-модели
            for (int i = 0; i < x; i++)
            { for (int j = 0; j < y; j++)
                {   if (ComponentOfEmbedding == "Blue")
                    {
                        ArrayForEmbedding[i, j] = picture.GetPixel(i, j).B;
                    }
                    else if(ComponentOfEmbedding=="Green")
                    {
                        ArrayForEmbedding[i, j] = picture.GetPixel(i, j).G;
                    }
                    else
                    {
                        ArrayForEmbedding[i, j] = picture.GetPixel(i, j).R;
                    }
                }
            }
               
                
                
            int Nc = x * y / (SizeOfSegment * SizeOfSegment); //общее число сегментов
            byte[] tekst = Encoding.GetEncoding(1251).GetBytes(message);//1251 - кодировка.

            if (Nc < 8 * tekst.Length)
            {
                MessageBox.Show("Message size is too big.");
                return null;
            }
            List<byte[,]> C = new List<byte[,]>();
            // разбиваем массив B на сегменты С
            sendMessToForm("Segmentation of image components...");
           
            separation(ArrayForEmbedding,  C, x,y, SizeOfSegment);
            sendMessToForm("Discrete cosine transform performance...");
            List<double[,]> DKP = new List<double[,]>();
                foreach (byte[,] b in C)
                {
                    DKP.Add(dkp(b));
                }
            sendMessToForm("Message inlining...");
            inliningMess(tekst,ref DKP,P);
            sendMessToForm("Inverse discrete cosine transform performance...");
            List<double[,]> ODKP = new List<double[,]>();
            foreach (var d in DKP)
            {
                ODKP.Add(odkp(d));
            }
            sendMessToForm("Formation of modified image...");
            Double[,] newModifArray = new Double[x, y];
            BuildNewB(ODKP, ref newModifArray, x, y,SizeOfSegment);
            newModifArray = normaliz(newModifArray);
            Bitmap modifImage=new Bitmap(picture);
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j <y; j++)
                {
                    if (ComponentOfEmbedding == "Blue")
                    {
                       modifImage.SetPixel(i, j, Color.FromArgb(picture.GetPixel(i, j).R, picture.GetPixel(i, j).G, (byte)Math.Round(newModifArray[i, j])));
                    }
                    else if (ComponentOfEmbedding == "Green")
                    {
                        modifImage.SetPixel(i, j, Color.FromArgb(picture.GetPixel(i, j).R, (byte)Math.Round(newModifArray[i, j]), picture.GetPixel(i, j).B));
                    }
                    else
                    {
                        modifImage.SetPixel(i, j, Color.FromArgb((byte)Math.Round(newModifArray[i, j]), picture.GetPixel(i, j).G, picture.GetPixel(i, j).B));
                    }

                }
            }
            sendMessToForm("Inlining is complete!"+ "\r\n");
            return modifImage;
        }

        public string Extraction(Image modifImage)
        {
            Bitmap modifPicture = new Bitmap(modifImage);
            sendMessToForm("Start message extraction...");
            string result = null;
            try
            {
                int x = modifPicture.Width;
                int y = modifPicture.Height;

                Byte[,] ArrayForEmbedding = new Byte[x, y];
                for (int i = 0; i < x; i++)
                {
                    for (int j = 0; j < y; j++)
                    {
                        if (ComponentOfEmbedding == "Blue")
                        {
                            ArrayForEmbedding[i, j] = modifPicture.GetPixel(i, j).B;
                        }
                        else if (ComponentOfEmbedding == "Green")
                        {
                            ArrayForEmbedding[i, j] = modifPicture.GetPixel(i, j).G;
                        }
                        else
                        {
                            ArrayForEmbedding[i, j] = modifPicture.GetPixel(i, j).R;
                        }
                    }
                }

                int Nc = x * y / (SizeOfSegment * SizeOfSegment); //общее число сегментов
                List<byte[,]> C = new List<byte[,]>();

                sendMessToForm("Segmentation of image components...");
                separation(ArrayForEmbedding, C, x, y, SizeOfSegment);
                sendMessToForm("Discrete cosine transform performance...");
                List<double[,]> DKP = new List<double[,]>();
                foreach (byte[,] b in C)
                {
                    DKP.Add(dkp(b));
                }
                List<byte> message = new List<byte>();
                sendMessToForm("Message formation...");
                int key = LengthOfMessage;
                List<int> possiblePositions = new List<int>();
                for (int i = 0; i < DKP.Count; i++)
                {
                    possiblePositions.Add(i);
                }
                for (int i = 0; i < LengthOfMessage; i++)
                {
                    int[] bits = new int[8];
                    for (int j = 0; j < 8; j++)
                    {

                        key = GetKey(key, possiblePositions.Count);
                        int pos = possiblePositions[key];
                        possiblePositions.RemoveAt(key);
                        double AbsPoint1 = Math.Abs(DKP[pos][p1.X, p1.Y]);
                        double AbsPoint2 = Math.Abs(DKP[pos][p2.X, p2.Y]);
                        if (AbsPoint1 > AbsPoint2)
                        {
                            bits[j] = 0;
                        }
                        if (AbsPoint1 < AbsPoint2)
                        {
                            bits[j] = 1;
                        }
                    }

                    message.Add(ConvertToByte(bits));

                }

                for (int i = 0; i < message.Count; i++)
                {
                    char ch = Encoding.GetEncoding(1251).GetString(message.ToArray())[i];
                    result += ch;
                }
                sendMessToForm("Message extraction is complete!");
            }
            catch (Exception e)
            {
                return "Failed to extract information.";
            }
            return result;
        }
        byte[,] submatrix(byte[,] one, int a, int b, int c, int d) 
        {
            byte[,] temp = new byte[b - a + 1, d - c + 1];
            for (int i = a, k = 0; i <= b; i++, k++)
                for (int j = c, l = 0; j <= d; j++, l++)
                    temp[k, l] = one[i, j];
            return temp;
        }
        
        double FindCoefficient(int arg)
        {
            if (arg == 0) return 1.0 / Math.Sqrt(2);
            return 1;
        }
        double[,] dkp(byte[,] one)
        {
            int n = one.GetLength(0);
            double[,] two = new double[n, n];
            double temp = 0;
            for (int v = 0; v < n; v++)
            {
                for (int u = 0; u < n; u++)
                {
                    temp = 0;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            temp += one[i, j] * Math.Cos(Math.PI * v * (2 * i + 1) / (2 * n)) *
                                Math.Cos(Math.PI * u * (2 * j + 1) / (2 * n));
                        }
                    }
                    two[v, u] = FindCoefficient(u) * FindCoefficient(v) * temp / (Math.Sqrt(2 * n));
                }
            }
            return two;
            }
        private void trim(ref Bitmap image, int sizeSegment)
        {
            int x = image.Width % sizeSegment;
            int y = image.Height % sizeSegment;
            Size newSize = new Size(image.Width - x, image.Height - y);
            Bitmap b = new Bitmap(newSize.Width, newSize.Height);
            for (int i = 0; i < b.Width; i++)
            {
                for (int j = 0; j < b.Height; j++)
                {
                    b.SetPixel(i, j, image.GetPixel(i, j));
                }
            }
            image = b;
        }
        private void inliningMess(byte[] message, ref List<double[,]> DKP, int P)
        {
            int key = LengthOfMessage;
            List<int> possiblePositions = new List<int>();
            for (int i = 0; i < DKP.Count; i++)
            {
                possiblePositions.Add(i);
            }
            //LengthOfMessage = message.Length;
            for (int i = 0; i < message.Length; i++)
            {
                int [] bitsOfSymbol = ConvertToBits(message[i]);
                for (int j = 0; j < 8; j++)
                {   int currentBit = bitsOfSymbol[j];
                    key = GetKey(key, possiblePositions.Count);
                    int pos = possiblePositions[key];
                    possiblePositions.RemoveAt(key);
                    
                    double AbsPoint1 = Math.Abs(DKP[pos][p1.X, p1.Y]);
                    double AbsPoint2 = Math.Abs(DKP[pos][p2.X, p2.Y]);
                    int z1 = 1, z2 = 1;
                    if (DKP[pos][p1.X, p1.Y] < 0)
                    {
                        z1 = -1;
                    }
                    if (DKP[pos][p2.X, p2.Y] < 0)
                    {
                        z2 = -1;
                    }
                    if (currentBit == 0)
                    {
                        if (AbsPoint1 - AbsPoint2 <= P)
                        {
                            AbsPoint1 = P + AbsPoint2 + 1;  
                        }
                    }
                    if (currentBit == 1)
                    {
                        if (AbsPoint1 - AbsPoint2 >= -P)
                        {
                            AbsPoint2 = P + AbsPoint1 + 1;
                        }
                    }
                    DKP[pos][p1.X, p1.Y] = z1 * AbsPoint1;
                    DKP[pos][p2.X, p2.Y] = z2 * AbsPoint2;
                }

            }
        }
        private double[,] odkp(double[,] dkp)
        {
            int n = dkp.GetLength(0);
            double[,] result = new double[n, n];
            double temp = 0;
            for (int v = 0; v < n; v++)
            {
                for (int u = 0; u < n; u++)
                {
                    temp = 0;
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < n; j++)
                        {
                            temp += FindCoefficient(i) * FindCoefficient(j) * dkp[i, j] * Math.Cos(Math.PI * i * (2 * v + 1) / (2 * n)) *
                             Math.Cos(Math.PI * j * (2 * u + 1) / (2 * n));
                        }
                    }
                    result[v, u] = temp / (Math.Sqrt(2 * n));
                }
            }
            return result;
        }

        private void BuildNewB(List<double[,]> ODKP, ref double[,] newB, int sizeX, int sizeY, int sizeSegment)
        {
            Double[][,] tmp = ODKP.ToArray();
            int Nx = sizeX / sizeSegment;
            int Ny = sizeY / sizeSegment;
            int k = 0;
            for (int i = 0; i < Nx; i++)
            {
                int startX = i * sizeSegment;
                int endX = startX + sizeSegment - 1;
                for (int j = 0; j < Ny; j++)
                {
                    int startY = j * sizeSegment;
                    int endY = startY + sizeSegment - 1;
                    if (k > tmp.GetLength(0))
                    {
                        throw new IndexOutOfRangeException();
                    }
                    insert(ref newB, tmp[k], startX, endX, startY, endY);
                    k++;
                }
            }
        }
        private void insert(ref double[,] newB, double[,] tmp, int startX, int endX, int startY, int endY)
        {
           
            int u = 0;
            for (int i = startX; i < endX + 1; i++)
            {
                int v = 0;
                for (int j = startY; j < endY + 1; j++)
                {
                    newB[i, j] = tmp[u, v];
                    v++;
                }
                u++;
            }
        }
        private double[,] normaliz(double[,] odkp)
        {
            double min = Double.MaxValue, max = Double.MinValue;
            for (int i = 0; i < odkp.GetLength(0); i++)
            {
                for (int j = 0; j < odkp.GetLength(1); j++)
                {
                    if (odkp[i, j] > max)
                        max = odkp[i, j];
                    if (odkp[i, j] < min)
                        min = odkp[i, j];
                }
            }
            double[,] result = new double[odkp.GetLength(0), odkp.GetLength(1)];
            for (int i = 0; i < odkp.GetLength(0); i++)
            {
                for (int j = 0; j < odkp.GetLength(1); j++)
                {
                    result[i, j] = 255 * (odkp[i, j] + Math.Abs(min)) / (max + Math.Abs(min));
                }
            }
            return result;
        }
        private void separation(byte[,] B, List<byte[,]> C, int sizeX, int sizeY, int sizeSegment)
        {
            int Nx = sizeX / sizeSegment;
            int Ny = sizeY / sizeSegment;
            for (int i = 0; i < Nx; i++)
            {
                int startX = i * sizeSegment;
                int endX = startX + sizeSegment - 1;
                for (int j = 0; j < Ny; j++)
                {
                    int startY = j * sizeSegment;
                    int endY = startY + sizeSegment - 1;
                    C.Add(submatrix(B, startX, endX, startY, endY));
                }
            }
        }
      

        int[] ConvertToBits(byte num)
        {
           int [] bits = new int[8];
            for (int j = 0; j < 8; j++)
            {
                bits[j] = (num >> j) & 0x01;
            }
            return bits;
        }
        Byte ConvertToByte(int[] bits)
        {
            Byte res = Byte.MinValue;
            for (int j = 0, m = 1; j < 8; j++, m *= 2)
            {
                if (bits[j] == 1)
                {
                    if (j == 0)
                    {
                        res = (byte)m;
                    }
                    else { res += (byte)m; }
                }
                if (bits[j] == 0)
                {
                    if (j == 0)
                    {
                        res = (byte)0;
                    }
                    else { res += (byte)0; }
                }
            }
            return res;
        }

        private int GetKey(int key,int divider)
        {
            return (key.GetHashCode()) % divider;
        }

        private void sendMessToForm(String mess)
        {
            if (_form.InvokeRequired)
                _form.Invoke((MethodInvoker)delegate { _form.sendMess(mess); });
            else
                _form.sendMess(mess);
        }
        private void DeterminePointsOfCoefficients()
        {
            if (SizeOfSegment == 2)
            {
                p1 = new Point(1, 0);
                p2 = new Point(1, 1);
            }
            else if (SizeOfSegment == 4)
            {
                p1 = new Point(3, 2);
                p2 = new Point(2, 3);
            }
            else
            {
                p1 = new Point(6, 3);
                p2 = new Point(3, 6);
            }
        }
       
    }
}

    

