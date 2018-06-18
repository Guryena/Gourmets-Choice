using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gourmet_s_Choice.Helper;

namespace Gourmet_s_Choice.FoodUploadForm
{
    public partial class ImageUploader : Form
    {
        public ImageUploader()
        {
            InitializeComponent();
        }

        List<string> files = new List<string>();

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (fbdFolder.ShowDialog() != DialogResult.OK)
                return;

            //API로 "파일"을 가져오는 라이브러리가 제공된다
            files =
                Directory
                    .EnumerateFiles(fbdFolder.SelectedPath)
                    .Where(x => x.EndsWith(".png") || x.EndsWith(".jpg"))
                    .ToList(); //folder dialog 파일의 전체 경로를 stirng으로 반환
        
        }

        private void btnUpload_Click(object sender, EventArgs e)
        { 
            foreach (var file in files)
            {
                string fileName = Path.GetFileName(file);
                string strBlock = ".jpg";
                fileName = fileName.Replace(strBlock, "");
                txtFoodName.Text = fileName;

                //file read in Bitmap
                Bitmap image = new Bitmap(file);

                string thumbPath = $"C:\\Users\\KCCI\\Desktop\\Gourmet-s-Choice\\foodImage\\thumbnail\\thumbnail_{fileName}.jpg";
                Bitmap thumnailImage = image.Resize(400, 300, 1080, thumbPath);

                //file convert into binary
                Byte[] imageBytes = File.ReadAllBytes(file);
                Byte[] thumbnailBytes = File.ReadAllBytes(thumbPath);

                //DB접근
                DataRepository.FoodImage.InsertWithImage(txtFoodName.Text,
                    imageBytes, thumbnailBytes);

            }
        }
    }
}
