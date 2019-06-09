using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace gifSplitter
{
    public partial class GifGrater : Form
    {
        public GifGrater()
        {
            InitializeComponent();
        }

        private string pathOut;
        private string fileOut;

        private void openGif_Click(object sender, EventArgs e)
        {
            using (var selectFileDialog = new OpenFileDialog())
            {
                selectFileDialog.Filter = "GIF files (*.gif)|*.gif";
                selectFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                
                if (selectFileDialog.ShowDialog() == DialogResult.OK)
                {
                    gifInBox.Text = selectFileDialog.FileName;
                }

                pathOut = selectFileDialog.FileName.Remove(selectFileDialog.FileName.IndexOf('.'));
                gifOutBox.Text = pathOut;
                fileOut = selectFileDialog.SafeFileName.Remove(selectFileDialog.SafeFileName.IndexOf('.'));

            }
        }

        private void run_Click(object sender, EventArgs e){
                       
            if (gifInBox.Text == ""){
                MessageBox.Show("No gif selected!");
            } else {
                Directory.CreateDirectory(pathOut);
                spliceItup(gifInBox.Text);
            };
        }

        private void spliceItup(string pathIn) {

            display.Visible = true;
            run.Enabled = false;
            openGif.Enabled = false;
            Image gifImg = Image.FromFile(pathIn);
            FrameDimension dimension = new FrameDimension(gifImg.FrameDimensionsList[0]);
            int frameCount = gifImg.GetFrameCount(dimension);

            for (int i = 0; i < frameCount; i++){

                gifImg.SelectActiveFrame(new FrameDimension(gifImg.FrameDimensionsList[0]), i);
                var imageOut = new Bitmap(gifImg);
                string fileName = fileOut + i.ToString().PadLeft(4, '0');

                display.Image = imageOut;
                imageOut.Save(pathOut+"\\"+fileName+".png", ImageFormat.Png);
                display.Update();
            }

            run.Enabled = true;
            openGif.Enabled = true;
        }

    }
}

/*
    Icon made by Pixelmeetup
    from www.flaticon.com
    is licensed by Creative Commons BY 3.0
*/
