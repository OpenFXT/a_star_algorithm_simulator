using A_Start_Console;
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

namespace A_Start_Simulation
{
    public partial class Simulation : Form
    {
        public Simulation()
        {
            InitializeComponent();
        }

        private int mouseX = 0, mouseY = 0;
        private bool mouseDown = false;

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseX = e.X;
                mouseY = e.Y;
                mouseDown = true;
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Left += e.X - mouseX;
                this.Top += e.Y - mouseY;
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = false;
            }
        }

        private void ChangeFormLocation()
        {
            labelTittle.MouseDown += new MouseEventHandler(Form_MouseDown);
            labelTittle.MouseMove += new MouseEventHandler(Form_MouseMove);
            labelTittle.MouseUp += new MouseEventHandler(Form_MouseUp);
        }

        private void Simulation_Load(object sender, EventArgs e)
        {
            ChangeFormLocation();
            buttonImportRequest.Enabled = false;
            panelGeneral.Enabled = false;
            panelRunStep.Enabled = false;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            timerExit.Start();
        }

        private void buttonHidden_Click(object sender, EventArgs e)
        {
            timerHidden.Start();
        }

        private void timerHidden_Tick(object sender, EventArgs e)
        {
            double opacityStep = 0.05;
            this.Opacity -= opacityStep;
            if (this.Opacity <= 0)
            {
                timerHidden.Stop();
                this.WindowState = FormWindowState.Minimized;
                Opacity = 1;
            }
        }

        private void timerExit_Tick(object sender, EventArgs e)
        {
            double opacityStep = 0.05;
            this.Opacity -= opacityStep;
            if (this.Opacity <= 0)
            {
                timerHidden.Stop();
                Environment.Exit(0);
            }
        }

        private void Input_Data(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    n = int.Parse(sr.ReadLine());
                    matrix = new int[n, n];

                    for (int i = 0; i < n; i++)
                    {
                        string[] line = sr.ReadLine().Split(' ');
                        for (int j = 0; j < n; j++)
                        {
                            matrix[i, j] = int.Parse(line[j]);
                        }
                    }
                }
                buttonImportRequest.Enabled = true;
                algorithm.LoadMatrix(pathGraph_);
                panelDraw.Refresh();
            }
            catch
            {
                buttonImportRequest.Enabled = false;
                matrix = new int[,] { };
                Refresh();
                panelDraw.Refresh();
                MessageBox.Show("Có lỗi xảy ra trong quá trình đọc đồ thị", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private PointF MidPoint(PointF p1, PointF p2)
        {
            return new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
        }

        private int n = 0;
        private int[] arr = { -1 };
        private int[,] matrix;
        private string pathGraph_, pathRequest_;
        private A_Start_Algorithm algorithm = new A_Start_Algorithm();


        private void panelDraw_Paint(object sender, PaintEventArgs e)
        {
            if (this.n == 0)
            {
                return;
            }
            int n = matrix.GetLength(0);
            int r = 20;
            int w = panelDraw.Width;
            int h = panelDraw.Height;

            for (int i = 0; i < n; i++)
            {
                double angle = 2 * Math.PI * i / n;
                int x = (int)(w / 2 + (w / 2 - r - 10) * Math.Cos(angle));
                int y = (int)(h / 2 + (h / 2 - r - 10) * Math.Sin(angle));
                e.Graphics.FillEllipse(Brushes.White, x - r, y - r, 2 * r, 2 * r);
                e.Graphics.DrawEllipse(Pens.Black, x - r, y - r, 2 * r, 2 * r);
                e.Graphics.DrawString((i + 1).ToString(), Font, Brushes.Black, x - 8, y - 8);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        double angle1 = 2 * Math.PI * i / n;
                        int x1 = (int)(w / 2 + (w / 2 - r) * Math.Cos(angle1));
                        int y1 = (int)(h / 2 + (h / 2 - r) * Math.Sin(angle1));
                        double angle2 = 2 * Math.PI * j / n;
                        int x2 = (int)(w / 2 + (w / 2 - r) * Math.Cos(angle2));
                        int y2 = (int)(h / 2 + (h / 2 - r) * Math.Sin(angle2));

                        PointF midPoint = MidPoint(new PointF(x1, y1), new PointF(x2, y2));

                        e.Graphics.DrawString(matrix[i, j].ToString(), Font, Brushes.Black, midPoint.X, midPoint.Y);

                        if (arr.Contains(i) && arr.Contains(j))
                        {
                            Pen newPen = new Pen(Color.Red, 3);
                            e.Graphics.DrawLine(newPen, x2, y2, x1, y1);
                            float squareSize = 10;
                            float squareX = midPoint.X - squareSize / 2;
                            float squareY = midPoint.Y - squareSize / 2;
                            e.Graphics.FillRectangle(Brushes.Red, squareX, squareY, squareSize, squareSize);
                        }
                        else
                        {
                            Pen newPen = new Pen(Color.Black, 3);
                            e.Graphics.DrawLine(newPen, x1, y1, x2, y2);
                        }
                    }
                }
            }
        }

        private void btnImportGraph_Click(object sender, EventArgs e)
        {
            algorithm = new A_Start_Algorithm();
            arr = new int[] { -1 };
            buttonImportRequest.Enabled = false;
            listhValues.Items.Clear();
            listhValues.Items.Add("Chưa rõ");
            textBeginPoint.Text = "Chưa rõ";
            textEndPoint.Text = "Chưa rõ";
            labelFind.Text = "Chưa rõ";
            labelStep.Text = "Bước";
            textStep.Text = "Chưa rõ";
            panelRunStep.Enabled = false;
            panelGeneral.Enabled = false;
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            pathGraph_ = fileDialog.FileName;
            Input_Data(pathGraph_);
        }

        private void LoadAll(string[] hValues)
        {
            textBeginPoint.Text = $"{algorithm.begin + 1}";
            textEndPoint.Text = $"{algorithm.end + 1}";
            listhValues.Items.Clear();
            textEndPoint.Enabled = false;
            textBeginPoint.Enabled = false;
            for (int i = 0; i < hValues.Length; i++)
            {
                listhValues.Items.Add($"h({i + 1}) = {hValues[i]}");
            }
            arr = algorithm.Calc();
            if (arr == null)
            {
                algorithm.step = new List<int> { };
                labelFind.Text = "Đường đi: Không có đường đi";
                arr = new int[] { -1 };
                panelDraw.Refresh();
                return;
            }
            panelRunStep.Enabled = true;
            labelFind.Text = "Đường đi: Có đường đi";
            labelStep.Text = $"Bước(1 - {algorithm.step.Count}):";
            textStep.Text = algorithm.step.Count + "";
            UpdateStatus();
            panelDraw.Refresh();
        }

        private void buttonImportRequest_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();
            pathRequest_ = fileDialog.FileName;
            string[] hValues = algorithm.getRequest(pathRequest_);
            if (hValues == null)
            {
                arr = new int[] { -1 };
                listhValues.Items.Clear();
                Refresh();
                listhValues.Items.Add("Chưa rõ");
                textBeginPoint.Text = "Chưa rõ";
                textEndPoint.Text = "Chưa rõ";
                labelFind.Text = "Chưa rõ";
                labelStep.Text = "Bước";
                textStep.Text = "Chưa rõ";
                panelRunStep.Enabled = false;
                panelGeneral.Enabled = false;
                MessageBox.Show("Có lỗi xảy ra trong quá trình đọc yêu cầu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                panelDraw.Refresh();
                return;
            }
            panelGeneral.Enabled = true;
            LoadAll(hValues);
        }

        private void UpdateStatus()
        {
            textP.Text = $"{algorithm.step[int.Parse(textStep.Text) - 1] + 1}({algorithm.node[algorithm.step[int.Parse(textStep.Text) - 1]].getfValue()})";
            textOpenSet.Clear();
            textOpenSet.Text = algorithm.openStatus[int.Parse(textStep.Text) - 1];
            textCloseSet.Clear();
            textCloseSet.Text = algorithm.closeStatus[int.Parse(textStep.Text) - 1];
            
        }

        private void Refresh()
        {
            textOpenSet.Text = "Chưa rõ";
            textCloseSet.Text = "Chưa rõ";
            textP.Text = "Chưa rõ";
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textStep.Text) > 0 && int.Parse(textStep.Text) <= algorithm.step.Count)
                {
                    A_Start_Algorithm local = new A_Start_Algorithm();
                    local.LoadMatrix(pathGraph_);
                    local.getRequest(pathRequest_);
                    local.end = algorithm.step[int.Parse(textStep.Text) - 1];
                    int[] temp = new int[arr.Length];
                    Array.Copy(arr, temp, arr.Length);
                    arr = local.Calc();
                    panelDraw.Refresh();
                    arr = new int[temp.Length];
                    Array.Copy(temp, arr, temp.Length);
                    UpdateStatus();
                }
                else
                {
                    MessageBox.Show($"Vui lòng nhập trong giá trị từ 1 đến {algorithm.step.Count}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show($"Vui lòng nhập trong giá trị từ 1 đến {algorithm.step.Count}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonPre_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textStep.Text) > 1 && int.Parse(textStep.Text) <= algorithm.step.Count)
                {
                    textStep.Text = $"{int.Parse(textStep.Text) - 1}";
                    buttonGo_Click(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Hãy kiểm tra định dạng hiện tại trong ô số bước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(textStep.Text) > 0 && int.Parse(textStep.Text) < algorithm.step.Count)
                {
                    textStep.Text = $"{int.Parse(textStep.Text) + 1}";
                    buttonGo_Click(sender, e);
                }
            }
            catch
            {
                MessageBox.Show("Hãy kiểm tra định dạng hiện tại trong ô số bước", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            algorithm = new A_Start_Algorithm();
            arr = new int[] { -1 };
            buttonImportRequest.Enabled = false;
            Refresh();
            listhValues.Items.Clear();
            listhValues.Items.Add("Chưa rõ");
            textBeginPoint.Text = "Chưa rõ";
            textEndPoint.Text = "Chưa rõ";
            labelFind.Text = "Chưa rõ";
            labelStep.Text = "Bước";
            textStep.Text = "Chưa rõ";
            panelRunStep.Enabled = false;
            panelGeneral.Enabled = false;
            matrix = new int[,] { };
            panelDraw.Refresh();
        }
    }
}
