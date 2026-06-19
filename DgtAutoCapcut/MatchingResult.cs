using OpenCvSharp;

namespace DgtAutoCapcut;

public class MatchingResult
{
	public string Name { get; set; }

	public double Score { get; set; }

	public Point Pos { get; set; }

	public Point Center { get; set; }
}
