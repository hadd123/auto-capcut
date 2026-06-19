using OpenCvSharp;

namespace DgtAutoCapcut;

public static class ProgressBarDetector
{
	public class ProgressBarResult
	{
		public bool Found;

		public Rect Bounds;

		public double FillPercent;

		public Mat Mask;
	}

	public static bool HasProgressBar(Mat windowCheck2)
	{
		if (windowCheck2 == null || windowCheck2.Empty())
		{
			return false;
		}
		Mat mat = windowCheck2.Clone();
		Mat mat2 = null;
		Mat mat3 = null;
		try
		{
			if (mat.Channels() == 4)
			{
				mat2 = new Mat();
				Cv2.CvtColor(mat, mat2, ColorConversionCodes.BGRA2GRAY);
			}
			else if (mat.Channels() == 3)
			{
				mat2 = new Mat();
				Cv2.CvtColor(mat, mat2, ColorConversionCodes.BGR2GRAY);
			}
			else
			{
				mat2 = mat.Clone();
			}
			mat3 = new Mat();
			Cv2.Threshold(mat2, mat3, 50.0, 255.0, ThresholdTypes.Binary);
			Cv2.FindContours(mat3, out Point[][] contours, out HierarchyIndex[] _, RetrievalModes.List, ContourApproximationModes.ApproxSimple);
			if (contours == null || contours.Length == 0)
			{
				return false;
			}
			int width = mat3.Width;
			_ = mat3.Height;
			for (int i = 0; i < contours.Length; i++)
			{
				Rect rect = Cv2.BoundingRect(contours[i]);
				if (!((double)rect.Width < (double)width * 0.3) && rect.Height <= 20 && rect.Left >= 30 && rect.Left <= mat3.Width / 2)
				{
					return true;
				}
			}
			return false;
		}
		finally
		{
			mat2?.Dispose();
			mat3?.Dispose();
			mat.Dispose();
		}
	}
}
