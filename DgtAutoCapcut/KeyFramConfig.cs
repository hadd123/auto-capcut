namespace DgtAutoCapcut;

public class KeyFramConfig
{
	public bool cbZoomInCheck { get; set; }

	public decimal ZoonInStart { get; set; }

	public decimal ZoonInEnd { get; set; }

	public decimal ZoonOutStart { get; set; }

	public decimal ZoonOutEnd { get; set; }

	public decimal ZoonInMoveX { get; set; }

	public decimal ZoonInMoveY { get; set; }

	public decimal X1 { get; set; }

	public decimal X2 { get; set; }

	public decimal Y1 { get; set; }

	public decimal Y2 { get; set; }

	public decimal timeStart { get; set; }

	public bool cbFulldurationTimeCheck { get; set; }

	public bool cbZoomOutCheck { get; set; }

	public bool cbZoomInMoveXCheck { get; set; }

	public bool cbZoomInMoveYCheck { get; set; }

	public KeyFramConfig()
	{
		cbZoomInCheck = true;
		ZoonInEnd = 150m;
		ZoonInStart = 100m;
		ZoonOutStart = 150m;
		ZoonOutEnd = 100m;
		cbFulldurationTimeCheck = true;
		ZoonInMoveX = 150m;
		ZoonInMoveY = 150m;
	}
}
