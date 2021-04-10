using System;

namespace APEx1
{
	public class ProbCalc
	{
		private int numberOfRows;
		private int choosenData;
		private double[42] data;
		private double[42] squareData;
		private double[42] multData;
		private double[42] avr;

		public ProbCalc(int i_choosenData)
		{
			this.numberOfRows = 0;
			if (i_choosenData < 0 || i_choosenData > 41)
			{
				this.choosenData = 0;
			} else
            {
				this.choosenData = i_choosenData;
            }
			for (int i = 0; i < 42; i++)
			{
				data[i] = 0;
				multData[i] = 0;
				squareData[i] = 0;
			}
		}

		public void addLine(float[] line)
        {
			numberOfRows++;
			for (int i = 0; i < 42; i++)
            {
				float t = line[i];
				multData[i] += t * line[choosenData];
				squareData[i] = t * t;
				data[i] += t;
				//avr[i] = data[i] / numberOfRows; 
            }
        }

		public double getAvg(int x)
        {
			if (x < 0 || x > 41)
            {
				return -1;
            } 
			else
            {
				return avr[x];
            }
        }

		public int gerCurData()
        {
			double[42] variance; 
			for (int i = 0; i < 42; i++)
			{
				avr[i] = data[i] / numberOfRows; //this is the expectation
				variance[i] = (squareData[i] / numberOfRows) - avr[i] * avr[i]; //variance = E[x^2]-E[x]^2 
			}

			double[42] covariance; 
			double[42] pearson;

			for (int i = 0; i < 42; i++)
			{
				covariance[i] = (multData[i] / numberOfRows) - avr[i] * avr[choosenData]; //covariance = E[xy]-E[x]E[y] 
				pearson[i] = covariance[i] / Math.Sqrt(variance[i] * variance[choosenData]);
			}

			pearson[choosenData] = 0;
			float maxVal = 0;
			int maxIndex;
			for (int i = 0; i < 42; i++)
			{
				if (pearson[i] > maxVal)
                {
					maxVal = pearson[i];
					maxIndex = i;
                }
			}
			return maxIndex; 
		}
	}
}
