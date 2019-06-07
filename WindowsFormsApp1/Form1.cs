using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region 声明变量名
        public Bitmap image1;    //定义公用Bitmap对象
        public string FPath;   //打开图片的路径及名称
        public string PictureWidth;   //图片的宽度
        public string Pictureheight;  //图片的高度
        public string videoPath;
        public bool is_open1 = false;//播放视频
        public bool is_open2 = false;//录制视频
        public bool is_open3 = false;//图像处理
        public bool is_open4 = false;//图像保存
        public int interval = 25;
        public VideoCapture capture;
        public VideoWriter writer;
        Mat mat = new Mat();

        #endregion

        #region 窗体初始化
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        #region 打开图片
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "*.jpg,*.jpeg,*.bmp,*.gif,*.ico,*.png,*.tif,*.wmf|*.jpg;*.jpeg;*.bmp;*.gif;*.ico;*.png;*.tif;*.wmf";     //设置打开图像的类型
            openFileDialog1.ShowDialog();                        //打开对话框
            FPath = openFileDialog1.FileName;
            Console.WriteLine(FPath);
            pictureBox1.Image = Image.FromFile(FPath);            //显示打开图片
            image1 = new Bitmap(FPath);
            PictureWidth = image1.Width.ToString();              //图片宽度
            Pictureheight = image1.Height.ToString();            //图片高度  
            textBox1.Text = "图片名为： " + FPath + "   宽度： " + PictureWidth + "   高度： " + Pictureheight;    //状态栏提示信息

        }
        #endregion

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #region 删除图片
        private void 删除图片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            textBox1.Text = null;
        }
        #endregion

        #region 退出
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Close();
            if (capture != null)
                capture.Release();
            if (writer != null)
                writer.Release();
        }
        #endregion

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)  //关闭窗体执行事件
        {
            if (capture != null)
                capture.Release();
            if (writer != null)
                writer.Release();
        }

        #region 保存图片
        private void savetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "BMP|*.bmp|JPEG|*.jpeg|GIF|*.gif|PNG|*.png|TIF|*.tif";   //设置保存文件的格式
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string picPath = saveFileDialog1.FileName;     //保存文件的路径及文件名
                    string picType = picPath.Substring(picPath.LastIndexOf(".") + 1, (picPath.Length - picPath.LastIndexOf(".") - 1));
                    switch (picType)                //利用switch条件语句实现图片类型的转换
                    {
                        case "bmp":
                            image1.Save(picPath, ImageFormat.Bmp); break;
                        case "jpeg":
                            image1.Save(picPath, ImageFormat.Jpeg); break;
                        case "gif":
                            image1.Save(picPath, ImageFormat.Gif); break;
                        case "png":
                            image1.Save(picPath, ImageFormat.Png); break;
                        case "tif":
                            image1.Save(picPath, ImageFormat.Png); break;


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region  照相
        private void opencvsharpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cap = VideoCapture.FromCamera(CaptureDevice.Any);
            cap.Set(CaptureProperty.FrameWidth, 512);
            cap.Set(CaptureProperty.FrameHeight, 300);
            pictureBox1.Invalidate();
            cap.Read(mat);
            image1 = BitmapConverter.ToBitmap(mat);
            pictureBox1.Image = image1;
            textBox1.Text = "图像大小:" + cap.FrameWidth + "*" + cap.FrameHeight;
            cap.Release();
            cap.Dispose();
        }
        #endregion

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        #region 播放视频
        private void pictureBox1_Paint(string picType)
        {
            //Mat es = Cv2.GetStructuringElement(MorphShapes.Ellipse, new OpenCvSharp.Size(10, 10));//返回指定形状尺寸的结构元素
            //mats_clear();
            while (is_open1)
            {
                textBox1.Text = "图像格式:" + picType + "    fourcc:" + capture.FourCC + "     帧数:" + capture.Fps + "      图像大小:" + capture.FrameWidth + "*" + capture.FrameHeight + "       图片总帧数:" + capture.FrameCount;
                capture.Read(mat);
                if (mat.Empty())
                {
                    is_open1 = false;
                }
                else
                {

                    int sleepTime = (int)Math.Round(1000 / capture.Fps);
                    if (!is_open3)
                    {
                        pictureBox1.Image = mat.ToBitmap();
                    }
                    Cv2.WaitKey(sleepTime);

                }
            }
        }
        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is_open1 = true;
            pictureBox1.Refresh();//刷新图片
            if (is_open1)
            {
                openFileDialog1.Filter = "AVI|*.avi|RMVB|*.rmvb|RM|*.rm|ASF|*.asf|DIVX|*.divx|MPG|*.mpg|MPEG|*.mpeg|MPE|*.mpe|WMV|*.wmv|MP4|*.mp4|MKV|*.mkv|VOB|*.vob";     //设置打开视频的类型
                openFileDialog1.ShowDialog();
                videoPath = openFileDialog1.FileName;
                string picType = videoPath.Substring(videoPath.LastIndexOf(".") + 1, (videoPath.Length - videoPath.LastIndexOf(".") - 1));
                capture = new VideoCapture(videoPath);
                pictureBox1_Paint(picType);

            }
            else
            {
                pictureBox1.Image = null;
            }
        }
        #endregion

        private void 停止播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is_open1 = false;
            capture.Release();
        }

        #region 录制视频
        private void 录制视频ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is_open2 = true;
            capture = VideoCapture.FromCamera(CaptureDevice.Any);
            capture.Fps = 25;
            start_luzhi();
        }

        private void start_luzhi()      //图片显示摄像头信息
        {
            //capture = VideoCapture.FromCamera(CaptureDevice.Any);
            capture.Set(CaptureProperty.FrameWidth, 640);
            capture.Set(CaptureProperty.FrameHeight, 360);
            while (is_open2)
            {
                //textBox1.Text= capture.BackLight.ToString();     //读取摄像头属性
                textBox1.Text = "帧率:" + capture.Fps + "      图像大小" + capture.FrameWidth + "*" + capture.FrameHeight + "    fourcc:" + capture.FourCC + "    图片总帧数:" + capture.FrameCount;
                //pictureBox1.Invalidate();
                if (Class_public.fps != 0)
                {
                    capture.Fps = Class_public.fps;
                    Class_public.fps = 0;
                }
                if (Class_public.width != 0)
                {
                    capture.Set(CaptureProperty.FrameWidth, Class_public.width);
                    Class_public.width = 0;
                }
                if (Class_public.height != 0)
                {
                    capture.Set(CaptureProperty.FrameHeight, Class_public.height);
                    Class_public.height = 0;
                }
                capture.Read(mat);
                if (is_open4 == true)
                {
                    textBox1.Text = "writer是否运行:" + writer.IsOpened() + "    帧率:" + capture.Fps + "      图像大小" + capture.FrameWidth + "*" + capture.FrameHeight + "    fourcc:" + capture.FourCC + "    图片总帧数:" + capture.FrameCount;
                    writer.Write(mat);
                }
                if (!is_open3)
                {
                    image1 = BitmapConverter.ToBitmap(mat);
                    pictureBox1.Image = image1;
                }
                int sleepTime = (int)Math.Round(1000 / capture.Fps);
                Cv2.WaitKey(sleepTime);
            }
        }
        #endregion

        private void 停止录制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is_open2 = false;
            if (writer != null)
            {
                writer.Release();
            }
            capture.Release();
        }

        #region 识别动态图像
        private void 动态识别ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Mat es = Cv2.GetStructuringElement(MorphShapes.Ellipse, new OpenCvSharp.Size(10, 10));//返回指定形状尺寸的结构元素
            is_open3 = true;
            BackgroundSubtractorKNN bs = BackgroundSubtractorKNN.Create();//背景减法器
            Mat fgmask = new Mat();
            Mat fgmask_copy = new Mat();
            Mat fgmask_copy1 = new Mat();
            OpenCvSharp.Point[][] contours;
            OpenCvSharp.HierarchyIndex[] hier;
            int x, y, w, h;
            Rect rect;
            while (is_open3)
            {

                capture.Read(mat);
                if (mat.Empty())
                {
                    is_open3 = false;
                    Cv2.DestroyAllWindows();
                }
                else
                {
                    //int sleepTime = (int)Math.Round(1000 / capture.Fps);
                    //pictureBox1.Image = mat.ToBitmap();
                    //Cv2.WaitKey(sleepTime);
                    bs.Apply(mat, fgmask);
                    fgmask_copy = fgmask;
                    fgmask_copy1 = fgmask;
                    Cv2.Threshold(fgmask_copy, fgmask, 244, 255, ThresholdTypes.Binary);//图像灰度化
                    fgmask_copy = fgmask;
                    Cv2.Erode(fgmask_copy, fgmask, Cv2.GetStructuringElement(MorphShapes.Ellipse, new OpenCvSharp.Size(3, 3)), null, 2);//图像腐蚀
                    fgmask_copy = fgmask;
                    Cv2.Dilate(fgmask_copy, fgmask, Cv2.GetStructuringElement(MorphShapes.Ellipse, new OpenCvSharp.Size(8, 3)), null, 2);//图像膨胀
                    fgmask_copy = fgmask;
                    Cv2.FindContours(fgmask, out contours, out hier, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
                    foreach (OpenCvSharp.Point[] c in contours)
                    {
                        if (Cv2.ContourArea(c) > 1000)
                        {
                            rect = Cv2.BoundingRect(c);
                            x = rect.X;
                            y = rect.Y;
                            w = rect.Width;
                            h = rect.Height;
                            Cv2.Rectangle(mat, new OpenCvSharp.Point(x, y), new OpenCvSharp.Point(x + w, y + h), new Scalar(255, 255, 0), 2);
                        }

                    }
                    Cv2.CvtColor(fgmask_copy1, fgmask_copy, ColorConversionCodes.GRAY2BGR);
                    Cv2.NamedWindow("mog", 0);
                    Cv2.NamedWindow("thresh", 0);
                    Cv2.NamedWindow("diff", 0);
                    Cv2.NamedWindow("detection", 0);
                    Cv2.ResizeWindow("mog", 640, 360);
                    Cv2.ResizeWindow("thresh", 640, 360);
                    Cv2.ResizeWindow("diff", 640, 360);
                    Cv2.ResizeWindow("detection", 640, 360);
                    Cv2.ImShow("mog", fgmask_copy1);
                    Cv2.ImShow("thresh", fgmask);
                    Cv2.ImShow("diff", mat & fgmask_copy);
                    Cv2.ImShow("detection", mat);
                    int sleepTime = (int)Math.Round(1000 / capture.Fps);
                    Cv2.WaitKey(sleepTime);
                }
            }
            Cv2.DestroyAllWindows();
        }
        #endregion

        private void 停止识别ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is_open3 = false;
            Cv2.DestroyAllWindows();
        }
 
        private void 摄像头设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(is_open2);
            form.Show();
        }

        #region 摄像头保存
        private void 开始保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (is_open2 == true)
            {
                try
                {
                    saveFileDialog1.Tag = "请输入保存路径";
                    saveFileDialog1.Filter = "AVI|*.avi|RMVB|*.rmvb|RM|*.rm|ASF|*.asf|DIVX|*.divx|MPG|*.mpg|MPEG|*.mpeg|MPE|*.mpe|WMV|*.wmv|MP4|*.mp4|MKV|*.mkv|VOB|*.vob";   //设置保存文件的格式
                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string picPath = saveFileDialog1.FileName;     //保存文件的路径及文件名
                        writer = new VideoWriter(picPath, OpenCvSharp.FourCC.MJPG, capture.Fps, new OpenCvSharp.Size(capture.FrameWidth, capture.FrameHeight));
                        is_open4 = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("请打开摄像头");
            }
        }

        private void 暂停保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is_open4 = false;
        }

        private void 继续保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is_open4 = true;
        }

        private void 停止保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            is_open4 = false;
            writer.Release();
        }
        #endregion
    }
}
