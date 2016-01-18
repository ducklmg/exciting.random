namespace ExcitingRandom
{
	partial class MainView
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
			if( disposing && (components != null) )
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
			this.mGrid = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.mRawText = new System.Windows.Forms.TextBox();
			this.mGraph = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.mMinValue = new System.Windows.Forms.TextBox();
			this.mMaxValue = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.mMeanLabel = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.프리셋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.정규분포ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.시뮬레이션ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.mGrid)).BeginInit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mGraph)).BeginInit();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// mGrid
			// 
			this.mGrid.AllowUserToResizeColumns = false;
			this.mGrid.AllowUserToResizeRows = false;
			this.mGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.mGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.mGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.mGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Malgun Gothic", 9F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SteelBlue;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.mGrid.DefaultCellStyle = dataGridViewCellStyle1;
			this.mGrid.Location = new System.Drawing.Point(12, 27);
			this.mGrid.Name = "mGrid";
			this.mGrid.RowHeadersVisible = false;
			this.mGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.mGrid.RowTemplate.Height = 23;
			this.mGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.mGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.mGrid.ShowCellErrors = false;
			this.mGrid.ShowRowErrors = false;
			this.mGrid.Size = new System.Drawing.Size(103, 390);
			this.mGrid.StandardTab = true;
			this.mGrid.TabIndex = 1;
			this.mGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnCellValueChanged);
			this.mGrid.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.OnGridRowDeleted);
			this.mGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnGridKeyDown);
			// 
			// Column1
			// 
			this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Column1.HeaderText = "Values";
			this.Column1.MaxInputLength = 32;
			this.Column1.Name = "Column1";
			this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.mRawText);
			this.groupBox1.Location = new System.Drawing.Point(12, 435);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(623, 83);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Raw Data";
			// 
			// mRawText
			// 
			this.mRawText.AcceptsReturn = true;
			this.mRawText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mRawText.Font = new System.Drawing.Font("Malgun Gothic", 12F);
			this.mRawText.Location = new System.Drawing.Point(6, 22);
			this.mRawText.Multiline = true;
			this.mRawText.Name = "mRawText";
			this.mRawText.Size = new System.Drawing.Size(611, 55);
			this.mRawText.TabIndex = 2;
			this.mRawText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnRawTextKeyDown);
			// 
			// mGraph
			// 
			this.mGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.mGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.mGraph.Location = new System.Drawing.Point(128, 27);
			this.mGraph.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.mGraph.Name = "mGraph";
			this.mGraph.Size = new System.Drawing.Size(507, 359);
			this.mGraph.TabIndex = 42;
			this.mGraph.TabStop = false;
			this.mGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.OnGraphPaint);
			this.mGraph.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnGraphDown);
			this.mGraph.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnGraphMove);
			this.mGraph.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnGraphUp);
			this.mGraph.Resize += new System.EventHandler(this.OnGraphResize);
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(126, 396);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 15);
			this.label1.TabIndex = 44;
			this.label1.Text = "최소";
			// 
			// mMinValue
			// 
			this.mMinValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mMinValue.Location = new System.Drawing.Point(163, 393);
			this.mMinValue.Name = "mMinValue";
			this.mMinValue.Size = new System.Drawing.Size(73, 23);
			this.mMinValue.TabIndex = 3;
			this.mMinValue.Text = "0.0";
			this.mMinValue.TextChanged += new System.EventHandler(this.OnMinMaxValueChanged);
			// 
			// mMaxValue
			// 
			this.mMaxValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.mMaxValue.Location = new System.Drawing.Point(562, 393);
			this.mMaxValue.Name = "mMaxValue";
			this.mMaxValue.Size = new System.Drawing.Size(73, 23);
			this.mMaxValue.TabIndex = 4;
			this.mMaxValue.Text = "1.0";
			this.mMaxValue.TextChanged += new System.EventHandler(this.OnMinMaxValueChanged);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(526, 396);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 15);
			this.label2.TabIndex = 46;
			this.label2.Text = "최대";
			// 
			// mMeanLabel
			// 
			this.mMeanLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.mMeanLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.mMeanLabel.Location = new System.Drawing.Point(346, 392);
			this.mMeanLabel.Name = "mMeanLabel";
			this.mMeanLabel.Size = new System.Drawing.Size(120, 24);
			this.mMeanLabel.TabIndex = 48;
			this.mMeanLabel.Text = "평균";
			this.mMeanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.프리셋ToolStripMenuItem,
            this.시뮬레이션ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(647, 24);
			this.menuStrip1.TabIndex = 49;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// 파일ToolStripMenuItem
			// 
			this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
			this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
			this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
			this.파일ToolStripMenuItem.Text = "파일";
			// 
			// 종료ToolStripMenuItem
			// 
			this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
			this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.종료ToolStripMenuItem.Text = "종료";
			this.종료ToolStripMenuItem.Click += new System.EventHandler(this.OnExitClick);
			// 
			// 프리셋ToolStripMenuItem
			// 
			this.프리셋ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.정규분포ToolStripMenuItem});
			this.프리셋ToolStripMenuItem.Name = "프리셋ToolStripMenuItem";
			this.프리셋ToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
			this.프리셋ToolStripMenuItem.Text = "프리셋";
			// 
			// 정규분포ToolStripMenuItem
			// 
			this.정규분포ToolStripMenuItem.Name = "정규분포ToolStripMenuItem";
			this.정규분포ToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
			this.정규분포ToolStripMenuItem.Tag = "";
			this.정규분포ToolStripMenuItem.Text = "정규 분포";
			this.정규분포ToolStripMenuItem.Click += new System.EventHandler(this.OnNormalDistClick);
			// 
			// 시뮬레이션ToolStripMenuItem
			// 
			this.시뮬레이션ToolStripMenuItem.Name = "시뮬레이션ToolStripMenuItem";
			this.시뮬레이션ToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
			this.시뮬레이션ToolStripMenuItem.Text = "시뮬레이션";
			this.시뮬레이션ToolStripMenuItem.Click += new System.EventHandler(this.OnSimulationClick);
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(647, 530);
			this.Controls.Add(this.mMeanLabel);
			this.Controls.Add(this.mMaxValue);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.mMinValue);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mGraph);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.mGrid);
			this.Controls.Add(this.menuStrip1);
			this.Font = new System.Drawing.Font("Malgun Gothic", 9F);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MinimumSize = new System.Drawing.Size(492, 390);
			this.Name = "MainView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "느낌있는 랜덤";
			((System.ComponentModel.ISupportInitialize)(this.mGrid)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mGraph)).EndInit();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DataGridView mGrid;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox mRawText;
		private System.Windows.Forms.PictureBox mGraph;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox mMinValue;
		private System.Windows.Forms.TextBox mMaxValue;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label mMeanLabel;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 프리셋ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 정규분포ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 시뮬레이션ToolStripMenuItem;
	}
}