namespace DgtAutoCapcut;

public class CapCutProjectSettings
{
	public string VideoFolder { get; set; }

	public string AudioFolder { get; set; }

	public string CapcutFolder { get; set; }

	public string ProjectName { get; set; } = "Auto";

	public int DefaultDuration { get; set; } = 4;

	public string OutputFps { get; set; } = "60";

	public string AspectRatio { get; set; } = "16:9";

	public string OutputQuality { get; set; } = "1080p";
}
