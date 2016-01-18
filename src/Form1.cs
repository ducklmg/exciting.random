using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcitingRandom
{
	public partial class Form1 : Form
	{
		MyTrackBar[] mTracks;

		public Form1()
		{
			InitializeComponent();

			mTracks = new MyTrackBar[]
			{
				myTrackBar01,
				myTrackBar02,
				myTrackBar03,
				myTrackBar04,
				myTrackBar05,
				myTrackBar06,
				myTrackBar07,
				myTrackBar08,
				myTrackBar09,
				myTrackBar10,
				myTrackBar11,
				myTrackBar12,
				myTrackBar13,
				myTrackBar14,
				myTrackBar15,
				myTrackBar16,
				myTrackBar17,
				myTrackBar18,
				myTrackBar19,
				myTrackBar20
			};

			for(int i=0; i<mTracks.Length; i++)
			{
				int trackIdx = i;
				mTracks[i].ValueChanged += (v) =>
				{
					TrackValueChanged(trackIdx, v);
				};
			}
        }

		private void TrackValueChanged(int trackIdx, float value)
		{
			var rect = mTracks[trackIdx].ClientRectangle;
			rect.Offset(mTracks[trackIdx].Location);
			rect.Inflate(30, 0);

			Invalidate(rect);
		}

		private void OnPaint(object sender, PaintEventArgs e)
		{
			var g = e.Graphics;

			e.Graphics.FillRectangle(Brushes.LightSteelBlue, e.ClipRectangle);

			for( int i = 0; i < mTracks.Length - 1; i++ )
			{
				var a = mTracks[i];
				var b = mTracks[i + 1];

				g.DrawLine(Pens.Black, a.ThumbLocation(), b.ThumbLocation());
			}
		}

		protected override void OnPaintBackground(PaintEventArgs e)
		{
			//e.Graphics.FillRectangle(Brushes.LightSteelBlue, e.ClipRectangle);

			//base.OnPaintBackground(e);
		}
	}
}
