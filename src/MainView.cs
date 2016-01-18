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

namespace ExcitingRandom
{
	public partial class MainView : Form
	{
		public MainView()
		{
			InitializeComponent();

			mGrid.Rows.Add(5);
			mGrid.Rows[0].Cells[0].Value = "1";
			mGrid.Rows[1].Cells[0].Value = "1";

			OnGraphResize(null, null);
        }

		private void OnGridKeyDown(object sender, KeyEventArgs e)
		{
			if( e.KeyCode == Keys.Insert )
			{
				if( mGrid.SelectedRows.Count == 1 )
				{
					int index = mGrid.SelectedRows[0].Index;
					mGrid.Rows.Insert(index);

					mGrid.ClearSelection();

					var newCell = mGrid.Rows[index].Cells[0];

					newCell.Selected = true;
					mGrid.CurrentCell = newCell;
					mGrid.BeginEdit(true);
				}
			}
		}

		private void OnRawTextKeyDown(object sender, KeyEventArgs e)
		{
			if( e.KeyCode == Keys.Enter )
			{
				e.Handled = true;
				e.SuppressKeyPress = true;

				string str = mRawText.Text;

				List<string> values = str.Split(',').Select(x => x.Trim()).ToList();

				mGrid.Rows.Clear();

				foreach( string v in values )
				{
					mGrid.Rows.Add(v);
				}

				mGrid.Select();

				UpdateRawText();
			}
		}

		private void OnCellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
			UpdateRawText();
		}

		private void OnGridRowDeleted(object sender, DataGridViewRowEventArgs e)
		{
			UpdateRawText();
		}

		List<float> mValues;
		float mValueMax;
		BeatBurger.BBExcitingRandom mExcitingRandom;

		private void UpdateRawText()
		{
			// raw text에 반영한다.
			var list = new List<string>();
			for( int i = 0; i < mGrid.RowCount; i++ )
			{
				string value = mGrid.Rows[i].Cells[0].Value as string;

				if( String.IsNullOrEmpty(value) )
					break;

				list.Add(value);
			}

			mRawText.Text = String.Join(", ", list);

			// 그래프를 다시 그린다.
			mValues = list.Select(x =>
			{
				float v;
				float.TryParse(x.Trim(), out v);
				return v;
			}).ToList();

			if( mValues.Count >= 2 )
			{
				if( mDragging ==false )
					mValueMax = mValues.Max();

				if( mValueMax > 0 )
				{
					mValues = mValues.Select(x => x / mValueMax).ToList();

					mExcitingRandom = new BeatBurger.BBExcitingRandom(mValues.Select(x => (double)x).ToArray());

					mGraph.Invalidate();
				}
			}
		}

		Bitmap mGraphBmp;
		Matrix mMatrix;
		Matrix mInvMatrix;

		const int GraphMargin = 30;

		private void OnGraphResize(object sender, EventArgs e)
		{
			mGraphBmp = new Bitmap(mGraph.Width, mGraph.Height);

			mMatrix = new Matrix();
			mMatrix.Translate(GraphMargin, mGraph.Height - GraphMargin);
			mMatrix.Scale(mGraph.Width - 2 * GraphMargin, -mGraph.Height + 2 * GraphMargin);

			mInvMatrix = mMatrix.GetInverse();

			mGraph.Invalidate();
		}

		private void OnGraphPaint(object sender, PaintEventArgs e)
		{
			DrawGraphBmp();

			var g = e.Graphics;

			g.DrawImageUnscaled(mGraphBmp, 0, 0);
		}

		Brush mGraphBrush = new HatchBrush(HatchStyle.DarkVertical, Color.FromArgb(0x87, 0xaf, 0xe7), Color.FromArgb(0x54, 0x7f, 0xbc));
		Brush mMarkerBrush = new SolidBrush(Color.FromArgb(0x44, 0x50, 0x8c));
		Pen mMeanPen = new Pen(Color.DarkBlue, 3.0f) { DashStyle = DashStyle.Dash };

		private void DrawGraphBmp(bool updateMeanLabel=true)
		{
			Graphics g = Graphics.FromImage(mGraphBmp);
			g.DrawImage(Resource1.GraphBack, mGraph.ClientRectangle);

			float width = mGraphBmp.Width;
			float height = mGraphBmp.Height;

			// 그래프
			int count = mValues.Count;
			var pts = new List<PointF>(count);
			pts.Add(new PointF(0, 0.0f));

			for( int i = 0; i < count; i++ )
			{
				float x = (float)i / (count - 1);
				float y = mValues[i];

				pts.Add(new PointF(x, y));
			}

			pts.Add(new PointF(1.0f, 0.0f));

			var ptsArray = pts.ToArray();
			mMatrix.TransformPoints(ptsArray);

			g.FillPolygon(mGraphBrush, ptsArray);

			// 평균값 표시
			double mean = mExcitingRandom.Mean;
			float meanX = mMatrix.TransformPoint((float)mean, 0).X;

			g.DrawLine(mMeanPen, new PointF(meanX, 0), new PointF(meanX, height));

			if( updateMeanLabel )
			{
				double minValue = 0;
				double maxValue = 0;
				if( double.TryParse(mMinValue.Text, out minValue) &&
					double.TryParse(mMaxValue.Text, out maxValue) )
				{
					int x = (int)meanX;
					var pt = mMeanLabel.Location;
					pt.X = x + mGraph.Location.X - 48;
					mMeanLabel.Location = pt;

					double meanValue = minValue + (maxValue - minValue) * mean;

					mMeanLabel.Text = String.Format("평균: {0:F3}", meanValue);
					mMeanLabel.Visible = true;
				}
				else
				{
					mMeanLabel.Visible = false;
				}
			}

			// 드래그 마커
			int msize = 10;
			mMarkers = ptsArray.Skip(1).Take(count).Select(x => new RectangleF(x.X - msize, x.Y - msize, msize * 2, msize * 2)).ToArray();

			foreach( var mark in mMarkers )
			{
				RectangleF rect = mark;
				rect.Inflate(-6, -6);
				g.FillRectangle(mMarkerBrush, rect);
			}
		}

		private void OnMinMaxValueChanged(object sender, EventArgs e)
		{
			mGraph.Invalidate();
		}

		private void OnSimulationClick(object sender, EventArgs e)
		{
			mGraph.Invalidate();
			mGraph.Update();

			using( var g = mGraph.CreateGraphics() )
			{
				var uniformRnd = new Random();

				int dx = mGraph.Width - GraphMargin * 2;
				int dy = mGraph.Height - GraphMargin * 2;

				int iteration = (int)(dx * dy / mExcitingRandom.NormalizationFactor);

				int[] occurrence = new int[dx];

				int bottom = mGraph.Height - GraphMargin;

				for( int i = 0; i < iteration; i++ )
				{
					float x = (float)mExcitingRandom.Sample(uniformRnd.NextDouble());
					int ix = (int)(x * dx);

					int y = occurrence[ix]++;

					var brush = (ix & 0x01) == 0 ? Brushes.DarkRed : Brushes.OrangeRed;

					g.FillRectangle(brush, GraphMargin + ix, mGraph.Height - GraphMargin - y, 1, 1);
				}
			}
		}

		private void OnExitClick(object sender, EventArgs e)
		{
			Close();
		}

		private void OnNormalDistClick(object sender, EventArgs e)
		{
			mGrid.Rows.Clear();

			double stdDev = 2.5;

			for( int i = -7; i <= 7; i++ )
			{
				double p = -(i * i) / (2 * stdDev * stdDev);
				double v = Math.Exp(p);

				string str = String.Format("{0:F3}", v * 10);

				mGrid.Rows.Add(str);
			}

			mGrid.Select();

			UpdateRawText();
		}

		// 마커 드래깅
		RectangleF[] mMarkers;
		bool mDragging;
		int mDragMarkerIndex;

		private void OnGraphDown(object sender, MouseEventArgs e)
		{
			for( int i = 0; i < mMarkers.Length; i++ )
			{
				if( mMarkers[i].Contains(e.Location) )
				{
					mDragging = true;
					mDragMarkerIndex = i;
					mGraph.Capture = true;
				}
			}
		}

		private void OnGraphMove(object sender, MouseEventArgs e)
		{
			if( mDragging )
			{
				float v = Math.Max(0.0f, mInvMatrix.TransformPoint(e.X, e.Y).Y);

				mGrid.Rows[mDragMarkerIndex].Cells[0].Value = String.Format("{0:F3}", v * mValueMax);

				UpdateRawText();
			}
		}

		private void OnGraphUp(object sender, MouseEventArgs e)
		{
			if( mDragging )
			{
				mDragging = false;
				mGraph.Capture = false;

				UpdateRawText();
            }
		}
	}

	static public class MatrixExt
	{
		static public PointF TransformPoint(this Matrix m, float x, float y)
		{
			var pts = new PointF[1];
			pts[0].X = x;
			pts[0].Y = y;

			m.TransformPoints(pts);

			return pts[0];
		}

		static public Matrix GetInverse(this Matrix m)
		{
			var im = m.Clone();
			im.Invert();
			return im;
		}
	}
}
