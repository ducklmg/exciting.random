using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeatBurger
{
	/*
		pdf : line-segment로 이루어진 확률분포함수 (probability distribution function)
		cdf : cumulative distribution function

		입력으로 들어온 pdf의 적분형태를 cdf로 미리 계산해 두고,
		샘플링할 때는 uniform distribution에 대해 cdf의 역함수를 
	*/
	class ExcitingRandom
	{
		List<CurveSegment> mCdf;

		public ExcitingRandom(double[] pdf)
		{
			int count = pdf.Length - 1;

			mCdf = new List<CurveSegment>(count);

			double overN = 1.0 / count;

			// 확률 총합이 1이 되도록 normalizing factor를 계산한다.
			double totalArea = 0.0f;
			for( int i = 1; i < count; i++ )
				totalArea += pdf[i];

			totalArea += (pdf[0] + pdf[count]) * 0.5;
			totalArea *= overN;

			double nf = 1.0 / totalArea;

			// 각 구간에 대한 cdf를 계산한다.
			double prevArea = 0.0;
			for( int i = 0; i < count; i++ )
			{
				var curve = new CurveSegment(i * overN, pdf[i] * nf, (i + 1) * overN, pdf[i + 1] * nf, prevArea);
				if( curve.a == 0 && curve.b == 0 )
				{
					// 확률이 0인 구간은 샘플링 되지 않도록 한다.
					continue;
				}

				mCdf.Add(curve);
				prevArea = curve.totalArea;
			}

			mCdf[mCdf.Count - 1].totalArea = 1.0f;
		}

		public double Sample(double uniformRandom)
		{
			foreach( var curve in mCdf )
			{
				if( uniformRandom < curve.totalArea )
				{
					return curve.Root(uniformRandom);
				}
			}

			return 0;
		}
	}

	class CurveSegment
	{
		// y = ax^2 + bx + c
		public double a, b, c;
		public double totalArea;

		public CurveSegment(double x1, double y1, double x2, double y2, double prevArea)
		{
			double dx = x2 - x1;

			double lineA = (y2 - y1) / dx;
			double area = dx * (y1 + y2) * 0.5;

			totalArea = prevArea + area;

			a = lineA * 0.5;
			b = (area - a * (x2 * x2 - x1 * x1)) / dx;
			c = prevArea - a * x1 * x1 - b * x1;
		}

		public double Root(double y)
		{
			if( a != 0 )
			{
				double d = b * b - 4 * a * (c - y);

				return (-b + Math.Sqrt(d)) / (2 * a);
			}
			else if( b != 0 )
			{
				return (y - c) / b;
			}

			return 0;
		}
	}
}