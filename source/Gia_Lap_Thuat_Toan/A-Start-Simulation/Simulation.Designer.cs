namespace A_Start_Simulation
{
    partial class Simulation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelTittle = new Label();
            buttonExit = new Label();
            buttonHidden = new Label();
            timerHidden = new System.Windows.Forms.Timer(components);
            timerExit = new System.Windows.Forms.Timer(components);
            groupGraph = new GroupBox();
            panelDraw = new Panel();
            groupPar = new GroupBox();
            panelGeneral = new Panel();
            panelRunStep = new Panel();
            buttonReset = new Button();
            buttonNext = new Button();
            buttonGo = new Button();
            buttonPre = new Button();
            labelStep = new Label();
            textStep = new TextBox();
            textEndPoint = new TextBox();
            textBeginPoint = new TextBox();
            labelEndPoint = new Label();
            labelFind = new Label();
            labelHeu = new Label();
            labelBeginPoint = new Label();
            listhValues = new ListBox();
            buttonImportRequest = new Button();
            btnImportGraph = new Button();
            labelP = new Label();
            labelOpenSet = new Label();
            textP = new TextBox();
            textOpenSet = new TextBox();
            textCloseSet = new TextBox();
            labelCloseSet = new Label();
            groupGraph.SuspendLayout();
            groupPar.SuspendLayout();
            panelGeneral.SuspendLayout();
            panelRunStep.SuspendLayout();
            SuspendLayout();
            // 
            // labelTittle
            // 
            labelTittle.BackColor = Color.White;
            labelTittle.Dock = DockStyle.Top;
            labelTittle.Font = new Font("Courier New", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelTittle.Location = new Point(0, 0);
            labelTittle.Name = "labelTittle";
            labelTittle.Size = new Size(1000, 32);
            labelTittle.TabIndex = 0;
            labelTittle.Text = "***********  A Start Algorithm Simulation  ***********";
            labelTittle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            buttonExit.AutoSize = true;
            buttonExit.BackColor = Color.White;
            buttonExit.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(974, 4);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(23, 23);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "X";
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonHidden
            // 
            buttonHidden.AutoSize = true;
            buttonHidden.BackColor = Color.White;
            buttonHidden.Font = new Font("Courier New", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonHidden.Location = new Point(945, 4);
            buttonHidden.Name = "buttonHidden";
            buttonHidden.Size = new Size(23, 23);
            buttonHidden.TabIndex = 1;
            buttonHidden.Text = "-";
            buttonHidden.Click += buttonHidden_Click;
            // 
            // timerHidden
            // 
            timerHidden.Interval = 10;
            timerHidden.Tick += timerHidden_Tick;
            // 
            // timerExit
            // 
            timerExit.Interval = 10;
            timerExit.Tick += timerExit_Tick;
            // 
            // groupGraph
            // 
            groupGraph.BackColor = Color.Transparent;
            groupGraph.Controls.Add(panelDraw);
            groupGraph.FlatStyle = FlatStyle.Flat;
            groupGraph.Font = new Font("Courier New", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            groupGraph.ForeColor = Color.Black;
            groupGraph.Location = new Point(12, 31);
            groupGraph.Name = "groupGraph";
            groupGraph.Size = new Size(635, 557);
            groupGraph.TabIndex = 2;
            groupGraph.TabStop = false;
            groupGraph.Text = "Graph";
            // 
            // panelDraw
            // 
            panelDraw.BackColor = Color.White;
            panelDraw.Dock = DockStyle.Fill;
            panelDraw.Location = new Point(3, 25);
            panelDraw.Name = "panelDraw";
            panelDraw.Size = new Size(629, 529);
            panelDraw.TabIndex = 0;
            panelDraw.Paint += panelDraw_Paint;
            // 
            // groupPar
            // 
            groupPar.BackColor = Color.Transparent;
            groupPar.Controls.Add(panelGeneral);
            groupPar.Controls.Add(buttonImportRequest);
            groupPar.Controls.Add(btnImportGraph);
            groupPar.Font = new Font("Courier New", 14.25F, FontStyle.Italic, GraphicsUnit.Point);
            groupPar.Location = new Point(653, 31);
            groupPar.Name = "groupPar";
            groupPar.Size = new Size(340, 557);
            groupPar.TabIndex = 3;
            groupPar.TabStop = false;
            groupPar.Text = "Parameter";
            // 
            // panelGeneral
            // 
            panelGeneral.Controls.Add(panelRunStep);
            panelGeneral.Controls.Add(textEndPoint);
            panelGeneral.Controls.Add(textBeginPoint);
            panelGeneral.Controls.Add(labelEndPoint);
            panelGeneral.Controls.Add(labelFind);
            panelGeneral.Controls.Add(labelHeu);
            panelGeneral.Controls.Add(labelBeginPoint);
            panelGeneral.Controls.Add(listhValues);
            panelGeneral.Location = new Point(15, 65);
            panelGeneral.Name = "panelGeneral";
            panelGeneral.Size = new Size(312, 486);
            panelGeneral.TabIndex = 1;
            // 
            // panelRunStep
            // 
            panelRunStep.Controls.Add(buttonReset);
            panelRunStep.Controls.Add(buttonNext);
            panelRunStep.Controls.Add(buttonGo);
            panelRunStep.Controls.Add(buttonPre);
            panelRunStep.Controls.Add(labelCloseSet);
            panelRunStep.Controls.Add(labelOpenSet);
            panelRunStep.Controls.Add(labelP);
            panelRunStep.Controls.Add(textCloseSet);
            panelRunStep.Controls.Add(labelStep);
            panelRunStep.Controls.Add(textOpenSet);
            panelRunStep.Controls.Add(textP);
            panelRunStep.Controls.Add(textStep);
            panelRunStep.Location = new Point(11, 295);
            panelRunStep.Name = "panelRunStep";
            panelRunStep.Size = new Size(286, 183);
            panelRunStep.TabIndex = 3;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReset.Location = new Point(12, 144);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(261, 36);
            buttonReset.TabIndex = 3;
            buttonReset.Text = "Khởi động lại";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonNext
            // 
            buttonNext.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonNext.Location = new Point(194, 40);
            buttonNext.Name = "buttonNext";
            buttonNext.Size = new Size(79, 36);
            buttonNext.TabIndex = 3;
            buttonNext.Text = "Sau";
            buttonNext.UseVisualStyleBackColor = true;
            buttonNext.Click += buttonNext_Click;
            // 
            // buttonGo
            // 
            buttonGo.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonGo.Location = new Point(105, 40);
            buttonGo.Name = "buttonGo";
            buttonGo.Size = new Size(83, 36);
            buttonGo.TabIndex = 3;
            buttonGo.Text = "Đến";
            buttonGo.UseVisualStyleBackColor = true;
            buttonGo.Click += buttonGo_Click;
            // 
            // buttonPre
            // 
            buttonPre.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPre.Location = new Point(12, 40);
            buttonPre.Name = "buttonPre";
            buttonPre.Size = new Size(87, 36);
            buttonPre.TabIndex = 3;
            buttonPre.Text = "Trước";
            buttonPre.UseVisualStyleBackColor = true;
            buttonPre.Click += buttonPre_Click;
            // 
            // labelStep
            // 
            labelStep.AutoSize = true;
            labelStep.Font = new Font("Courier New", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelStep.Location = new Point(12, 15);
            labelStep.Name = "labelStep";
            labelStep.Size = new Size(48, 17);
            labelStep.TabIndex = 2;
            labelStep.Text = "Bước:";
            // 
            // textStep
            // 
            textStep.Font = new Font("Courier New", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            textStep.Location = new Point(194, 12);
            textStep.Name = "textStep";
            textStep.Size = new Size(79, 22);
            textStep.TabIndex = 2;
            textStep.Text = "Chưa rõ";
            // 
            // textEndPoint
            // 
            textEndPoint.Font = new Font("Courier New", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            textEndPoint.Location = new Point(185, 43);
            textEndPoint.Name = "textEndPoint";
            textEndPoint.Size = new Size(112, 22);
            textEndPoint.TabIndex = 2;
            textEndPoint.Text = "Chưa rõ";
            // 
            // textBeginPoint
            // 
            textBeginPoint.Font = new Font("Courier New", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            textBeginPoint.Location = new Point(11, 43);
            textBeginPoint.Name = "textBeginPoint";
            textBeginPoint.Size = new Size(112, 22);
            textBeginPoint.TabIndex = 2;
            textBeginPoint.Text = "Chưa rõ";
            // 
            // labelEndPoint
            // 
            labelEndPoint.AutoSize = true;
            labelEndPoint.Font = new Font("Courier New", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelEndPoint.Location = new Point(184, 12);
            labelEndPoint.Name = "labelEndPoint";
            labelEndPoint.Size = new Size(120, 17);
            labelEndPoint.TabIndex = 1;
            labelEndPoint.Text = "Điểm kết thúc:";
            // 
            // labelFind
            // 
            labelFind.AutoSize = true;
            labelFind.Font = new Font("Courier New", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelFind.Location = new Point(12, 267);
            labelFind.Name = "labelFind";
            labelFind.Size = new Size(144, 17);
            labelFind.TabIndex = 1;
            labelFind.Text = "Đường đi: Chưa rõ";
            // 
            // labelHeu
            // 
            labelHeu.AutoSize = true;
            labelHeu.Font = new Font("Courier New", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelHeu.Location = new Point(11, 72);
            labelHeu.Name = "labelHeu";
            labelHeu.Size = new Size(264, 17);
            labelHeu.TabIndex = 1;
            labelHeu.Text = "Giá trị ước lượng hàm Heuristic:";
            // 
            // labelBeginPoint
            // 
            labelBeginPoint.AutoSize = true;
            labelBeginPoint.Font = new Font("Courier New", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelBeginPoint.Location = new Point(11, 12);
            labelBeginPoint.Name = "labelBeginPoint";
            labelBeginPoint.Size = new Size(112, 17);
            labelBeginPoint.TabIndex = 1;
            labelBeginPoint.Text = "Điểm bắt đầu:";
            // 
            // listhValues
            // 
            listhValues.Font = new Font("Courier New", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            listhValues.FormattingEnabled = true;
            listhValues.ItemHeight = 17;
            listhValues.Items.AddRange(new object[] { "Chưa rõ" });
            listhValues.Location = new Point(11, 97);
            listhValues.Name = "listhValues";
            listhValues.Size = new Size(289, 157);
            listhValues.TabIndex = 0;
            // 
            // buttonImportRequest
            // 
            buttonImportRequest.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonImportRequest.Location = new Point(174, 36);
            buttonImportRequest.Name = "buttonImportRequest";
            buttonImportRequest.Size = new Size(153, 23);
            buttonImportRequest.TabIndex = 0;
            buttonImportRequest.Text = "Import request...";
            buttonImportRequest.UseVisualStyleBackColor = true;
            buttonImportRequest.Click += buttonImportRequest_Click;
            // 
            // btnImportGraph
            // 
            btnImportGraph.Font = new Font("Courier New", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnImportGraph.Location = new Point(15, 36);
            btnImportGraph.Name = "btnImportGraph";
            btnImportGraph.Size = new Size(153, 23);
            btnImportGraph.TabIndex = 0;
            btnImportGraph.Text = "Import graph...";
            btnImportGraph.UseVisualStyleBackColor = true;
            btnImportGraph.Click += btnImportGraph_Click;
            // 
            // labelP
            // 
            labelP.AutoSize = true;
            labelP.Font = new Font("Courier New", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelP.Location = new Point(12, 84);
            labelP.Name = "labelP";
            labelP.Size = new Size(32, 17);
            labelP.TabIndex = 2;
            labelP.Text = "p =";
            // 
            // labelOpenSet
            // 
            labelOpenSet.AutoSize = true;
            labelOpenSet.Font = new Font("Courier New", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelOpenSet.Location = new Point(114, 84);
            labelOpenSet.Name = "labelOpenSet";
            labelOpenSet.Size = new Size(56, 17);
            labelOpenSet.TabIndex = 2;
            labelOpenSet.Text = "Open =";
            // 
            // textP
            // 
            textP.Font = new Font("Courier New", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            textP.Location = new Point(48, 82);
            textP.Name = "textP";
            textP.Size = new Size(61, 22);
            textP.TabIndex = 2;
            textP.Text = "Chưa rõ";
            // 
            // textOpenSet
            // 
            textOpenSet.Font = new Font("Courier New", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            textOpenSet.Location = new Point(173, 82);
            textOpenSet.Name = "textOpenSet";
            textOpenSet.Size = new Size(100, 22);
            textOpenSet.TabIndex = 2;
            textOpenSet.Text = "Chưa rõ";
            // 
            // textCloseSet
            // 
            textCloseSet.Font = new Font("Courier New", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            textCloseSet.Location = new Point(173, 109);
            textCloseSet.Name = "textCloseSet";
            textCloseSet.Size = new Size(100, 22);
            textCloseSet.TabIndex = 2;
            textCloseSet.Text = "Chưa rõ";
            // 
            // labelCloseSet
            // 
            labelCloseSet.AutoSize = true;
            labelCloseSet.Font = new Font("Courier New", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            labelCloseSet.Location = new Point(114, 112);
            labelCloseSet.Name = "labelCloseSet";
            labelCloseSet.Size = new Size(56, 17);
            labelCloseSet.TabIndex = 2;
            labelCloseSet.Text = "Close=";
            // 
            // Simulation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1000, 600);
            Controls.Add(groupPar);
            Controls.Add(groupGraph);
            Controls.Add(buttonHidden);
            Controls.Add(buttonExit);
            Controls.Add(labelTittle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Simulation";
            Text = "Simulation";
            Load += Simulation_Load;
            groupGraph.ResumeLayout(false);
            groupPar.ResumeLayout(false);
            panelGeneral.ResumeLayout(false);
            panelGeneral.PerformLayout();
            panelRunStep.ResumeLayout(false);
            panelRunStep.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTittle;
        private Label buttonExit;
        private Label buttonHidden;
        private System.Windows.Forms.Timer timerHidden;
        private System.Windows.Forms.Timer timerExit;
        private GroupBox groupGraph;
        private Panel panelDraw;
        private GroupBox groupPar;
        private Button buttonImportRequest;
        private Button btnImportGraph;
        private Panel panelGeneral;
        private ListBox listhValues;
        private TextBox textEndPoint;
        private TextBox textBeginPoint;
        private Label labelEndPoint;
        private Label labelBeginPoint;
        private Panel panelRunStep;
        private Label labelFind;
        private Label labelHeu;
        private Label labelStep;
        private TextBox textStep;
        private Button buttonReset;
        private Button buttonNext;
        private Button buttonGo;
        private Button buttonPre;
        private Label labelCloseSet;
        private Label labelOpenSet;
        private Label labelP;
        private TextBox textCloseSet;
        private TextBox textOpenSet;
        private TextBox textP;
    }
}