namespace TurnTableDemo
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        private float roffset = 20;

        /// <summary>
        /// 大转盘旋转计时器
        /// </summary>
        private System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
        /// <summary>
        /// 设置旋转力度时用到的计时器
        /// </summary>
        private System.Windows.Forms.Timer t1 = new System.Windows.Forms.Timer();

        private readonly TurnTable Turn;

        public Form1()
        {
            InitializeComponent();
            t.Tick += T_Tick;
            t1.Tick += T1_Tick;
            Turn = new(pictureBox1.Handle, new List<string>() { "曹操", "刘备", "孙权", "郭嘉", "关羽", "周瑜", "荀彧", "张飞", "鲁肃" });
            Turn.Diameter = 800;
            richTextBox1_Validated(new object(), new EventArgs());

        }

        private int step = 1;
        private void T1_Tick(object? sender, EventArgs e)
        {
            if (progressBar1.Value <= progressBar1.Minimum) step = 1;
            if (progressBar1.Value >= progressBar1.Maximum) step = -1;
            progressBar1.Value += step;
        }

        private void T_Tick(object? sender, EventArgs e)
        {
            Turn.Draw();
            Turn.OffsetAngle = Turn.OffsetAngle >= 360 ? 0 : Turn.OffsetAngle + roffset;

            if (roffset > 0.1)  //当旋转角度小于0.1时就停止
            {
                roffset = roffset - roffset / 100;  //减速的幅度逐渐减小
            }
            else
            {
                roffset = 0;
                t.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnStart_MouseDown(object sender, MouseEventArgs e)
        {
            progressBar1.Value = progressBar1.Minimum;
            t1.Interval = 30;
            t1.Start();
        }

        private void BtnStart_MouseUp(object sender, MouseEventArgs e)
        {
            t1.Stop();
            roffset = progressBar1.Value;
            t.Interval = 1;
            t.Start();
        }

        private void richTextBox1_Validated(object sender, EventArgs e)
        {
        }

        private void BtnReady_Click(object sender, EventArgs e)
        {
            string[] strings = richTextBox1.Text.Split('\n');
            List<string> list = new();
            foreach (var name in strings)
            {
                list.Add(name);
            }
            Turn.Items = list;
            Turn.Draw();


            //绘制一个指针三角
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            Brush brush = new SolidBrush(Color.Black);
            g.FillPolygon(brush, new Point[] { new Point(Turn.Diameter, Turn.Radius), new Point(Turn.Diameter + 60, Turn.Radius + 20), new Point(Turn.Diameter + 60, Turn.Radius - 20) });

        }
    }
}