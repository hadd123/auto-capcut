using System.Collections.Generic;

namespace DgtAutoCapcut;

public class Config
{
	public string CapcutPath { get; set; }

	public int RandomAnimationEach { get; set; }

	public List<string> Effects { get; set; }

	public List<string> Transitions { get; set; }

	public List<string> Captions { get; set; }

	public int EffectDurationRate { get; set; }

	public decimal TransitionDuration { get; set; }

	public decimal AnimationDuration { get; set; }

	public bool IsAddEffectToImage { get; set; }

	public string VideoOverAudio { get; set; }

	public bool IsAutoTurnOff { get; set; }

	public int WaitRender { get; set; }

	public bool IsRender4k { get; set; }

	public bool IsMixAnimation { get; set; }

	public double VideoSyncPlus { get; set; }

	public KeyFramConfig KeyFramConfig { get; set; }

	public CapCutProjectSettings CapCutProjectSettings { get; set; } = new CapCutProjectSettings();

	public Config()
	{
		Effects = new List<string>();
		Transitions = new List<string>();
		Captions = new List<string>();
		EffectDurationRate = 100;
		TransitionDuration = 0.8m;
		AnimationDuration = 0.0m;
		KeyFramConfig = new KeyFramConfig();
		VideoOverAudio = "Tăng Tốc";
	}
}
