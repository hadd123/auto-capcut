using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Core.EntityClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DgtAutoCapcut.Properties;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace DgtAutoCapcut;

public class Form1 : Form
{
	public static string username = "";

	public static string password = "";

	public static long maxthread = 0L;

	private List<Capcut.CommonAttr> animationDefines = new List<Capcut.CommonAttr>();

	private List<Capcut.CommonAttr> effectDefines = new List<Capcut.CommonAttr>();

	private List<Capcut.CommonAttr> transitionDefines = new List<Capcut.CommonAttr>();

	private List<Capcut.CommonAttr> captionDefines = new List<Capcut.CommonAttr>();

	private List<Capcut.AllDraftStore> projects = new List<Capcut.AllDraftStore>();

	private List<Capcut.Category> categories = new List<Capcut.Category>();

	private Config progConf = new Config();

	private Random rd = new Random();

	private bool isShow;

	private List<ImageTemplate> imgTemplates = new List<ImageTemplate>();

	private string exportDirectory = "";

	public static int BrandType = 0;

	private bool isRendering;

	private IContainer components;

	private Button btnSave;

	private TabControl tabMain;

	private TabPage tabAnimation;

	private TabPage tabEffect;

	private TabPage tabTransitions;

	private TabControl tabControl2;

	private TabPage tabIn;

	private TabPage tabOut;

	private TabPage tabCombo;

	private DataGridView dgvAnimationIn;

	private DataGridView dgvAnimationOut;

	private DataGridView dgvAnimationCombo;

	private GroupBox gbSettings;

	private GroupBox groupBox1;

	private Label label1;

	private TextBox txtCapcutPath;

	private EntityCommand entityCommand1;

	private DataGridView dgvProject;

	private CheckBox ckAllProj;

	private Button btnAddAnimation;

	private Label label2;

	private NumericUpDown nRandomAnimationEach;

	private CheckBox ckCombo;

	private CheckBox ckOut;

	private CheckBox ckIn;

	private Button btnRemoveAllAnimation;

	private Button btnRefresh;

	private Button btnAutoRender;

	private TextBox txtSearchEffect;

	private Label label3;

	private ListBox lstSearchEffectResult;

	private ListBox lstEffectUse;

	private Button btnRemoveEffect;

	private Button btnAddEffect;

	private Label label4;

	private NumericUpDown nEffectDurationRate;

	private Label label5;

	private ListBox lstSearchTransitionResult;

	private TextBox txtSearchTransition;

	private Label label7;

	private Label label6;

	private NumericUpDown nTransitionDuration;

	private Label label8;

	private Button btnRemoveTransition;

	private Button btnAddTransiton;

	private ListBox lstTransitionUse;

	private Button btnAddEffects;

	private Button btnRemoveAllEffects;

	private Button btnAddTransitions;

	private Button btnRemoveAllTransitions;

	private Button btnSyncSound;

	private Label lblLicense;

	private System.Windows.Forms.Timer timer1;

	private Label label9;

	private TextBox txtExportPath;

	private Button btnOutput;

	private Label label10;

	private NumericUpDown nAnimationTime;

	private Label label11;

	private Label label12;

	private Label label13;

	private CheckBox ckAddEffect2Image;

	private GroupBox groupBox2;

	private TabPage tabCaptions;

	private Button btnGenerateCaption;

	private Button btnAddCaptionAnimation;

	private Button button2;

	private Button btnRemoveCaptionAnimationConfig;

	private Button btnAddCaptionAnimationConfig;

	private ListBox lstCaptionAnimationConfig;

	private ListBox lstCaptionAnimation;

	private TextBox txtSearchCaptionAnimation;

	private Label label14;

	private Label label15;

	private Label label16;

	private Label label17;

	private NumericUpDown nAddCaptionAnimationDuration;

	private Label label18;

	private CheckBox ckAutoOff;

	private NumericUpDown nWaitRender;

	private Label label19;

	private Label label20;

	private Button btnUpdate;

	private CheckBox ck4K;

	private GroupBox groupBox3;

	private TabPage tabKeyFrames;

	private Label label23;

	private Label label27;

	private Label label24;

	private NumericUpDown nStartKeyFrames;

	private Button btnAddKeyFrames;

	private Button btnClearKeyFrames;

	private Label label25;

	private Label label22;

	private Label label28;

	private Label label21;

	private Label label29;

	private Label label26;

	private CheckBox cbFulldurationtime;

	private Label label31;

	private Label label30;

	private NumericUpDown Y1;

	private NumericUpDown Y2;

	private NumericUpDown X2;

	private NumericUpDown X1;

	private NumericUpDown nbZoomOutEnd;

	private NumericUpDown nbZoomOutStart;

	private NumericUpDown nbZoomInMoveY;

	private NumericUpDown nbZoomInEnd;

	private NumericUpDown nbZoomInStart;

	private NumericUpDown nbZoomInMoveX;

	private CheckBox cbZoomMoveY;

	private CheckBox cbZoomMoveX;

	private CheckBox cbZoomout;

	private CheckBox cbZoomIn;

	private TabPage tabExportSrt;

	private Button btnExportSrt;

	private Button btnStop;

	private Button btnSplitVideoBySrt;

	private Button btnMergeAudio;

	private Label label32;

	private ComboBox cbbVideoOverAudio;

	private CheckBox ckMixAnimation;

	private Button btnOneClickSync;

	private Button btnCompoundClip;

	private TabPage tabCreateProj;

	private TextBox txtVideoDataPath;

	private Label label33;

	private Button btnSelectVideoResouce;

	private Button btnSelectAudioResouce;

	private TextBox txtAudioDataPath;

	private Label label34;

	private Label label35;

	private NumericUpDown nImageDuration;

	private Label label36;

	private ComboBox cbbCreateProjRatio;

	private Label label37;

	private ComboBox cbbCreateProjFps;

	private Label label39;

	private ComboBox cbbCreateProjQuality;

	private Label label38;

	private TextBox txtProjName;

	private Label label40;

	private Button btnCreateProj;

	private Label lblSubtitle;

	private LinkLabel lblCreateStatus;

	private Button btnOutputSrt;

	private Label label41;

	private NumericUpDown nVideoSyncPlus;

	private Label label42;

	[DllImport("DgtCore.dll", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.BStr)]
	private static extern string CheckProfilePid(string datainput);

	[DllImport("DgtCore.dll", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.BStr)]
	private static extern string CheckFunction(string datainput);

	[DllImport("DgtCore.dll", CallingConvention = CallingConvention.Cdecl)]
	[return: MarshalAs(UnmanagedType.BStr)]
	private static extern string CheckProject(string datainput);

	public Form1()
	{
		InitializeComponent();
		base.AutoScaleMode = AutoScaleMode.None;
		progConf = ConfigController.GetConfig();
		nRandomAnimationEach.Value = progConf.RandomAnimationEach;
		nTransitionDuration.Value = progConf.TransitionDuration;
		nEffectDurationRate.Value = progConf.EffectDurationRate;
		ListBox.ObjectCollection items = lstTransitionUse.Items;
		object[] items2 = progConf.Transitions.ToArray();
		items.AddRange(items2);
		ListBox.ObjectCollection items3 = lstEffectUse.Items;
		items2 = progConf.Effects.ToArray();
		items3.AddRange(items2);
		nAnimationTime.Value = progConf.AnimationDuration;
		ckAddEffect2Image.Checked = progConf.IsAddEffectToImage;
		cbbVideoOverAudio.SelectedItem = progConf.VideoOverAudio;
		ckAutoOff.Checked = progConf.IsAutoTurnOff;
		nWaitRender.Value = progConf.WaitRender;
		ck4K.Checked = progConf.IsRender4k;
		cbFulldurationtime.Checked = progConf.KeyFramConfig.cbFulldurationTimeCheck;
		cbZoomIn.Checked = progConf.KeyFramConfig.cbZoomInCheck;
		cbZoomMoveX.Checked = progConf.KeyFramConfig.cbZoomInMoveXCheck;
		cbZoomMoveY.Checked = progConf.KeyFramConfig.cbZoomInMoveYCheck;
		cbZoomout.Checked = progConf.KeyFramConfig.cbZoomOutCheck;
		nStartKeyFrames.Value = progConf.KeyFramConfig.timeStart;
		nbZoomInEnd.Value = progConf.KeyFramConfig.ZoonInEnd;
		nbZoomInStart.Value = progConf.KeyFramConfig.ZoonInStart;
		nbZoomOutStart.Value = progConf.KeyFramConfig.ZoonOutStart;
		nbZoomOutEnd.Value = progConf.KeyFramConfig.ZoonOutEnd;
		X1.Value = progConf.KeyFramConfig.X1;
		X2.Value = progConf.KeyFramConfig.X2;
		Y1.Value = progConf.KeyFramConfig.Y1;
		Y2.Value = progConf.KeyFramConfig.Y2;
		nbZoomInMoveX.Value = progConf.KeyFramConfig.ZoonInMoveX;
		nbZoomInMoveY.Value = progConf.KeyFramConfig.ZoonInMoveY;
		ckMixAnimation.Checked = progConf.IsMixAnimation;
		txtProjName.Text = progConf.CapCutProjectSettings.ProjectName;
		cbbCreateProjFps.SelectedItem = progConf.CapCutProjectSettings.OutputFps;
		cbbCreateProjQuality.SelectedItem = progConf.CapCutProjectSettings.OutputQuality;
		cbbCreateProjRatio.SelectedItem = progConf.CapCutProjectSettings.AspectRatio;
		nImageDuration.Value = progConf.CapCutProjectSettings.DefaultDuration;
		txtAudioDataPath.Text = progConf.CapCutProjectSettings.AudioFolder;
		txtVideoDataPath.Text = progConf.CapCutProjectSettings.VideoFolder;
		nVideoSyncPlus.Value = (decimal)progConf.VideoSyncPlus;
	}

	public async Task<List<Capcut.CommonAttr>> GetData(string category)
	{
		_ = 1;
		try
		{
			HttpClient val = new HttpClient();
			HttpRequestMessage val2 = new HttpRequestMessage(HttpMethod.Post, "https://capcut.dgvant.com/api/Capcut/get_data");
			StringContent content = new StringContent("{\r\n  \"apikey\": \"string\",\r\n  \"username\": \"string\",\r\n  \"password\": \"string\",\r\n  \"category\": \"" + category + "\",\r\n  \"items\": [\r\n    \"string\"\r\n  ]\r\n}", (Encoding)null, "application/json");
			val2.Content = (HttpContent)(object)content;
			HttpResponseMessage obj = await val.SendAsync(val2);
			obj.EnsureSuccessStatusCode();
			return JsonConvert.DeserializeObject<Capcut.GetDataResponse>(await obj.Content.ReadAsStringAsync()).items;
		}
		catch (Exception)
		{
		}
		return new List<Capcut.CommonAttr>();
	}

	public bool Precheck()
	{
		CheckFunction("Edit");
		HmacSha256Hex("Edit", "Edit");
		if (1 == 0)
		{
			MessageBox.Show("Gói của bạn không có chức năng này");
			return false;
		}
		if (MessageBox.Show("*******************\n\nHãy đảm bảo Project Capcut đã tắt \nvà các hiệu ứng bạn sử dụng \nđã được tải về trước khi thực hiện !\n\n*******************", "Auto Capcut Pro", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) != DialogResult.OK)
		{
			return false;
		}
		return true;
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		if (Login.Extra.Contains("Render"))
		{
			btnAutoRender.Enabled = true;
		}
		if (Login.Extra.Contains("Edit"))
		{
			btnGenerateCaption.Enabled = true;
			btnExportSrt.Enabled = true;
		}
		if (Login.Extra.Contains("Edit"))
		{
			btnAddTransitions.Enabled = true;
			btnRemoveAllTransitions.Enabled = true;
			btnClearKeyFrames.Enabled = true;
			btnAddKeyFrames.Enabled = true;
			btnAddAnimation.Enabled = true;
			btnRemoveAllAnimation.Enabled = true;
			btnAddEffects.Enabled = true;
			btnRemoveAllEffects.Enabled = true;
			btnSyncSound.Enabled = true;
			btnExportSrt.Enabled = true;
		}
		if (string.IsNullOrEmpty(progConf.CapcutPath) || !Directory.Exists(progConf.CapcutPath))
		{
			progConf.CapcutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Capcut");
		}
		txtCapcutPath.Text = progConf.CapcutPath;
		if (!Directory.Exists(Path.Combine(progConf.CapcutPath, "User Data")))
		{
			MessageBox.Show("Hãy đảm bảo Capcut đã được cài đặt và đường dẫn Capcut được cài đặt chính xác !");
			return;
		}
		exportDirectory = Path.Combine(progConf.CapcutPath, "Videos");
		string keyName = "HKEY_CURRENT_USER\\SOFTWARE\\Bytedance\\CapCut\\Modules\\Export";
		string valueName = "ExportPath";
		try
		{
			object value = Registry.GetValue(keyName, valueName, null);
			if (value != null)
			{
				exportDirectory = value.ToString();
			}
		}
		catch (Exception)
		{
		}
		txtExportPath.Text = exportDirectory;
		new Thread(LoadData).Start();
	}

	public async void LoadData()
	{
		categories = JsonConvert.DeserializeObject<List<Capcut.Category>>(Resources.category);
		animationDefines = CapcutController.GetAll("video");
		effectDefines = CapcutController.GetAll("effects2");
		transitionDefines = CapcutController.GetAll("transitions");
		captionDefines = CapcutController.GetAll("text");
		if (animationDefines.Count == 0)
		{
			animationDefines = await GetData("video");
			CapcutController.InsertBulk("video", animationDefines);
		}
		if (effectDefines.Count == 0)
		{
			effectDefines = await GetData("effects2");
			CapcutController.InsertBulk("effects2", effectDefines);
		}
		if (transitionDefines.Count == 0)
		{
			transitionDefines = await GetData("transitions");
			CapcutController.InsertBulk("transitions", transitionDefines);
		}
		if (captionDefines.Count == 0)
		{
			captionDefines = await GetData("text");
			CapcutController.InsertBulk("text", captionDefines);
		}
		animationDefines = animationDefines.OrderBy((Capcut.CommonAttr x) => x.title).ToList();
		Invoke((Action)delegate
		{
			dgvAnimationIn.DataSource = null;
			dgvAnimationIn.DataSource = animationDefines.FindAll((Capcut.CommonAttr x) => x.category_ids.Contains(6824)).ToList();
			int count = dgvAnimationIn.Columns.Count;
			for (int num = 1; num < count; num++)
			{
				if (!dgvAnimationIn.Columns[num].HeaderText.Contains("title"))
				{
					dgvAnimationIn.Columns[num].Visible = false;
				}
				else
				{
					dgvAnimationIn.Columns[num].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				}
				dgvAnimationIn.Columns[num].ReadOnly = true;
			}
			dgvAnimationIn.Columns[0].Width = 33;
			dgvAnimationIn.Columns[0].HeaderText = "";
			dgvAnimationIn.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			dgvAnimationOut.DataSource = null;
			dgvAnimationOut.DataSource = animationDefines.FindAll((Capcut.CommonAttr x) => x.category_ids.Contains(6825)).ToList();
			count = dgvAnimationOut.Columns.Count;
			for (int num2 = 1; num2 < count; num2++)
			{
				if (!dgvAnimationOut.Columns[num2].HeaderText.Contains("title"))
				{
					dgvAnimationOut.Columns[num2].Visible = false;
				}
				else
				{
					dgvAnimationOut.Columns[num2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				}
				dgvAnimationOut.Columns[num2].ReadOnly = true;
			}
			dgvAnimationOut.Columns[0].Width = 33;
			dgvAnimationOut.Columns[0].HeaderText = "";
			dgvAnimationOut.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
			dgvAnimationCombo.DataSource = null;
			dgvAnimationCombo.DataSource = animationDefines.FindAll((Capcut.CommonAttr x) => x.category_ids.Contains(6826)).ToList();
			count = dgvAnimationCombo.Columns.Count;
			for (int num3 = 1; num3 < count; num3++)
			{
				if (!dgvAnimationCombo.Columns[num3].HeaderText.Contains("title"))
				{
					dgvAnimationCombo.Columns[num3].Visible = false;
				}
				else
				{
					dgvAnimationCombo.Columns[num3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				}
				dgvAnimationCombo.Columns[num3].ReadOnly = true;
			}
			dgvAnimationCombo.Columns[0].Width = 33;
			dgvAnimationCombo.Columns[0].HeaderText = "";
			dgvAnimationCombo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
		});
		LoadTemplateData();
		LoadCapcutProj();
		Invoke((MethodInvoker)delegate
		{
			btnUpdate.Enabled = true;
		});
	}

	public void LoadTemplateData()
	{
		imgTemplates.Clear();
		string path = Path.Combine(Environment.CurrentDirectory, "images");
		if (!Directory.Exists(path))
		{
			return;
		}
		DirectoryInfo[] directories = new DirectoryInfo(path).GetDirectories();
		foreach (DirectoryInfo directoryInfo in directories)
		{
			FileInfo[] files = new DirectoryInfo(directoryInfo.FullName).GetFiles("*.png");
			foreach (FileInfo fileInfo in files)
			{
				string text = fileInfo.Name.Replace(fileInfo.Extension, "");
				Mat img = new Mat(fileInfo.FullName);
				imgTemplates.Add(new ImageTemplate
				{
					Group = directoryInfo.Name,
					Name = directoryInfo.Name + "_" + text,
					Img = img
				});
			}
		}
	}

	public void LoadCapcutProj()
	{
		string text = Path.Combine(progConf.CapcutPath, "User Data", "Projects", "com.lveditor.draft", "root_meta_info.json");
		if (File.Exists(text))
		{
			try
			{
				Capcut.Project project = JsonConvert.DeserializeObject<Capcut.Project>(File.ReadAllText(text));
				projects = project.all_draft_store;
				List<Capcut.AllDraftStore> projectListConfig = ConfigController.GetProjectListConfig();
				foreach (Capcut.AllDraftStore item in projects)
				{
					Capcut.AllDraftStore allDraftStore = projectListConfig.Find((Capcut.AllDraftStore x) => x.draft_name == item.draft_name);
					if (allDraftStore != null)
					{
						item.status = allDraftStore.status;
					}
				}
				Invoke((Action)delegate
				{
					dgvProject.DataSource = null;
					dgvProject.DataSource = projects;
					int count = dgvProject.Columns.Count;
					for (int i = 1; i < count; i++)
					{
						if (!dgvProject.Columns[i].HeaderText.Contains("draft_name") && !dgvProject.Columns[i].HeaderText.Contains("status"))
						{
							dgvProject.Columns[i].Visible = false;
						}
						if (dgvProject.Columns[i].HeaderText.Contains("draft_name"))
						{
							dgvProject.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
						}
						dgvProject.Columns[i].ReadOnly = true;
					}
					dgvProject.Columns[0].HeaderText = "";
					dgvProject.Columns[0].Width = 33;
					dgvProject.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
					dgvProject.Columns["draft_name"].Width = 99;
				});
				return;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}
		MessageBox.Show("Không tìm thấy file\n" + text);
	}

	private void btnSave_Click(object sender, EventArgs e)
	{
		if (!Directory.Exists(Path.Combine(progConf.CapcutPath, "User Data")))
		{
			MessageBox.Show("Hãy đảm bảo Capcut đã được cài đặt và đường dẫn Capcut được cài đặt chính xác !");
			return;
		}
		progConf.CapcutPath = txtCapcutPath.Text;
		animationDefines.FindAll((Capcut.CommonAttr x) => x.isSelected);
		CapcutController.InsertBulk("video", animationDefines);
		ConfigController.Insert(progConf);
	}

	private void tabOut_Enter(object sender, EventArgs e)
	{
	}

	private void ckAllProj_CheckedChanged(object sender, EventArgs e)
	{
		projects.ForEach(delegate(Capcut.AllDraftStore x)
		{
			x.isSelected = ckAllProj.Checked;
		});
		dgvProject.Invalidate();
	}

	private void nRandomAnimationEach_ValueChanged(object sender, EventArgs e)
	{
		progConf.RandomAnimationEach = (int)nRandomAnimationEach.Value;
	}

	public void RemoveAllAnimation(string material_type)
	{
		new _02B4022E()._1CBB33BE(new object[2] { this, material_type }, 139262);
	}

	public static string HmacSha256Hex(string key, string data)
	{
		return CheckFunction(key);
	}

	private static string ToHexLower(byte[] bytes)
	{
		StringBuilder stringBuilder = new StringBuilder(bytes.Length * 2);
		for (int i = 0; i < bytes.Length; i++)
		{
			stringBuilder.Append(bytes[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	public void EnsureArray(JObject obj, string key)
	{
		if (!(obj[key] is JArray))
		{
			obj[key] = new JArray();
		}
	}

	public void CreateComboundClip()
	{
		new _02B4022E()._1CBB33BE(new object[1] { this }, 39805);
	}

	private static string NewId()
	{
		return Guid.NewGuid().ToString().ToUpper();
	}

	private static long RoundToFrameBoundary(double durationSeconds)
	{
		double num = durationSeconds * 1000000.0;
		double num2 = 16666.666666666668;
		return (long)((double)(long)Math.Ceiling(num / num2) * num2);
	}

	public string GetUniqueFolderName(string parentPath, string folderName)
	{
		if (!Directory.Exists(Path.Combine(parentPath, folderName)))
		{
			return folderName;
		}
		int num = 1;
		string text;
		do
		{
			text = $"{folderName} ({num})";
			num++;
		}
		while (Directory.Exists(Path.Combine(parentPath, text)));
		return text;
	}

	public Capcut.ProjectResult CreateSimpleProject(List<Capcut.MediaFile> mediaFiles, List<Capcut.MediaFile> audios, CapCutProjectSettings _settings)
	{
		return (Capcut.ProjectResult)new _02B4022E()._1CBB33BE(new object[4] { this, mediaFiles, audios, _settings }, 1125891);
	}

	public void AddAnimation()
	{
		new _02B4022E()._1CBB33BE(new object[1] { this }, 1126803);
	}

	public void AddEffects()
	{
		new _02B4022E()._1CBB33BE(new object[1] { this }, 1100644);
	}

	public void AddEffect2Image()
	{
		new _02B4022E()._1CBB33BE(new object[1] { this }, 120521);
	}

	public void SyncSound()
	{
		new _02B4022E()._1CBB33BE(new object[1] { this }, 1035343);
	}

	public static Bitmap MatToBitmap(Mat image)
	{
		return image.ToBitmap();
	}

	public static Mat BitmapToMat(Bitmap image)
	{
		return image.ToMat();
	}

	public List<MatchingResult> FindHighestTemplateMatching(Mat mInput, string group, double threshold = 0.7)
	{
		List<MatchingResult> list = new List<MatchingResult>();
		foreach (ImageTemplate item in imgTemplates.FindAll((ImageTemplate x) => x.Group.Contains(group)))
		{
			try
			{
				Mat mat = new Mat();
				Cv2.MatchTemplate(mInput, item.Img, mat, TemplateMatchModes.CCoeffNormed);
				double minVal = 0.0;
				double maxVal = 0.0;
				OpenCvSharp.Point minLoc = default(OpenCvSharp.Point);
				OpenCvSharp.Point maxLoc = default(OpenCvSharp.Point);
				OpenCvSharp.Point center = default(OpenCvSharp.Point);
				Cv2.MinMaxLoc(mat, out minVal, out maxVal, out minLoc, out maxLoc);
				center.X = maxLoc.X + item.Img.Width / 2;
				center.Y = maxLoc.Y + item.Img.Height / 2;
				if (maxVal > threshold)
				{
					list.Add(new MatchingResult
					{
						Name = item.Name,
						Score = maxVal,
						Pos = maxLoc,
						Center = center
					});
				}
			}
			catch
			{
			}
		}
		if (list.Count == 0)
		{
			return null;
		}
		return list.OrderByDescending((MatchingResult x) => x.Score).ToList();
	}

	public void AutoGenerateCaption()
	{
		new _02B4022E()._1CBB33BE(new object[1] { this }, 158619);
	}

	public void AutoRender()
	{
		new _02B4022E()._1CBB33BE(new object[1] { this }, 1058129);
	}

	public void AddTransitions()
	{
		new _02B4022E()._1CBB33BE(new object[1] { this }, 1053277);
	}

	private Capcut.Keyframe createKeyframe(double values, double time_offset)
	{
		Capcut.Keyframe keyframe = new Capcut.Keyframe();
		keyframe.id = Guid.NewGuid().ToString().ToUpper();
		keyframe.curveType = "Line";
		keyframe.left_control = new Capcut.ControlPoint();
		keyframe.right_control = new Capcut.ControlPoint();
		keyframe.values = new List<double>();
		keyframe.left_control.y = 0.0;
		keyframe.left_control.x = 0.0;
		keyframe.right_control.y = 0.0;
		keyframe.right_control.x = 0.0;
		keyframe.graphID = "";
		keyframe.string_value = "";
		keyframe.time_offset = Convert.ToInt64(time_offset * 1000000.0);
		keyframe.values.Add(values);
		return keyframe;
	}

	private void addKFTypeScaleX(JArray common_keyframes, double zoomStart, double zoomEnd, double startTime)
	{
		Capcut.common_keyframe common_keyframe = new Capcut.common_keyframe();
		common_keyframe.id = Guid.NewGuid().ToString().ToUpper();
		common_keyframe.material_id = "";
		common_keyframe.keyframe_list = new List<Capcut.Keyframe>();
		common_keyframe.property_type = "KFTypeScaleX";
		common_keyframe.keyframe_list.Add(createKeyframe(zoomStart, 0.0));
		common_keyframe.keyframe_list.Add(createKeyframe(zoomEnd, startTime));
		common_keyframes.Add(JObject.FromObject(common_keyframe));
	}

	private void addKFTypePositionX(JArray common_keyframes, decimal X, decimal X2, double ZoomX, double startTime, double durationTime, decimal withd)
	{
		Capcut.common_keyframe common_keyframe = new Capcut.common_keyframe();
		common_keyframe.id = Guid.NewGuid().ToString().ToUpper();
		common_keyframe.material_id = "";
		common_keyframe.keyframe_list = new List<Capcut.Keyframe>();
		common_keyframe.property_type = "KFTypeScaleX";
		common_keyframe.keyframe_list.Add(createKeyframe(1.0, 0.0));
		common_keyframe.keyframe_list.Add(createKeyframe(ZoomX, startTime));
		if (startTime < durationTime)
		{
			common_keyframe.keyframe_list.Add(createKeyframe(ZoomX, durationTime));
		}
		Capcut.common_keyframe common_keyframe2 = new Capcut.common_keyframe();
		common_keyframe2.id = Guid.NewGuid().ToString().ToUpper();
		common_keyframe2.material_id = "";
		common_keyframe2.keyframe_list = new List<Capcut.Keyframe>();
		common_keyframe2.property_type = "KFTypePositionX";
		common_keyframe2.keyframe_list.Add(createKeyframe(0.0, 0.0));
		if (X != 0m)
		{
			common_keyframe2.keyframe_list.Add(createKeyframe(Convert.ToDouble(X / withd), startTime));
		}
		if (X2 != 0m)
		{
			common_keyframe2.keyframe_list.Add(createKeyframe(Convert.ToDouble(X2 / withd), durationTime));
		}
		common_keyframes.Add(JObject.FromObject(common_keyframe));
		common_keyframes.Add(JObject.FromObject(common_keyframe2));
	}

	private void addKFTypePositionY(JArray common_keyframes, decimal Y, decimal Y2, double ZoomY, double startTime, double durationTime, decimal heigh)
	{
		Capcut.common_keyframe common_keyframe = new Capcut.common_keyframe();
		common_keyframe.id = Guid.NewGuid().ToString().ToUpper();
		common_keyframe.material_id = "";
		common_keyframe.keyframe_list = new List<Capcut.Keyframe>();
		common_keyframe.property_type = "KFTypeScaleX";
		common_keyframe.keyframe_list.Add(createKeyframe(1.0, 0.0));
		common_keyframe.keyframe_list.Add(createKeyframe(ZoomY, startTime));
		if (startTime < durationTime)
		{
			common_keyframe.keyframe_list.Add(createKeyframe(ZoomY, durationTime));
		}
		Capcut.common_keyframe common_keyframe2 = new Capcut.common_keyframe();
		common_keyframe2.id = Guid.NewGuid().ToString().ToUpper();
		common_keyframe2.material_id = "";
		common_keyframe2.keyframe_list = new List<Capcut.Keyframe>();
		common_keyframe2.property_type = "KFTypePositionY";
		common_keyframe2.keyframe_list.Add(createKeyframe(0.0, 0.0));
		if (Y != 0m)
		{
			common_keyframe2.keyframe_list.Add(createKeyframe(Convert.ToDouble(Y / heigh), startTime));
		}
		if (Y2 != 0m)
		{
			common_keyframe2.keyframe_list.Add(createKeyframe(Convert.ToDouble(Y2 / heigh), durationTime));
		}
		common_keyframes.Add(JObject.FromObject(common_keyframe));
		common_keyframes.Add(JObject.FromObject(common_keyframe2));
	}

	public void SplitVideoBySrt()
	{
		new _02B4022E()._1CBB33BE(new object[1] { this }, 1065246);
	}

	public void exportSrt(string path)
	{
		new _02B4022E()._1CBB33BE(new object[2] { this, path }, 186921);
	}

	public void MergeAudio()
	{
		new _02B4022E()._1CBB33BE(new object[1] { this }, 231127);
	}

	public void AddKeyFrames()
	{
		new _02B4022E()._1CBB33BE(new object[1] { this }, 1137131);
	}

	public void RemoveKeyFrames()
	{
		foreach (Capcut.AllDraftStore project in projects)
		{
			Invoke((Action)delegate
			{
				dgvProject.Invalidate();
			});
			if (!project.isSelected)
			{
				continue;
			}
			string draft_json_file = project.draft_json_file;
			if (!File.Exists(draft_json_file))
			{
				project.status = "Draff missing ...";
				continue;
			}
			string destFileName = draft_json_file + ".bk";
			project.status = "Processing ...";
			File.Copy(draft_json_file, destFileName, overwrite: true);
			project.status = "Back Up Done";
			JObject jObject = JObject.Parse(File.ReadAllText(draft_json_file));
			new List<string>();
			if (jObject["materials"] == null)
			{
				project.status = "Missing materials ...";
				continue;
			}
			JArray jArray = (JArray)jObject["tracks"];
			if (jArray == null)
			{
				project.status = "Missing tracks ...";
				continue;
			}
			foreach (JToken item in jArray)
			{
				string text = (string?)item["type"];
				if (text == null || !text.Contains("video"))
				{
					continue;
				}
				JArray jArray2 = (JArray)item["segments"];
				if (jArray2 == null)
				{
					project.status = "Missing segments ...";
					continue;
				}
				int num = -1;
				foreach (JToken item2 in jArray2)
				{
					num++;
					JArray jArray3 = (JArray)item2["common_keyframes"];
					if (jArray3.Count() > 0)
					{
						jArray3.Clear();
					}
				}
			}
			string contents = jObject.ToString(Formatting.Indented);
			File.WriteAllText(draft_json_file, contents);
			string text2 = CheckProject(project.draft_fold_path);
			if (1 == 0)
			{
				Capcut.AllDraftStore current;
				current.status = text2;
			}
			else
			{
				project.status = "- Keyframs Done";
			}
		}
	}

	private void btnAddAnimation_Click(object sender, EventArgs e)
	{
		if (Precheck())
		{
			AddAnimation();
		}
	}

	private void ckIn_CheckedChanged(object sender, EventArgs e)
	{
		animationDefines.FindAll((Capcut.CommonAttr x) => x.category_ids.Contains(6824)).ForEach(delegate(Capcut.CommonAttr x)
		{
			x.isSelected = ckIn.Checked;
		});
		dgvAnimationIn.Invalidate();
	}

	private void ckOut_CheckedChanged(object sender, EventArgs e)
	{
		animationDefines.FindAll((Capcut.CommonAttr x) => x.category_ids.Contains(6825)).ForEach(delegate(Capcut.CommonAttr x)
		{
			x.isSelected = ckOut.Checked;
		});
		dgvAnimationOut.Invalidate();
	}

	private void ckCombo_CheckedChanged(object sender, EventArgs e)
	{
		animationDefines.FindAll((Capcut.CommonAttr x) => x.category_ids.Contains(6826)).ForEach(delegate(Capcut.CommonAttr x)
		{
			x.isSelected = ckCombo.Checked;
		});
		dgvAnimationCombo.Invalidate();
	}

	private void btnRefresh_Click(object sender, EventArgs e)
	{
		LoadCapcutProj();
	}

	private void btnRemoveAllAnimation_Click(object sender, EventArgs e)
	{
		if (Precheck())
		{
			RemoveAllAnimation("Animations");
		}
	}

	private void nEffectDurationRate_ValueChanged(object sender, EventArgs e)
	{
		progConf.EffectDurationRate = (int)nEffectDurationRate.Value;
	}

	private void lstEffectUse_ValueMemberChanged(object sender, EventArgs e)
	{
		progConf.Effects.Clear();
		foreach (object item in lstEffectUse.Items)
		{
			progConf.Effects.Add(item.ToString());
		}
	}

	private void nTransitionDuration_ValueChanged(object sender, EventArgs e)
	{
		progConf.TransitionDuration = nTransitionDuration.Value;
	}

	private void lstTransitionUse_ValueMemberChanged(object sender, EventArgs e)
	{
		progConf.Transitions.Clear();
		foreach (object item in lstTransitionUse.Items)
		{
			progConf.Transitions.Add(item.ToString());
		}
	}

	private void txtSearchTransition_TextChanged(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(txtSearchTransition.Text))
		{
			List<Capcut.CommonAttr> source = transitionDefines.FindAll((Capcut.CommonAttr x) => x.title.ToLower().Contains(txtSearchTransition.Text.ToLower()));
			lstSearchTransitionResult.Items.Clear();
			ListBox.ObjectCollection items = lstSearchTransitionResult.Items;
			object[] items2 = source.Select((Capcut.CommonAttr x) => x.title).ToArray();
			items.AddRange(items2);
		}
	}

	private void txtSearchEffect_TextChanged(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(txtSearchEffect.Text))
		{
			List<Capcut.CommonAttr> source = effectDefines.FindAll((Capcut.CommonAttr x) => x.title.ToLower().Contains(txtSearchEffect.Text.ToLower()));
			lstSearchEffectResult.Items.Clear();
			ListBox.ObjectCollection items = lstSearchEffectResult.Items;
			object[] items2 = source.Select((Capcut.CommonAttr x) => x.title).ToArray();
			items.AddRange(items2);
		}
	}

	private void btnAddEffect_Click(object sender, EventArgs e)
	{
		if (lstSearchEffectResult.SelectedIndex >= 0)
		{
			string text = (string)lstSearchEffectResult.SelectedItem;
			if (!lstEffectUse.Items.Contains(text))
			{
				lstEffectUse.Items.Add(text);
			}
			lstEffectUse_ValueMemberChanged(null, null);
		}
	}

	private void btnAddTransiton_Click(object sender, EventArgs e)
	{
		if (lstSearchTransitionResult.SelectedIndex >= 0)
		{
			string text = (string)lstSearchTransitionResult.SelectedItem;
			if (!lstTransitionUse.Items.Contains(text))
			{
				lstTransitionUse.Items.Add(text);
			}
			lstTransitionUse_ValueMemberChanged(null, null);
		}
	}

	private void btnRemoveEffect_Click(object sender, EventArgs e)
	{
		if (lstEffectUse.SelectedIndex >= 0)
		{
			lstEffectUse.Items.Remove(lstEffectUse.SelectedItem);
			lstEffectUse_ValueMemberChanged(null, null);
		}
	}

	private void btnRemoveTransition_Click(object sender, EventArgs e)
	{
		if (lstTransitionUse.SelectedIndex >= 0)
		{
			lstTransitionUse.Items.Remove(lstTransitionUse.SelectedItem);
			lstEffectUse_ValueMemberChanged(null, null);
		}
	}

	private void btnRemoveAllTransitions_Click(object sender, EventArgs e)
	{
		if (Precheck())
		{
			RemoveAllAnimation("Transitions");
		}
	}

	private void btnAddTransitions_Click(object sender, EventArgs e)
	{
		if (Precheck())
		{
			AddTransitions();
		}
	}

	private void btnRemoveAllEffects_Click(object sender, EventArgs e)
	{
		if (Precheck())
		{
			RemoveAllAnimation("Effects");
		}
	}

	private void btnAddEffects_Click(object sender, EventArgs e)
	{
		if (Precheck())
		{
			if (progConf.IsAddEffectToImage)
			{
				AddEffect2Image();
			}
			else
			{
				AddEffects();
			}
		}
	}

	private void btnSyncSound_Click(object sender, EventArgs e)
	{
		if (Precheck())
		{
			SyncSound();
		}
	}

	private void lstSearchEffectResult_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		btnAddEffect_Click(null, null);
	}

	private void lstEffectUse_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		btnRemoveEffect_Click(null, null);
	}

	private void lstSearchTransitionResult_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		btnAddTransiton_Click(null, null);
	}

	private void lstTransitionUse_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		btnRemoveTransition_Click(null, null);
	}

	private void Form1_Shown(object sender, EventArgs e)
	{
		isShow = true;
	}

	public async Task DownloadFileWithProgressAsync(string url, string destinationPath)
	{
		HttpClient httpClient = new HttpClient();
		try
		{
			HttpResponseMessage response = await httpClient.GetAsync(url, (HttpCompletionOption)1);
			try
			{
				response.EnsureSuccessStatusCode();
				long totalBytes = response.Content.Headers.ContentLength ?? (-1);
				using Stream contentStream = await response.Content.ReadAsStreamAsync();
				using FileStream fileStream = new FileStream(destinationPath, FileMode.Create, FileAccess.Write, FileShare.None);
				byte[] buffer = new byte[8192];
				long totalBytesRead = 0L;
				while (true)
				{
					int num;
					int bytesRead = (num = await contentStream.ReadAsync(buffer, 0, buffer.Length));
					if (num <= 0)
					{
						break;
					}
					await fileStream.WriteAsync(buffer, 0, bytesRead);
					totalBytesRead += bytesRead;
					if (totalBytes != -1)
					{
						double percentage = (double)totalBytesRead / (double)totalBytes * 100.0;
						Invoke((Action)delegate
						{
							lblSubtitle.Text = $"{percentage:F1}%";
						});
					}
				}
			}
			finally
			{
				((IDisposable)response)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)httpClient)?.Dispose();
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		ConfigController.InsertProjectState(projects);
		dgvProject.Invalidate();
		lblLicense.Text = "TK: " + username + " / ExpiredDate: " + Login.ExpiredDate.ToString("dd/MM/yyyy HH:mm");
		if (!isShow || DateTime.Now > Login.ExpiredDate)
		{
		}
		List<Capcut.CommonAttr> list = animationDefines.FindAll((Capcut.CommonAttr x) => x.isSelected);
		btnAddAnimation.Text = $"Chèn Animation ({list.Count})";
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		ConfigController.InsertProjectState(projects);
		Environment.Exit(0);
	}

	private void btnAutoRender_Click(object sender, EventArgs e)
	{
		isRendering = true;
		ConfigController.Insert(progConf);
		if (MessageBox.Show("*******************\n\nAuto Render\nLưu ý\nKhông zoom màn hình\nNgôn ngữ Capcut phải để tiếng anh để auto có thể hoạt động\n\n*******************", "Auto Capcut Pro", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
		{
			btnAutoRender.Enabled = false;
			Thread thread = new Thread(AutoRender);
			thread.IsBackground = true;
			thread.Start();
		}
	}

	private void btnOutput_Click(object sender, EventArgs e)
	{
		Process.Start(txtExportPath.Text);
	}

	private void nAnimationTime_ValueChanged(object sender, EventArgs e)
	{
		progConf.AnimationDuration = nAnimationTime.Value;
	}

	private void ckAddEffect2Image_CheckedChanged(object sender, EventArgs e)
	{
		progConf.IsAddEffectToImage = ckAddEffect2Image.Checked;
	}

	private void btnGenerateCaption_Click(object sender, EventArgs e)
	{
		CheckFunction("Edit");
		HmacSha256Hex("Edit", "Edit");
		if (1 == 0)
		{
			MessageBox.Show("Gói của bạn không có chức năng này");
		}
		else if (MessageBox.Show("*******************\n\nTách Subtitles\nLưu ý\nKhông zoom màn hình\nNgôn ngữ Capcut phải để tiếng anh để auto có thể hoạt động\n\n*******************", "Auto Capcut Pro", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
		{
			btnGenerateCaption.Enabled = false;
			Thread thread = new Thread(AutoGenerateCaption);
			thread.IsBackground = true;
			thread.Start();
		}
	}

	private void txtSearchCaptionAnimation_TextChanged(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(txtSearchCaptionAnimation.Text))
		{
			List<Capcut.CommonAttr> source = captionDefines.FindAll((Capcut.CommonAttr x) => x.title.ToLower().Contains(txtSearchCaptionAnimation.Text.ToLower()));
			lstCaptionAnimation.Items.Clear();
			ListBox.ObjectCollection items = lstCaptionAnimation.Items;
			object[] items2 = source.Select((Capcut.CommonAttr x) => x.title).ToArray();
			items.AddRange(items2);
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		if (Precheck())
		{
			RemoveAllAnimation("Animations");
		}
	}

	private void btnAddCaptionAnimationConfig_Click(object sender, EventArgs e)
	{
		if (lstCaptionAnimation.SelectedIndex >= 0)
		{
			string text = (string)lstCaptionAnimation.SelectedItem;
			if (!lstCaptionAnimationConfig.Items.Contains(text))
			{
				lstCaptionAnimationConfig.Items.Add(text);
			}
			lstCaptionAnimationConfig_ValueMemberChanged(null, null);
		}
	}

	private void lstCaptionAnimationConfig_ValueMemberChanged(object sender, EventArgs e)
	{
		progConf.Captions.Clear();
		foreach (object item in lstCaptionAnimationConfig.Items)
		{
			progConf.Captions.Add(item.ToString());
		}
	}

	private void btnRemoveCaptionAnimationConfig_Click(object sender, EventArgs e)
	{
		if (lstCaptionAnimationConfig.SelectedIndex >= 0)
		{
			lstCaptionAnimationConfig.Items.Remove(lstCaptionAnimationConfig.SelectedItem);
			lstCaptionAnimationConfig_ValueMemberChanged(null, null);
		}
	}

	private void ckAutoOff_CheckedChanged(object sender, EventArgs e)
	{
		progConf.IsAutoTurnOff = ckAutoOff.Checked;
	}

	private void nWaitRender_ValueChanged(object sender, EventArgs e)
	{
		progConf.WaitRender = (int)nWaitRender.Value;
	}

	private void btnUpdate_Click(object sender, EventArgs e)
	{
		btnUpdate.Enabled = false;
		File.Delete("capcut.db");
		animationDefines.Clear();
		effectDefines.Clear();
		transitionDefines.Clear();
		captionDefines.Clear();
		dgvAnimationIn.DataSource = null;
		dgvAnimationOut.DataSource = null;
		dgvAnimationCombo.DataSource = null;
		new Thread(LoadData).Start();
	}

	private void ck4K_CheckedChanged(object sender, EventArgs e)
	{
		progConf.IsRender4k = ck4K.Checked;
	}

	private void checkKeys(TextBox textBox, string form)
	{
		Regex regex = new Regex(form);
		textBox.Text = regex.Replace(textBox.Text, "");
		textBox.SelectionStart = textBox.Text.Length;
	}

	private void btnAddKeyFrames_Click(object sender, EventArgs e)
	{
		if (Precheck())
		{
			AddKeyFrames();
		}
	}

	private void btnClearKeyFrames_Click(object sender, EventArgs e)
	{
		if (Precheck())
		{
			RemoveKeyFrames();
		}
	}

	private void nStartKeyFrames_ValueChanged(object sender, EventArgs e)
	{
		progConf.KeyFramConfig.timeStart = nStartKeyFrames.Value;
	}

	private void cbFulldurationtime_CheckedChanged(object sender, EventArgs e)
	{
		progConf.KeyFramConfig.cbFulldurationTimeCheck = cbFulldurationtime.Checked;
	}

	private void cbZoomIn_CheckedChanged(object sender, EventArgs e)
	{
		progConf.KeyFramConfig.cbZoomInCheck = cbZoomIn.Checked;
	}

	private void cbZoomout_CheckedChanged(object sender, EventArgs e)
	{
		progConf.KeyFramConfig.cbZoomOutCheck = cbZoomout.Checked;
	}

	private void cbZoomMoveX_CheckedChanged(object sender, EventArgs e)
	{
		progConf.KeyFramConfig.cbZoomInMoveXCheck = cbZoomMoveX.Checked;
	}

	private void cbZoomMoveY_CheckedChanged(object sender, EventArgs e)
	{
		progConf.KeyFramConfig.cbZoomInMoveYCheck = cbZoomMoveY.Checked;
	}

	private void nbZoomInStart_ValueChanged(object sender, EventArgs e)
	{
		progConf.KeyFramConfig.ZoonInStart = nbZoomInStart.Value;
	}

	private void nbZoomInEnd_ValueChanged(object sender, EventArgs e)
	{
		progConf.KeyFramConfig.ZoonInEnd = nbZoomInEnd.Value;
	}

	private void nbZoomOutStart_ValueChanged(object sender, EventArgs e)
	{
		progConf.KeyFramConfig.ZoonInStart = nbZoomOutStart.Value;
	}

	private void nbZoomOutEnd_ValueChanged(object sender, EventArgs e)
	{
		progConf.KeyFramConfig.ZoonOutEnd = nbZoomOutEnd.Value;
	}

	private void nbZoomInMoveX_ValueChanged(object sender, EventArgs e)
	{
		progConf.KeyFramConfig.ZoonInMoveX = nbZoomInMoveX.Value;
	}

	private void nbZoomInMoveY_ValueChanged(object sender, EventArgs e)
	{
		progConf.KeyFramConfig.ZoonInMoveY = nbZoomInMoveY.Value;
	}

	private void X1_ValueChanged(object sender, EventArgs e)
	{
		progConf.KeyFramConfig.X1 = X1.Value;
	}

	private void X2_ValueChanged(object sender, EventArgs e)
	{
		progConf.KeyFramConfig.X2 = X2.Value;
	}

	private void Y1_ValueChanged(object sender, EventArgs e)
	{
		progConf.KeyFramConfig.Y1 = Y1.Value;
	}

	private void Y2_ValueChanged(object sender, EventArgs e)
	{
		progConf.KeyFramConfig.Y2 = Y2.Value;
	}

	private void btnExportSrt_Click(object sender, EventArgs e)
	{
		exportSrt("");
	}

	private void btnStop_Click(object sender, EventArgs e)
	{
		isRendering = false;
	}

	public async Task<bool> TTS_Capcut(string filePath, string session_id, string speaker, string text)
	{
		_ = 1;
		try
		{
			HttpClient val = new HttpClient();
			string text2 = Uri.EscapeDataString(text);
			HttpRequestMessage val2 = new HttpRequestMessage(HttpMethod.Post, "https://api16-normal-v6.tiktokv.com/media/api/text/speech/invoke/?text_speaker=" + speaker + "&req_text=" + text2 + "&speaker_map_type=0&aid=1233");
			((HttpHeaders)val2.Headers).Add("User-Agent", "com.zhiliaoapp.musically/2022600030 (Linux; U; Android 7.1.2; es_ES; SM-G988N; Build/NRD90M;tt-ok/3.12.13.1)");
			((HttpHeaders)val2.Headers).Add("Accept-Encoding", "gzip, deflate, compress");
			((HttpHeaders)val2.Headers).Add("Content-Length", "0");
			((HttpHeaders)val2.Headers).Add("Cookie", "sessionid=" + session_id);
			HttpResponseMessage obj = await val.SendAsync(val2);
			obj.EnsureSuccessStatusCode();
			byte[] bytes = Convert.FromBase64String(JObject.Parse(await obj.Content.ReadAsStringAsync())["data"]?["v_str"]?.ToString());
			File.WriteAllBytes(filePath, bytes);
			if (File.Exists(filePath))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	public async void AutoTTS()
	{
		foreach (Capcut.AllDraftStore proj in projects)
		{
			Invoke((Action)delegate
			{
				dgvProject.Invalidate();
			});
			if (!proj.isSelected)
			{
				continue;
			}
			string draft_json_file = proj.draft_json_file;
			if (!File.Exists(draft_json_file))
			{
				proj.status = "Draff missing ...";
				continue;
			}
			string destFileName = draft_json_file + ".bk";
			proj.status = "Processing ...";
			File.Copy(draft_json_file, destFileName, overwrite: true);
			proj.status = "Back Up Done";
			JObject jObject = JObject.Parse(File.ReadAllText(draft_json_file));
			if (jObject["extra_info"] == null)
			{
				proj.status = "Missing extra_info ...";
				continue;
			}
			JToken? jToken = jObject["extra_info"];
			if (jToken != null && jToken.Type == JTokenType.Null)
			{
				proj.status = "No Subtitle";
				continue;
			}
			JArray jArray = (JArray)jObject["extra_info"]["subtitle_fragment_info_list"];
			if (jArray == null || jArray.Count == 0)
			{
				proj.status = "Missing subtitles ...";
				continue;
			}
			int num = 0;
			string text = "";
			List<Capcut.Subtitle> list = new List<Capcut.Subtitle>();
			foreach (JToken item in jArray)
			{
				if (JsonConvert.DeserializeObject<object>(item["subtitle_cache_info"].ToString()) == null)
				{
					continue;
				}
				JObject jObject2 = JObject.Parse(item["subtitle_cache_info"].ToString());
				double value = (double)item["start_time"] / 1000.0;
				double value2 = (double)item["end_time"] / 1000.0;
				if (jObject2 != null)
				{
					num++;
					TimeSpan timeSpan = TimeSpan.FromMilliseconds(value);
					TimeSpan timeSpan2 = TimeSpan.FromMilliseconds(value2);
					string text2 = $"{(int)timeSpan.TotalHours:00}:{timeSpan.Minutes:00}:{timeSpan.Seconds:00},{timeSpan.Milliseconds:000}";
					string text3 = $"{(int)timeSpan2.TotalHours:00}:{timeSpan2.Minutes:00}:{timeSpan2.Seconds:00},{timeSpan2.Milliseconds:000}";
					string text4 = jObject2["sentence_list"]?[0]?["text"]?.ToString();
					if (!string.IsNullOrEmpty(text4))
					{
						text += $"{num}\r\n{text2} --> {text3}\r\n{text4}\r\n\r\n";
					}
					list.Add(new Capcut.Subtitle
					{
						index = num,
						content = text4
					});
				}
			}
			foreach (Capcut.Subtitle item2 in list)
			{
				string text5 = Path.Combine(proj.draft_fold_path, "Resources", "audio");
				if (!Directory.Exists(text5))
				{
					Directory.CreateDirectory(text5);
				}
				string filePath = Path.Combine(text5, $"{item2.index}.mp3");
				await TTS_Capcut(filePath, "f93293b8288e021118be521b7d7fddf0", "BV074_streaming", item2.content);
			}
			proj.status = "+ TTS Done";
		}
	}

	private void btnTTS_Click(object sender, EventArgs e)
	{
		if (Login.Extra.Contains("TTS"))
		{
			Thread thread = new Thread(AutoTTS);
			thread.IsBackground = true;
			thread.Start();
		}
	}

	private void btnAddCaptionAnimation_Click(object sender, EventArgs e)
	{
	}

	private void btnSplitVideoBySrt_Click(object sender, EventArgs e)
	{
		btnSplitVideoBySrt.Enabled = false;
		Thread thread = new Thread(SplitVideoBySrt);
		thread.IsBackground = true;
		thread.Start();
	}

	private void btnMergeAudio_Click(object sender, EventArgs e)
	{
		MergeAudio();
	}

	private void cbbVideoOverAudio_SelectedIndexChanged(object sender, EventArgs e)
	{
		progConf.VideoOverAudio = cbbVideoOverAudio.Text;
	}

	private void ckMixAnimation_CheckedChanged(object sender, EventArgs e)
	{
		progConf.IsMixAnimation = ckMixAnimation.Checked;
	}

	public int SyncOne(Capcut.AllDraftStore proj)
	{
		Invoke((Action)delegate
		{
			dgvProject.Invalidate();
		});
		if (!proj.isSelected)
		{
			return -1;
		}
		string draft_json_file = proj.draft_json_file;
		if (!File.Exists(draft_json_file))
		{
			proj.status = "Draff missing ...";
			return -1;
		}
		string destFileName = draft_json_file + ".bk";
		proj.status = "Processing ...";
		File.Copy(draft_json_file, destFileName, overwrite: true);
		proj.status = "Back Up Done";
		JObject jObject = JObject.Parse(File.ReadAllText(draft_json_file));
		JArray jArray = (JArray)jObject["tracks"];
		if (jArray == null)
		{
			proj.status = "Missing tracks ...";
			return -1;
		}
		List<Capcut.Subtitle> list = new List<Capcut.Subtitle>();
		JArray textSegmentArray = new JArray();
		JArray jArray2 = new JArray();
		JArray jArray3 = new JArray();
		foreach (JToken item in jArray)
		{
			string text = (string?)item["type"];
			if (text == null)
			{
				continue;
			}
			JArray jArray4 = (JArray)item["segments"];
			if (jArray4 == null)
			{
				proj.status = "Missing segments ...";
			}
			else if (text.Contains("audio"))
			{
				foreach (JToken item2 in jArray4)
				{
					jArray3.Add(item2);
				}
			}
			else if (text.Contains("video"))
			{
				foreach (JToken item3 in jArray4)
				{
					jArray2.Add(item3);
				}
			}
			else
			{
				if (!text.Contains("text") || textSegmentArray.Count != 0)
				{
					continue;
				}
				foreach (JToken item4 in jArray4)
				{
					textSegmentArray.Add(item4);
					Capcut.Subtitle subtitle = new Capcut.Subtitle();
					subtitle.id = (string?)item4["material_id"];
					subtitle.startTime = (long)item4["target_timerange"]["start"];
					subtitle.endTime = subtitle.startTime + (long)item4["target_timerange"]["duration"];
					list.Add(subtitle);
				}
			}
		}
		if (list.Count == 0)
		{
			proj.status = "Missing Srt";
			return -1;
		}
		list = list.OrderBy((Capcut.Subtitle x) => x.startTime).ToList();
		if (jArray2.Count < textSegmentArray.Count)
		{
			proj.status = "Spliting ...";
			for (int num = 0; num < list.Count - 1; num++)
			{
				long startTime = list[num].startTime;
				long startTime2 = list[num + 1].startTime;
				foreach (JToken item5 in jArray)
				{
					string text2 = (string?)item5["type"];
					if (text2 == null || !text2.Contains("video"))
					{
						continue;
					}
					JArray jArray5 = (JArray)item5["segments"];
					if (jArray5 == null)
					{
						proj.status = "Missing segments ...";
						continue;
					}
					List<string> list2 = new List<string> { "canvases", "placeholder_infos", "speeds", "sound_channel_mappings", "material_colors", "vocal_separations" };
					for (int num2 = 0; num2 < jArray5.Count; num2++)
					{
						string material_id = (string?)jArray5[num2]["material_id"];
						long num3 = (long)jArray5[num2]["target_timerange"]["start"];
						long num4 = (long)jArray5[num2]["target_timerange"]["duration"];
						_ = jArray5[num2]["extra_material_refs"];
						if (num3 > startTime || num3 + num4 - 10000 <= startTime2)
						{
							continue;
						}
						if (!(jObject["materials"]?["videos"] is JArray jArray6))
						{
							proj.status = "Missing videos ...";
							continue;
						}
						JToken jToken = jArray6.FirstOrDefault((JToken x) => x["id"]?.ToString() == material_id);
						if (num3 + 1000000 < startTime)
						{
							jArray5[num2]["source_timerange"]["duration"] = startTime - num3;
							jArray5[num2]["target_timerange"]["duration"] = startTime - num3;
							JToken jToken2 = jArray5[num2].DeepClone();
							jToken2["id"] = Guid.NewGuid().ToString().ToUpper();
							jToken2["material_id"] = Guid.NewGuid().ToString().ToUpper();
							jToken2["target_timerange"]["start"] = startTime;
							jToken2["target_timerange"]["duration"] = startTime2 - startTime;
							jToken2["source_timerange"]["start"] = startTime;
							jToken2["source_timerange"]["duration"] = startTime2 - startTime;
							JArray cloneMaterialItems = jToken2["extra_material_refs"] as JArray;
							int iCloneMaterialId;
							for (iCloneMaterialId = 0; iCloneMaterialId < cloneMaterialItems.Count; iCloneMaterialId++)
							{
								for (int num5 = 0; num5 < list2.Count; num5++)
								{
									string text3 = list2[num5].ToString();
									if (!(jObject["materials"]?[text3] is JArray jArray7))
									{
										proj.status = "Missing " + text3 + " ...";
										continue;
									}
									JToken jToken3 = jArray7.FirstOrDefault((JToken x) => x["id"]?.ToString() == cloneMaterialItems[iCloneMaterialId]?.ToString());
									if (jToken3 != null)
									{
										cloneMaterialItems[iCloneMaterialId] = Guid.NewGuid().ToString().ToUpper();
										JToken jToken4 = jToken3.DeepClone();
										jToken4["id"] = cloneMaterialItems[iCloneMaterialId];
										jArray7.Add(jToken4);
										break;
									}
								}
							}
							if (jToken != null)
							{
								JToken jToken5 = jToken.DeepClone();
								jToken5["id"] = jToken2["material_id"];
								JObject jObject2 = new JObject();
								jObject2["start"] = startTime;
								jObject2["duration"] = startTime2 - startTime;
								jToken5["time_range"] = jObject2;
								jArray6.Add(jToken5);
							}
							jArray5.Add(jToken2);
						}
						else
						{
							jArray5[num2]["target_timerange"]["duration"] = startTime2 - num3;
							jArray5[num2]["source_timerange"]["duration"] = startTime2 - num3;
						}
						JToken jToken6 = jArray5[num2].DeepClone();
						jToken6["id"] = Guid.NewGuid().ToString().ToUpper();
						jToken6["material_id"] = Guid.NewGuid().ToString().ToUpper();
						jToken6["target_timerange"]["start"] = startTime2;
						jToken6["target_timerange"]["duration"] = num3 + num4 - startTime2;
						jToken6["source_timerange"]["start"] = startTime2;
						jToken6["source_timerange"]["duration"] = num3 + num4 - startTime2;
						JArray cloneMaterialItems2 = jToken6["extra_material_refs"] as JArray;
						int iCloneMaterialId2;
						for (iCloneMaterialId2 = 0; iCloneMaterialId2 < cloneMaterialItems2.Count; iCloneMaterialId2++)
						{
							for (int num6 = 0; num6 < list2.Count; num6++)
							{
								string text4 = list2[num6].ToString();
								if (!(jObject["materials"]?[text4] is JArray jArray8))
								{
									proj.status = "Missing " + text4 + " ...";
									continue;
								}
								JToken jToken7 = jArray8.FirstOrDefault((JToken x) => x["id"]?.ToString() == cloneMaterialItems2[iCloneMaterialId2]?.ToString());
								if (jToken7 != null)
								{
									cloneMaterialItems2[iCloneMaterialId2] = Guid.NewGuid().ToString().ToUpper();
									JToken jToken8 = jToken7.DeepClone();
									jToken8["id"] = cloneMaterialItems2[iCloneMaterialId2];
									jArray8.Add(jToken8);
									break;
								}
							}
						}
						if (jToken != null)
						{
							JObject jObject3 = new JObject();
							jObject3["start"] = jArray5[num2]["target_timerange"]["start"];
							jObject3["duration"] = jArray5[num2]["target_timerange"]["duration"];
							jToken["video_algorithm"]["time_range"] = jObject3;
							JToken jToken9 = jToken.DeepClone();
							jToken9["id"] = jToken6["material_id"];
							JObject jObject4 = new JObject();
							jObject4["start"] = startTime2;
							jObject4["duration"] = num3 + num4 - startTime2;
							jToken9["time_range"] = jObject4;
							jArray6.Add(jToken9);
						}
						jArray5.Add(jToken6);
						break;
					}
				}
			}
			jArray2.Clear();
			foreach (JToken item6 in jArray)
			{
				string text5 = (string?)item6["type"];
				if (text5 == null)
				{
					continue;
				}
				JArray jArray9 = (JArray)item6["segments"];
				if (jArray9 == null)
				{
					proj.status = "Missing segments ...";
				}
				else
				{
					if (!text5.Contains("video"))
					{
						continue;
					}
					foreach (JToken item7 in jArray9)
					{
						jArray2.Add(item7);
					}
				}
			}
		}
		if (jArray2.Count < jArray3.Count || jArray2.Count - 1 > jArray3.Count)
		{
			proj.status = $"Số lượng Video và âm thanh không khớp {jArray2.Count} / {jArray3.Count}";
			return -1;
		}
		if (list.Count != jArray3.Count)
		{
			proj.status = $"Số lượng Text và âm thanh không khớp {list.Count} / {jArray3.Count}";
			return -1;
		}
		List<JObject> list3 = (from t in jArray.OfType<JObject>()
			where t["type"]?.ToString().Contains("audio") ?? false
			select t).ToList();
		JToken jToken10 = list3.First().DeepClone();
		foreach (JObject item8 in list3)
		{
			jArray.Remove(item8);
		}
		List<JObject> list4 = (from s in jArray3.OfType<JObject>()
			orderby s["target_timerange"]?["start"]?.Value<long>() ?? long.MaxValue
			select s).ToList();
		long num7 = 0L;
		proj.status = "Sync ...";
		int iAudioSeg;
		for (iAudioSeg = 0; iAudioSeg < list4.Count; iAudioSeg++)
		{
			long num8 = (long)list4[iAudioSeg]["target_timerange"]["start"];
			long startTime3 = list[iAudioSeg].startTime;
			if (startTime3 > num8)
			{
				num8 = startTime3;
				list4[iAudioSeg]["target_timerange"]["start"] = startTime3;
			}
			else if (startTime3 < num8)
			{
				foreach (JToken item9 in jArray)
				{
					string text6 = (string?)item9["type"];
					if (text6 != null && text6.Contains("text"))
					{
						JObject jObject5 = ((JArray)item9["segments"]).OfType<JObject>().FirstOrDefault((JObject s) => (string?)s["id"] == (string?)textSegmentArray[iAudioSeg]["id"]);
						if (jObject5 != null)
						{
							jObject5["target_timerange"]["start"] = num8;
							break;
						}
					}
				}
			}
			long num9 = (long)list4[iAudioSeg]["target_timerange"]["duration"];
			if (list[iAudioSeg].endTime - list[iAudioSeg].startTime > num9)
			{
				num9 = list[iAudioSeg].endTime - list[iAudioSeg].startTime;
			}
			list4[iAudioSeg]["render_index"] = 0;
			list4[iAudioSeg]["track_render_index"] = 1;
			if (num7 == 0L)
			{
				num7 = num8 + num9;
			}
			else if (num8 < num7)
			{
				foreach (JToken item10 in jArray)
				{
					string text7 = (string?)item10["type"];
					if (text7 != null && text7.Contains("text"))
					{
						JObject jObject6 = ((JArray)item10["segments"]).OfType<JObject>().FirstOrDefault((JObject s) => (string?)s["id"] == (string?)textSegmentArray[iAudioSeg]["id"]);
						if (jObject6 != null)
						{
							jObject6["target_timerange"]["start"] = num7;
							break;
						}
					}
				}
				list4[iAudioSeg]["target_timerange"]["start"] = num7;
				num7 += num9;
			}
			else
			{
				num7 = num8 + num9;
			}
		}
		jToken10["segments"] = new JArray(list4.Select((JObject s) => s.DeepClone()));
		jArray.Add(jToken10);
		list = new List<Capcut.Subtitle>();
		textSegmentArray = new JArray();
		jArray2 = new JArray();
		jArray3 = new JArray();
		foreach (JToken item11 in jArray)
		{
			string text8 = (string?)item11["type"];
			if (text8 == null)
			{
				continue;
			}
			JArray jArray10 = (JArray)item11["segments"];
			if (jArray10 == null)
			{
				proj.status = "Missing segments ...";
			}
			else if (text8.Contains("audio"))
			{
				jArray3 = jArray10;
			}
			else if (text8.Contains("video"))
			{
				jArray2 = jArray10;
			}
			else
			{
				if (!text8.Contains("text") || textSegmentArray.Count != 0)
				{
					continue;
				}
				textSegmentArray = jArray10;
				foreach (JToken item12 in jArray10)
				{
					Capcut.Subtitle subtitle2 = new Capcut.Subtitle();
					subtitle2.id = (string?)item12["material_id"];
					subtitle2.startTime = (long)item12["target_timerange"]["start"];
					subtitle2.endTime = subtitle2.startTime + (long)item12["target_timerange"]["duration"];
					list.Add(subtitle2);
				}
			}
		}
		if (list.Count == 0)
		{
			proj.status = "Missing Srt";
			return -1;
		}
		list = list.OrderBy((Capcut.Subtitle x) => x.startTime).ToList();
		int num10 = 0;
		if (jArray2.Count > jArray3.Count)
		{
			num10 = 1;
		}
		long num11 = 0L;
		StringBuilder stringBuilder = new StringBuilder();
		for (int num12 = num10; num12 < jArray2.Count; num12++)
		{
			long num13 = (long)jArray3[num12 - num10]["target_timerange"]["start"];
			long num14 = (long)textSegmentArray[num12 - num10]["target_timerange"]["start"];
			long num15 = (long)jArray2[num12]["target_timerange"]["start"];
			if (num15 < num13)
			{
				stringBuilder.AppendLine($"V:{num15} A: {num13} S: {num14}");
				num13 = num15;
				num14 = num15;
				jArray3[num12 - num10]["target_timerange"]["start"] = num13;
				textSegmentArray[num12 - num10]["target_timerange"]["start"] = num14;
			}
			else
			{
				stringBuilder.AppendLine($"V:{num15} A: {num13} S: {num14} ---");
			}
			if (num11 > 0)
			{
				stringBuilder.AppendLine($"S:{num11}");
				jArray3[num12 - num10]["target_timerange"]["start"] = num13 + num11;
				textSegmentArray[num12 - num10]["target_timerange"]["start"] = num14 + num11;
				jArray2[num12 - num10]["target_timerange"]["start"] = num15 + num11;
			}
			long num16 = (long)jArray2[num12]["target_timerange"]["duration"];
			long num17 = (long)jArray3[num12 - num10]["target_timerange"]["duration"];
			if (num16 >= num17)
			{
				continue;
			}
			num11 += num17 - num16;
			double num18 = Math.Round((double)num16 / (double)num17, 5);
			jArray2[num12]["speed"] = num18;
			JArray source = (JArray)jArray2[num12]["extra_material_refs"];
			JArray jArray11 = (JArray)jObject["materials"]["speeds"];
			if (jArray11 == null)
			{
				proj.status = "Missing speeds ...";
				continue;
			}
			foreach (JToken item13 in jArray11)
			{
				string speedid = (string?)item13["id"];
				if (source.Any((JToken item) => item.ToString() == speedid))
				{
					item13["speed"] = num18;
				}
			}
			jArray2[num12]["target_timerange"] = jArray3[num12 - num10]["target_timerange"];
		}
		string contents = jObject.ToString(Formatting.Indented);
		File.WriteAllText(draft_json_file, contents);
		return 1;
	}

	public void OneClickSync()
	{
		new _02B4022E()._1CBB33BE(new object[1] { this }, 124996);
	}

	private void btnOneClickSync_Click(object sender, EventArgs e)
	{
		btnOneClickSync.Enabled = false;
		Thread thread = new Thread(OneClickSync);
		thread.IsBackground = true;
		thread.Start();
	}

	private void btnCompoundClip_Click(object sender, EventArgs e)
	{
		CreateComboundClip();
	}

	private void nImageDuration_ValueChanged(object sender, EventArgs e)
	{
		progConf.CapCutProjectSettings.DefaultDuration = (int)nImageDuration.Value;
	}

	private void cbbCreateProjRatio_SelectedIndexChanged(object sender, EventArgs e)
	{
		progConf.CapCutProjectSettings.AspectRatio = cbbCreateProjRatio.Text;
	}

	private void cbbCreateProjQuality_SelectedIndexChanged(object sender, EventArgs e)
	{
		progConf.CapCutProjectSettings.OutputQuality = cbbCreateProjQuality.Text;
	}

	private void cbbCreateProjFps_SelectedIndexChanged(object sender, EventArgs e)
	{
		progConf.CapCutProjectSettings.OutputFps = cbbCreateProjFps.Text;
	}

	private void txtProjName_TextChanged(object sender, EventArgs e)
	{
		progConf.CapCutProjectSettings.ProjectName = txtProjName.Text;
	}

	private void btnSelectVideoResouce_Click(object sender, EventArgs e)
	{
		using FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
		if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
		{
			txtVideoDataPath.Text = folderBrowserDialog.SelectedPath;
		}
	}

	private void btnSelectAudioResouce_Click(object sender, EventArgs e)
	{
		using FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
		if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
		{
			txtAudioDataPath.Text = folderBrowserDialog.SelectedPath;
		}
	}

	private List<Capcut.MediaFile> ScanAllMedia(string folder, string inputType, int imageDuration)
	{
		List<Capcut.MediaFile> list = new List<Capcut.MediaFile>();
		if (!Directory.Exists(folder))
		{
			return list;
		}
		HashSet<string> hashSet = new HashSet<string> { ".png", ".jpg", ".jpeg" };
		HashSet<string> hashSet2 = new HashSet<string> { ".mp4", ".mov", ".avi", ".mkv", ".webm" };
		HashSet<string> hashSet3 = new HashSet<string> { ".mp3", ".wav", ".aac", ".flac", ".ogg", ".m4a" };
		foreach (string item2 in Directory.GetFiles(folder).OrderBy((string f) => Path.GetFileName(f), new NaturalSortComparer()).ToList())
		{
			string fileName = Path.GetFileName(item2);
			string item = Path.GetExtension(fileName).ToLower();
			string path = item2.Replace("\\", "/");
			if (inputType == "video")
			{
				if (hashSet.Contains(item))
				{
					list.Add(new Capcut.MediaFile
					{
						Type = "image",
						Filename = fileName,
						Path = path,
						Duration = imageDuration
					});
				}
				else if (hashSet2.Contains(item))
				{
					list.Add(new Capcut.MediaFile
					{
						Type = "video",
						Filename = fileName,
						Path = path,
						Duration = GetDurationFfprobe(item2)
					});
				}
			}
			else if (inputType == "audio" && hashSet3.Contains(item))
			{
				list.Add(new Capcut.MediaFile
				{
					Type = "audio",
					Filename = fileName,
					Path = path,
					Duration = GetDurationFfprobe(item2)
				});
			}
		}
		return list;
	}

	private double GetDurationFfprobe(string filePath)
	{
		try
		{
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = "ffprobe",
				Arguments = "-v quiet -show_entries format=duration -of default=noprint_wrappers=1:nokey=1 \"" + filePath + "\"",
				RedirectStandardOutput = true,
				RedirectStandardError = true,
				UseShellExecute = false,
				CreateNoWindow = true
			};
			using Process process = new Process
			{
				StartInfo = startInfo
			};
			process.Start();
			string text = process.StandardOutput.ReadToEnd().Trim();
			process.WaitForExit(10000);
			if (process.ExitCode == 0 && !string.IsNullOrEmpty(text) && double.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out var result))
			{
				return result;
			}
		}
		catch
		{
		}
		return 0.0;
	}

	private void btnCreateProj_Click(object sender, EventArgs e)
	{
		ConfigController.Insert(progConf);
		string videoPath = txtVideoDataPath.Text;
		string audioPath = txtAudioDataPath.Text;
		if (string.IsNullOrEmpty(videoPath) || !Directory.Exists(videoPath))
		{
			MessageBox.Show("Video Directory not exists !");
			return;
		}
		if (!string.IsNullOrEmpty(audioPath) && !Directory.Exists(audioPath))
		{
			MessageBox.Show("Audio Directory not exists !");
			return;
		}
		btnCreateProj.Enabled = false;
		lblCreateStatus.Text = "...";
		Thread thread = new Thread((ThreadStart)delegate
		{
			CreateProject(videoPath, audioPath, progConf.CapCutProjectSettings);
		});
		thread.IsBackground = true;
		thread.Start();
	}

	public void CreateProject(string VideoDir, string AudioDir, CapCutProjectSettings settings)
	{
		Invoke((MethodInvoker)delegate
		{
			lblCreateStatus.Text = "Importing ...";
		});
		List<Capcut.MediaFile> list = ScanAllMedia(VideoDir, "video", settings.DefaultDuration);
		List<Capcut.MediaFile> list2 = ScanAllMedia(AudioDir, "audio", settings.DefaultDuration);
		if (list.Exists((Capcut.MediaFile x) => x.Duration == 0.0))
		{
			Invoke((MethodInvoker)delegate
			{
				MessageBox.Show("Lỗi lấy độ dài video !, kiểm tra file ffprobe.exe");
			});
			return;
		}
		if (list2.Exists((Capcut.MediaFile x) => x.Duration == 0.0))
		{
			Invoke((MethodInvoker)delegate
			{
				MessageBox.Show("Lỗi lấy độ dài audio !, kiểm tra file ffprobe.exe");
			});
			return;
		}
		Invoke((MethodInvoker)delegate
		{
			lblCreateStatus.Text = "Creating ...";
		});
		Capcut.ProjectResult ret = CreateSimpleProject(list, list2, settings);
		Invoke((MethodInvoker)delegate
		{
			btnCreateProj.Enabled = true;
			lblCreateStatus.Text = "Finish: " + ret.Name;
			lblCreateStatus.Tag = ret.Path;
		});
	}

	private void txtVideoDataPath_TextChanged(object sender, EventArgs e)
	{
		progConf.CapCutProjectSettings.VideoFolder = txtVideoDataPath.Text;
	}

	private void txtAudioDataPath_TextChanged(object sender, EventArgs e)
	{
		progConf.CapCutProjectSettings.AudioFolder = txtAudioDataPath.Text;
	}

	private void lblCreateStatus_Click(object sender, EventArgs e)
	{
		string text = (string)lblCreateStatus.Tag;
		if (Directory.Exists(text))
		{
			Process.Start(text);
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		string text = (string)lblCreateStatus.Tag;
		if (Directory.Exists(text))
		{
			Process.Start(text);
		}
	}

	private void txtProjName_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsControl(e.KeyChar) && Path.GetInvalidFileNameChars().Contains(e.KeyChar))
		{
			e.Handled = true;
		}
	}

	private void btnOutputSrt_Click(object sender, EventArgs e)
	{
		string text = Path.Combine(progConf.CapcutPath, "User Data", "Projects", "com.lveditor.draft");
		if (!Directory.Exists(text))
		{
			MessageBox.Show("Directory not exists\n" + text);
		}
		else if (Directory.Exists(text))
		{
			Process.Start(text);
		}
	}

	private void txtCapcutPath_TextChanged(object sender, EventArgs e)
	{
	}

	private void nVideoSyncPlus_ValueChanged(object sender, EventArgs e)
	{
		progConf.VideoSyncPlus = (double)nVideoSyncPlus.Value;
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DgtAutoCapcut.Form1));
		this.btnSave = new System.Windows.Forms.Button();
		this.tabMain = new System.Windows.Forms.TabControl();
		this.tabCreateProj = new System.Windows.Forms.TabPage();
		this.lblCreateStatus = new System.Windows.Forms.LinkLabel();
		this.btnCreateProj = new System.Windows.Forms.Button();
		this.txtProjName = new System.Windows.Forms.TextBox();
		this.label40 = new System.Windows.Forms.Label();
		this.cbbCreateProjFps = new System.Windows.Forms.ComboBox();
		this.label39 = new System.Windows.Forms.Label();
		this.cbbCreateProjQuality = new System.Windows.Forms.ComboBox();
		this.label38 = new System.Windows.Forms.Label();
		this.cbbCreateProjRatio = new System.Windows.Forms.ComboBox();
		this.label37 = new System.Windows.Forms.Label();
		this.label36 = new System.Windows.Forms.Label();
		this.nImageDuration = new System.Windows.Forms.NumericUpDown();
		this.label35 = new System.Windows.Forms.Label();
		this.btnSelectAudioResouce = new System.Windows.Forms.Button();
		this.txtAudioDataPath = new System.Windows.Forms.TextBox();
		this.label34 = new System.Windows.Forms.Label();
		this.btnSelectVideoResouce = new System.Windows.Forms.Button();
		this.txtVideoDataPath = new System.Windows.Forms.TextBox();
		this.label33 = new System.Windows.Forms.Label();
		this.tabAnimation = new System.Windows.Forms.TabPage();
		this.ckMixAnimation = new System.Windows.Forms.CheckBox();
		this.groupBox3 = new System.Windows.Forms.GroupBox();
		this.ckAutoOff = new System.Windows.Forms.CheckBox();
		this.ck4K = new System.Windows.Forms.CheckBox();
		this.btnUpdate = new System.Windows.Forms.Button();
		this.label20 = new System.Windows.Forms.Label();
		this.nWaitRender = new System.Windows.Forms.NumericUpDown();
		this.label19 = new System.Windows.Forms.Label();
		this.label13 = new System.Windows.Forms.Label();
		this.label12 = new System.Windows.Forms.Label();
		this.label10 = new System.Windows.Forms.Label();
		this.nAnimationTime = new System.Windows.Forms.NumericUpDown();
		this.label11 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.tabControl2 = new System.Windows.Forms.TabControl();
		this.tabIn = new System.Windows.Forms.TabPage();
		this.ckIn = new System.Windows.Forms.CheckBox();
		this.dgvAnimationIn = new System.Windows.Forms.DataGridView();
		this.tabOut = new System.Windows.Forms.TabPage();
		this.ckOut = new System.Windows.Forms.CheckBox();
		this.dgvAnimationOut = new System.Windows.Forms.DataGridView();
		this.tabCombo = new System.Windows.Forms.TabPage();
		this.ckCombo = new System.Windows.Forms.CheckBox();
		this.dgvAnimationCombo = new System.Windows.Forms.DataGridView();
		this.nRandomAnimationEach = new System.Windows.Forms.NumericUpDown();
		this.tabEffect = new System.Windows.Forms.TabPage();
		this.ckAddEffect2Image = new System.Windows.Forms.CheckBox();
		this.btnAddEffects = new System.Windows.Forms.Button();
		this.btnRemoveAllEffects = new System.Windows.Forms.Button();
		this.label5 = new System.Windows.Forms.Label();
		this.nEffectDurationRate = new System.Windows.Forms.NumericUpDown();
		this.label4 = new System.Windows.Forms.Label();
		this.btnRemoveEffect = new System.Windows.Forms.Button();
		this.btnAddEffect = new System.Windows.Forms.Button();
		this.lstEffectUse = new System.Windows.Forms.ListBox();
		this.lstSearchEffectResult = new System.Windows.Forms.ListBox();
		this.txtSearchEffect = new System.Windows.Forms.TextBox();
		this.label3 = new System.Windows.Forms.Label();
		this.tabTransitions = new System.Windows.Forms.TabPage();
		this.btnAddTransitions = new System.Windows.Forms.Button();
		this.btnRemoveAllTransitions = new System.Windows.Forms.Button();
		this.label6 = new System.Windows.Forms.Label();
		this.nTransitionDuration = new System.Windows.Forms.NumericUpDown();
		this.label8 = new System.Windows.Forms.Label();
		this.btnRemoveTransition = new System.Windows.Forms.Button();
		this.btnAddTransiton = new System.Windows.Forms.Button();
		this.lstTransitionUse = new System.Windows.Forms.ListBox();
		this.lstSearchTransitionResult = new System.Windows.Forms.ListBox();
		this.txtSearchTransition = new System.Windows.Forms.TextBox();
		this.label7 = new System.Windows.Forms.Label();
		this.tabCaptions = new System.Windows.Forms.TabPage();
		this.label15 = new System.Windows.Forms.Label();
		this.label16 = new System.Windows.Forms.Label();
		this.label17 = new System.Windows.Forms.Label();
		this.nAddCaptionAnimationDuration = new System.Windows.Forms.NumericUpDown();
		this.label18 = new System.Windows.Forms.Label();
		this.btnAddCaptionAnimation = new System.Windows.Forms.Button();
		this.button2 = new System.Windows.Forms.Button();
		this.btnRemoveCaptionAnimationConfig = new System.Windows.Forms.Button();
		this.btnAddCaptionAnimationConfig = new System.Windows.Forms.Button();
		this.lstCaptionAnimationConfig = new System.Windows.Forms.ListBox();
		this.lstCaptionAnimation = new System.Windows.Forms.ListBox();
		this.txtSearchCaptionAnimation = new System.Windows.Forms.TextBox();
		this.label14 = new System.Windows.Forms.Label();
		this.tabKeyFrames = new System.Windows.Forms.TabPage();
		this.Y1 = new System.Windows.Forms.NumericUpDown();
		this.Y2 = new System.Windows.Forms.NumericUpDown();
		this.X2 = new System.Windows.Forms.NumericUpDown();
		this.X1 = new System.Windows.Forms.NumericUpDown();
		this.nbZoomOutEnd = new System.Windows.Forms.NumericUpDown();
		this.nbZoomOutStart = new System.Windows.Forms.NumericUpDown();
		this.nbZoomInMoveY = new System.Windows.Forms.NumericUpDown();
		this.nbZoomInEnd = new System.Windows.Forms.NumericUpDown();
		this.nbZoomInStart = new System.Windows.Forms.NumericUpDown();
		this.nbZoomInMoveX = new System.Windows.Forms.NumericUpDown();
		this.cbZoomMoveY = new System.Windows.Forms.CheckBox();
		this.cbZoomMoveX = new System.Windows.Forms.CheckBox();
		this.cbZoomout = new System.Windows.Forms.CheckBox();
		this.cbZoomIn = new System.Windows.Forms.CheckBox();
		this.cbFulldurationtime = new System.Windows.Forms.CheckBox();
		this.btnAddKeyFrames = new System.Windows.Forms.Button();
		this.btnClearKeyFrames = new System.Windows.Forms.Button();
		this.nStartKeyFrames = new System.Windows.Forms.NumericUpDown();
		this.label31 = new System.Windows.Forms.Label();
		this.label23 = new System.Windows.Forms.Label();
		this.label25 = new System.Windows.Forms.Label();
		this.label28 = new System.Windows.Forms.Label();
		this.label29 = new System.Windows.Forms.Label();
		this.label21 = new System.Windows.Forms.Label();
		this.label24 = new System.Windows.Forms.Label();
		this.label30 = new System.Windows.Forms.Label();
		this.label26 = new System.Windows.Forms.Label();
		this.label22 = new System.Windows.Forms.Label();
		this.label27 = new System.Windows.Forms.Label();
		this.tabExportSrt = new System.Windows.Forms.TabPage();
		this.btnOutputSrt = new System.Windows.Forms.Button();
		this.btnOneClickSync = new System.Windows.Forms.Button();
		this.btnMergeAudio = new System.Windows.Forms.Button();
		this.btnSplitVideoBySrt = new System.Windows.Forms.Button();
		this.btnGenerateCaption = new System.Windows.Forms.Button();
		this.groupBox2 = new System.Windows.Forms.GroupBox();
		this.label42 = new System.Windows.Forms.Label();
		this.nVideoSyncPlus = new System.Windows.Forms.NumericUpDown();
		this.label41 = new System.Windows.Forms.Label();
		this.label32 = new System.Windows.Forms.Label();
		this.cbbVideoOverAudio = new System.Windows.Forms.ComboBox();
		this.btnSyncSound = new System.Windows.Forms.Button();
		this.btnExportSrt = new System.Windows.Forms.Button();
		this.gbSettings = new System.Windows.Forms.GroupBox();
		this.txtExportPath = new System.Windows.Forms.TextBox();
		this.label9 = new System.Windows.Forms.Label();
		this.txtCapcutPath = new System.Windows.Forms.TextBox();
		this.label1 = new System.Windows.Forms.Label();
		this.groupBox1 = new System.Windows.Forms.GroupBox();
		this.btnCompoundClip = new System.Windows.Forms.Button();
		this.btnStop = new System.Windows.Forms.Button();
		this.btnOutput = new System.Windows.Forms.Button();
		this.btnAutoRender = new System.Windows.Forms.Button();
		this.btnRefresh = new System.Windows.Forms.Button();
		this.btnAddAnimation = new System.Windows.Forms.Button();
		this.ckAllProj = new System.Windows.Forms.CheckBox();
		this.btnRemoveAllAnimation = new System.Windows.Forms.Button();
		this.dgvProject = new System.Windows.Forms.DataGridView();
		this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
		this.lblLicense = new System.Windows.Forms.Label();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.lblSubtitle = new System.Windows.Forms.Label();
		this.tabMain.SuspendLayout();
		this.tabCreateProj.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nImageDuration).BeginInit();
		this.tabAnimation.SuspendLayout();
		this.groupBox3.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nWaitRender).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nAnimationTime).BeginInit();
		this.tabControl2.SuspendLayout();
		this.tabIn.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvAnimationIn).BeginInit();
		this.tabOut.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvAnimationOut).BeginInit();
		this.tabCombo.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvAnimationCombo).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nRandomAnimationEach).BeginInit();
		this.tabEffect.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nEffectDurationRate).BeginInit();
		this.tabTransitions.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nTransitionDuration).BeginInit();
		this.tabCaptions.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nAddCaptionAnimationDuration).BeginInit();
		this.tabKeyFrames.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.Y1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.Y2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.X2).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.X1).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nbZoomOutEnd).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nbZoomOutStart).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nbZoomInMoveY).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nbZoomInEnd).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nbZoomInStart).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nbZoomInMoveX).BeginInit();
		((System.ComponentModel.ISupportInitialize)this.nStartKeyFrames).BeginInit();
		this.tabExportSrt.SuspendLayout();
		this.groupBox2.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.nVideoSyncPlus).BeginInit();
		this.gbSettings.SuspendLayout();
		this.groupBox1.SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvProject).BeginInit();
		base.SuspendLayout();
		this.btnSave.BackColor = System.Drawing.Color.White;
		this.btnSave.Location = new System.Drawing.Point(434, 21);
		this.btnSave.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnSave.Name = "btnSave";
		this.btnSave.Size = new System.Drawing.Size(101, 52);
		this.btnSave.TabIndex = 1;
		this.btnSave.Text = "Save";
		this.btnSave.UseVisualStyleBackColor = false;
		this.btnSave.Click += new System.EventHandler(btnSave_Click);
		this.tabMain.Controls.Add(this.tabCreateProj);
		this.tabMain.Controls.Add(this.tabAnimation);
		this.tabMain.Controls.Add(this.tabEffect);
		this.tabMain.Controls.Add(this.tabTransitions);
		this.tabMain.Controls.Add(this.tabCaptions);
		this.tabMain.Controls.Add(this.tabKeyFrames);
		this.tabMain.Controls.Add(this.tabExportSrt);
		this.tabMain.Location = new System.Drawing.Point(10, 81);
		this.tabMain.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.tabMain.Name = "tabMain";
		this.tabMain.SelectedIndex = 0;
		this.tabMain.Size = new System.Drawing.Size(528, 374);
		this.tabMain.TabIndex = 2;
		this.tabCreateProj.Controls.Add(this.lblCreateStatus);
		this.tabCreateProj.Controls.Add(this.btnCreateProj);
		this.tabCreateProj.Controls.Add(this.txtProjName);
		this.tabCreateProj.Controls.Add(this.label40);
		this.tabCreateProj.Controls.Add(this.cbbCreateProjFps);
		this.tabCreateProj.Controls.Add(this.label39);
		this.tabCreateProj.Controls.Add(this.cbbCreateProjQuality);
		this.tabCreateProj.Controls.Add(this.label38);
		this.tabCreateProj.Controls.Add(this.cbbCreateProjRatio);
		this.tabCreateProj.Controls.Add(this.label37);
		this.tabCreateProj.Controls.Add(this.label36);
		this.tabCreateProj.Controls.Add(this.nImageDuration);
		this.tabCreateProj.Controls.Add(this.label35);
		this.tabCreateProj.Controls.Add(this.btnSelectAudioResouce);
		this.tabCreateProj.Controls.Add(this.txtAudioDataPath);
		this.tabCreateProj.Controls.Add(this.label34);
		this.tabCreateProj.Controls.Add(this.btnSelectVideoResouce);
		this.tabCreateProj.Controls.Add(this.txtVideoDataPath);
		this.tabCreateProj.Controls.Add(this.label33);
		this.tabCreateProj.Location = new System.Drawing.Point(4, 23);
		this.tabCreateProj.Name = "tabCreateProj";
		this.tabCreateProj.Padding = new System.Windows.Forms.Padding(3);
		this.tabCreateProj.Size = new System.Drawing.Size(520, 347);
		this.tabCreateProj.TabIndex = 6;
		this.tabCreateProj.Text = "Create Project";
		this.tabCreateProj.UseVisualStyleBackColor = true;
		this.lblCreateStatus.AutoSize = true;
		this.lblCreateStatus.Location = new System.Drawing.Point(179, 281);
		this.lblCreateStatus.Name = "lblCreateStatus";
		this.lblCreateStatus.Size = new System.Drawing.Size(19, 14);
		this.lblCreateStatus.TabIndex = 44;
		this.lblCreateStatus.TabStop = true;
		this.lblCreateStatus.Text = "...";
		this.lblCreateStatus.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		this.btnCreateProj.BackColor = System.Drawing.Color.LimeGreen;
		this.btnCreateProj.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.btnCreateProj.Location = new System.Drawing.Point(19, 269);
		this.btnCreateProj.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnCreateProj.Name = "btnCreateProj";
		this.btnCreateProj.Size = new System.Drawing.Size(152, 38);
		this.btnCreateProj.TabIndex = 13;
		this.btnCreateProj.Text = "Create Project";
		this.btnCreateProj.UseVisualStyleBackColor = false;
		this.btnCreateProj.Click += new System.EventHandler(btnCreateProj_Click);
		this.txtProjName.Location = new System.Drawing.Point(17, 47);
		this.txtProjName.Name = "txtProjName";
		this.txtProjName.Size = new System.Drawing.Size(318, 22);
		this.txtProjName.TabIndex = 42;
		this.txtProjName.TextChanged += new System.EventHandler(txtProjName_TextChanged);
		this.txtProjName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtProjName_KeyPress);
		this.label40.AutoSize = true;
		this.label40.Location = new System.Drawing.Point(14, 28);
		this.label40.Name = "label40";
		this.label40.Size = new System.Drawing.Size(96, 14);
		this.label40.TabIndex = 41;
		this.label40.Text = "Project Name:";
		this.cbbCreateProjFps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbCreateProjFps.FormattingEnabled = true;
		this.cbbCreateProjFps.Items.AddRange(new object[3] { "29.97", "30", "60" });
		this.cbbCreateProjFps.Location = new System.Drawing.Point(364, 225);
		this.cbbCreateProjFps.Name = "cbbCreateProjFps";
		this.cbbCreateProjFps.Size = new System.Drawing.Size(67, 22);
		this.cbbCreateProjFps.TabIndex = 40;
		this.cbbCreateProjFps.SelectedIndexChanged += new System.EventHandler(cbbCreateProjFps_SelectedIndexChanged);
		this.label39.AutoSize = true;
		this.label39.Location = new System.Drawing.Point(323, 228);
		this.label39.Name = "label39";
		this.label39.Size = new System.Drawing.Size(35, 14);
		this.label39.TabIndex = 39;
		this.label39.Text = "FPS:";
		this.cbbCreateProjQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbCreateProjQuality.FormattingEnabled = true;
		this.cbbCreateProjQuality.Items.AddRange(new object[4] { "1080p", "720p", "2K", "4K" });
		this.cbbCreateProjQuality.Location = new System.Drawing.Point(224, 225);
		this.cbbCreateProjQuality.Name = "cbbCreateProjQuality";
		this.cbbCreateProjQuality.Size = new System.Drawing.Size(67, 22);
		this.cbbCreateProjQuality.TabIndex = 38;
		this.cbbCreateProjQuality.SelectedIndexChanged += new System.EventHandler(cbbCreateProjQuality_SelectedIndexChanged);
		this.label38.AutoSize = true;
		this.label38.Location = new System.Drawing.Point(162, 228);
		this.label38.Name = "label38";
		this.label38.Size = new System.Drawing.Size(56, 14);
		this.label38.TabIndex = 37;
		this.label38.Text = "Quality:";
		this.cbbCreateProjRatio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbCreateProjRatio.FormattingEnabled = true;
		this.cbbCreateProjRatio.Items.AddRange(new object[2] { "16:9", "9:16" });
		this.cbbCreateProjRatio.Location = new System.Drawing.Point(64, 225);
		this.cbbCreateProjRatio.Name = "cbbCreateProjRatio";
		this.cbbCreateProjRatio.Size = new System.Drawing.Size(67, 22);
		this.cbbCreateProjRatio.TabIndex = 36;
		this.cbbCreateProjRatio.SelectedIndexChanged += new System.EventHandler(cbbCreateProjRatio_SelectedIndexChanged);
		this.label37.AutoSize = true;
		this.label37.Location = new System.Drawing.Point(14, 228);
		this.label37.Name = "label37";
		this.label37.Size = new System.Drawing.Size(44, 14);
		this.label37.TabIndex = 35;
		this.label37.Text = "Ratio:";
		this.label36.AutoSize = true;
		this.label36.Location = new System.Drawing.Point(209, 191);
		this.label36.Name = "label36";
		this.label36.Size = new System.Drawing.Size(24, 14);
		this.label36.TabIndex = 34;
		this.label36.Text = "(s)";
		this.nImageDuration.Location = new System.Drawing.Point(137, 189);
		this.nImageDuration.Name = "nImageDuration";
		this.nImageDuration.Size = new System.Drawing.Size(66, 22);
		this.nImageDuration.TabIndex = 33;
		this.nImageDuration.ValueChanged += new System.EventHandler(nImageDuration_ValueChanged);
		this.label35.AutoSize = true;
		this.label35.Location = new System.Drawing.Point(14, 191);
		this.label35.Name = "label35";
		this.label35.Size = new System.Drawing.Size(117, 14);
		this.label35.TabIndex = 32;
		this.label35.Text = "Image Durations:";
		this.btnSelectAudioResouce.BackColor = System.Drawing.Color.White;
		this.btnSelectAudioResouce.Location = new System.Drawing.Point(341, 151);
		this.btnSelectAudioResouce.Name = "btnSelectAudioResouce";
		this.btnSelectAudioResouce.Size = new System.Drawing.Size(66, 24);
		this.btnSelectAudioResouce.TabIndex = 31;
		this.btnSelectAudioResouce.Text = "Select";
		this.btnSelectAudioResouce.UseVisualStyleBackColor = false;
		this.btnSelectAudioResouce.Click += new System.EventHandler(btnSelectAudioResouce_Click);
		this.txtAudioDataPath.Location = new System.Drawing.Point(17, 152);
		this.txtAudioDataPath.Name = "txtAudioDataPath";
		this.txtAudioDataPath.Size = new System.Drawing.Size(318, 22);
		this.txtAudioDataPath.TabIndex = 30;
		this.txtAudioDataPath.TextChanged += new System.EventHandler(txtAudioDataPath_TextChanged);
		this.label34.AutoSize = true;
		this.label34.Location = new System.Drawing.Point(14, 133);
		this.label34.Name = "label34";
		this.label34.Size = new System.Drawing.Size(157, 14);
		this.label34.TabIndex = 29;
		this.label34.Text = "Audio Folder (Optional):";
		this.btnSelectVideoResouce.BackColor = System.Drawing.Color.White;
		this.btnSelectVideoResouce.Location = new System.Drawing.Point(341, 96);
		this.btnSelectVideoResouce.Name = "btnSelectVideoResouce";
		this.btnSelectVideoResouce.Size = new System.Drawing.Size(66, 24);
		this.btnSelectVideoResouce.TabIndex = 28;
		this.btnSelectVideoResouce.Text = "Select";
		this.btnSelectVideoResouce.UseVisualStyleBackColor = false;
		this.btnSelectVideoResouce.Click += new System.EventHandler(btnSelectVideoResouce_Click);
		this.txtVideoDataPath.Location = new System.Drawing.Point(17, 97);
		this.txtVideoDataPath.Name = "txtVideoDataPath";
		this.txtVideoDataPath.Size = new System.Drawing.Size(318, 22);
		this.txtVideoDataPath.TabIndex = 8;
		this.txtVideoDataPath.TextChanged += new System.EventHandler(txtVideoDataPath_TextChanged);
		this.label33.AutoSize = true;
		this.label33.Location = new System.Drawing.Point(14, 78);
		this.label33.Name = "label33";
		this.label33.Size = new System.Drawing.Size(157, 14);
		this.label33.TabIndex = 7;
		this.label33.Text = "Images / Videos Folder:";
		this.tabAnimation.Controls.Add(this.ckMixAnimation);
		this.tabAnimation.Controls.Add(this.groupBox3);
		this.tabAnimation.Controls.Add(this.btnUpdate);
		this.tabAnimation.Controls.Add(this.label20);
		this.tabAnimation.Controls.Add(this.nWaitRender);
		this.tabAnimation.Controls.Add(this.label19);
		this.tabAnimation.Controls.Add(this.label13);
		this.tabAnimation.Controls.Add(this.label12);
		this.tabAnimation.Controls.Add(this.label10);
		this.tabAnimation.Controls.Add(this.nAnimationTime);
		this.tabAnimation.Controls.Add(this.label11);
		this.tabAnimation.Controls.Add(this.label2);
		this.tabAnimation.Controls.Add(this.tabControl2);
		this.tabAnimation.Controls.Add(this.nRandomAnimationEach);
		this.tabAnimation.Location = new System.Drawing.Point(4, 23);
		this.tabAnimation.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.tabAnimation.Name = "tabAnimation";
		this.tabAnimation.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.tabAnimation.Size = new System.Drawing.Size(520, 347);
		this.tabAnimation.TabIndex = 0;
		this.tabAnimation.Text = "Animation";
		this.tabAnimation.UseVisualStyleBackColor = true;
		this.ckMixAnimation.AutoSize = true;
		this.ckMixAnimation.ForeColor = System.Drawing.Color.Teal;
		this.ckMixAnimation.Location = new System.Drawing.Point(233, 109);
		this.ckMixAnimation.Name = "ckMixAnimation";
		this.ckMixAnimation.Size = new System.Drawing.Size(219, 18);
		this.ckMixAnimation.TabIndex = 30;
		this.ckMixAnimation.Text = "Chèn nhiều Animation 1 Frame";
		this.ckMixAnimation.UseVisualStyleBackColor = true;
		this.ckMixAnimation.CheckedChanged += new System.EventHandler(ckMixAnimation_CheckedChanged);
		this.groupBox3.Controls.Add(this.ckAutoOff);
		this.groupBox3.Controls.Add(this.ck4K);
		this.groupBox3.Location = new System.Drawing.Point(229, 189);
		this.groupBox3.Name = "groupBox3";
		this.groupBox3.Size = new System.Drawing.Size(281, 106);
		this.groupBox3.TabIndex = 30;
		this.groupBox3.TabStop = false;
		this.groupBox3.Text = "Render";
		this.ckAutoOff.AutoSize = true;
		this.ckAutoOff.ForeColor = System.Drawing.Color.Blue;
		this.ckAutoOff.Location = new System.Drawing.Point(12, 24);
		this.ckAutoOff.Name = "ckAutoOff";
		this.ckAutoOff.Size = new System.Drawing.Size(259, 18);
		this.ckAutoOff.TabIndex = 1;
		this.ckAutoOff.Text = "Tự động tắt máy sau khi render xong";
		this.ckAutoOff.UseVisualStyleBackColor = true;
		this.ckAutoOff.CheckedChanged += new System.EventHandler(ckAutoOff_CheckedChanged);
		this.ck4K.AutoSize = true;
		this.ck4K.ForeColor = System.Drawing.Color.Black;
		this.ck4K.Location = new System.Drawing.Point(12, 52);
		this.ck4K.Name = "ck4K";
		this.ck4K.Size = new System.Drawing.Size(91, 18);
		this.ck4K.TabIndex = 29;
		this.ck4K.Text = "Render 4K";
		this.ck4K.UseVisualStyleBackColor = true;
		this.ck4K.CheckedChanged += new System.EventHandler(ck4K_CheckedChanged);
		this.btnUpdate.BackColor = System.Drawing.Color.White;
		this.btnUpdate.Enabled = false;
		this.btnUpdate.Location = new System.Drawing.Point(359, 301);
		this.btnUpdate.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnUpdate.Name = "btnUpdate";
		this.btnUpdate.Size = new System.Drawing.Size(151, 38);
		this.btnUpdate.TabIndex = 11;
		this.btnUpdate.Text = "Cập nhật hiệu ứng";
		this.btnUpdate.UseVisualStyleBackColor = false;
		this.btnUpdate.Click += new System.EventHandler(btnUpdate_Click);
		this.label20.AutoSize = true;
		this.label20.Location = new System.Drawing.Point(453, 165);
		this.label20.Name = "label20";
		this.label20.Size = new System.Drawing.Size(43, 14);
		this.label20.TabIndex = 28;
		this.label20.Text = "(giây)";
		this.nWaitRender.Location = new System.Drawing.Point(392, 163);
		this.nWaitRender.Maximum = new decimal(new int[4] { 9999, 0, 0, 0 });
		this.nWaitRender.Name = "nWaitRender";
		this.nWaitRender.Size = new System.Drawing.Size(55, 22);
		this.nWaitRender.TabIndex = 27;
		this.nWaitRender.ValueChanged += new System.EventHandler(nWaitRender_ValueChanged);
		this.label19.AutoSize = true;
		this.label19.Location = new System.Drawing.Point(237, 165);
		this.label19.Name = "label19";
		this.label19.Size = new System.Drawing.Size(152, 14);
		this.label19.TabIndex = 26;
		this.label19.Text = "Chờ sau khi mở Project";
		this.label13.AutoSize = true;
		this.label13.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 163);
		this.label13.Location = new System.Drawing.Point(302, 88);
		this.label13.Name = "label13";
		this.label13.Size = new System.Drawing.Size(169, 14);
		this.label13.TabIndex = 24;
		this.label13.Text = "(9999: nếu muốn fulltime)";
		this.label12.AutoSize = true;
		this.label12.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 163);
		this.label12.Location = new System.Drawing.Point(412, 62);
		this.label12.Name = "label12";
		this.label12.Size = new System.Drawing.Size(75, 14);
		this.label12.TabIndex = 23;
		this.label12.Text = "(0: default)";
		this.label10.AutoSize = true;
		this.label10.Location = new System.Drawing.Point(373, 62);
		this.label10.Name = "label10";
		this.label10.Size = new System.Drawing.Size(43, 14);
		this.label10.TabIndex = 22;
		this.label10.Text = "(giây)";
		this.nAnimationTime.DecimalPlaces = 1;
		this.nAnimationTime.Increment = new decimal(new int[4] { 1, 0, 0, 65536 });
		this.nAnimationTime.Location = new System.Drawing.Point(305, 60);
		this.nAnimationTime.Maximum = new decimal(new int[4] { 9999, 0, 0, 0 });
		this.nAnimationTime.Name = "nAnimationTime";
		this.nAnimationTime.Size = new System.Drawing.Size(66, 22);
		this.nAnimationTime.TabIndex = 21;
		this.nAnimationTime.ValueChanged += new System.EventHandler(nAnimationTime_ValueChanged);
		this.label11.AutoSize = true;
		this.label11.Location = new System.Drawing.Point(230, 62);
		this.label11.Name = "label11";
		this.label11.Size = new System.Drawing.Size(69, 14);
		this.label11.TabIndex = 20;
		this.label11.Text = "Thời gian:";
		this.label2.AutoSize = true;
		this.label2.Location = new System.Drawing.Point(230, 31);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(135, 14);
		this.label2.TabIndex = 6;
		this.label2.Text = "Random Cách Nhau:";
		this.tabControl2.Controls.Add(this.tabIn);
		this.tabControl2.Controls.Add(this.tabOut);
		this.tabControl2.Controls.Add(this.tabCombo);
		this.tabControl2.Location = new System.Drawing.Point(3, 3);
		this.tabControl2.Name = "tabControl2";
		this.tabControl2.SelectedIndex = 0;
		this.tabControl2.Size = new System.Drawing.Size(216, 338);
		this.tabControl2.TabIndex = 0;
		this.tabIn.Controls.Add(this.ckIn);
		this.tabIn.Controls.Add(this.dgvAnimationIn);
		this.tabIn.Location = new System.Drawing.Point(4, 23);
		this.tabIn.Name = "tabIn";
		this.tabIn.Padding = new System.Windows.Forms.Padding(3);
		this.tabIn.Size = new System.Drawing.Size(208, 311);
		this.tabIn.TabIndex = 0;
		this.tabIn.Text = "In";
		this.tabIn.UseVisualStyleBackColor = true;
		this.ckIn.AutoSize = true;
		this.ckIn.Location = new System.Drawing.Point(14, 8);
		this.ckIn.Name = "ckIn";
		this.ckIn.Size = new System.Drawing.Size(15, 14);
		this.ckIn.TabIndex = 6;
		this.ckIn.UseVisualStyleBackColor = true;
		this.ckIn.CheckedChanged += new System.EventHandler(ckIn_CheckedChanged);
		this.dgvAnimationIn.AllowUserToAddRows = false;
		this.dgvAnimationIn.AllowUserToDeleteRows = false;
		this.dgvAnimationIn.AllowUserToResizeColumns = false;
		this.dgvAnimationIn.AllowUserToResizeRows = false;
		this.dgvAnimationIn.BackgroundColor = System.Drawing.Color.White;
		this.dgvAnimationIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.dgvAnimationIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvAnimationIn.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dgvAnimationIn.Location = new System.Drawing.Point(3, 3);
		this.dgvAnimationIn.Name = "dgvAnimationIn";
		this.dgvAnimationIn.RowHeadersVisible = false;
		this.dgvAnimationIn.RowHeadersWidth = 51;
		this.dgvAnimationIn.Size = new System.Drawing.Size(202, 305);
		this.dgvAnimationIn.TabIndex = 0;
		this.tabOut.Controls.Add(this.ckOut);
		this.tabOut.Controls.Add(this.dgvAnimationOut);
		this.tabOut.Location = new System.Drawing.Point(4, 23);
		this.tabOut.Name = "tabOut";
		this.tabOut.Padding = new System.Windows.Forms.Padding(3);
		this.tabOut.Size = new System.Drawing.Size(208, 311);
		this.tabOut.TabIndex = 1;
		this.tabOut.Text = "Out";
		this.tabOut.UseVisualStyleBackColor = true;
		this.tabOut.Enter += new System.EventHandler(tabOut_Enter);
		this.ckOut.AutoSize = true;
		this.ckOut.Location = new System.Drawing.Point(14, 8);
		this.ckOut.Name = "ckOut";
		this.ckOut.Size = new System.Drawing.Size(15, 14);
		this.ckOut.TabIndex = 6;
		this.ckOut.UseVisualStyleBackColor = true;
		this.ckOut.CheckedChanged += new System.EventHandler(ckOut_CheckedChanged);
		this.dgvAnimationOut.AllowUserToAddRows = false;
		this.dgvAnimationOut.AllowUserToDeleteRows = false;
		this.dgvAnimationOut.AllowUserToResizeColumns = false;
		this.dgvAnimationOut.AllowUserToResizeRows = false;
		this.dgvAnimationOut.BackgroundColor = System.Drawing.Color.White;
		this.dgvAnimationOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.dgvAnimationOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvAnimationOut.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dgvAnimationOut.Location = new System.Drawing.Point(3, 3);
		this.dgvAnimationOut.Name = "dgvAnimationOut";
		this.dgvAnimationOut.RowHeadersVisible = false;
		this.dgvAnimationOut.RowHeadersWidth = 51;
		this.dgvAnimationOut.Size = new System.Drawing.Size(202, 305);
		this.dgvAnimationOut.TabIndex = 1;
		this.tabCombo.Controls.Add(this.ckCombo);
		this.tabCombo.Controls.Add(this.dgvAnimationCombo);
		this.tabCombo.Location = new System.Drawing.Point(4, 23);
		this.tabCombo.Name = "tabCombo";
		this.tabCombo.Size = new System.Drawing.Size(208, 311);
		this.tabCombo.TabIndex = 2;
		this.tabCombo.Text = "Combo";
		this.tabCombo.UseVisualStyleBackColor = true;
		this.ckCombo.AutoSize = true;
		this.ckCombo.Location = new System.Drawing.Point(11, 6);
		this.ckCombo.Name = "ckCombo";
		this.ckCombo.Size = new System.Drawing.Size(15, 14);
		this.ckCombo.TabIndex = 7;
		this.ckCombo.UseVisualStyleBackColor = true;
		this.ckCombo.CheckedChanged += new System.EventHandler(ckCombo_CheckedChanged);
		this.dgvAnimationCombo.AllowUserToAddRows = false;
		this.dgvAnimationCombo.AllowUserToDeleteRows = false;
		this.dgvAnimationCombo.AllowUserToResizeColumns = false;
		this.dgvAnimationCombo.AllowUserToResizeRows = false;
		this.dgvAnimationCombo.BackgroundColor = System.Drawing.Color.White;
		this.dgvAnimationCombo.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.dgvAnimationCombo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvAnimationCombo.Dock = System.Windows.Forms.DockStyle.Fill;
		this.dgvAnimationCombo.Location = new System.Drawing.Point(0, 0);
		this.dgvAnimationCombo.Name = "dgvAnimationCombo";
		this.dgvAnimationCombo.RowHeadersVisible = false;
		this.dgvAnimationCombo.RowHeadersWidth = 51;
		this.dgvAnimationCombo.Size = new System.Drawing.Size(208, 311);
		this.dgvAnimationCombo.TabIndex = 1;
		this.nRandomAnimationEach.Location = new System.Drawing.Point(371, 29);
		this.nRandomAnimationEach.Name = "nRandomAnimationEach";
		this.nRandomAnimationEach.Size = new System.Drawing.Size(66, 22);
		this.nRandomAnimationEach.TabIndex = 5;
		this.nRandomAnimationEach.ValueChanged += new System.EventHandler(nRandomAnimationEach_ValueChanged);
		this.tabEffect.Controls.Add(this.ckAddEffect2Image);
		this.tabEffect.Controls.Add(this.btnAddEffects);
		this.tabEffect.Controls.Add(this.btnRemoveAllEffects);
		this.tabEffect.Controls.Add(this.label5);
		this.tabEffect.Controls.Add(this.nEffectDurationRate);
		this.tabEffect.Controls.Add(this.label4);
		this.tabEffect.Controls.Add(this.btnRemoveEffect);
		this.tabEffect.Controls.Add(this.btnAddEffect);
		this.tabEffect.Controls.Add(this.lstEffectUse);
		this.tabEffect.Controls.Add(this.lstSearchEffectResult);
		this.tabEffect.Controls.Add(this.txtSearchEffect);
		this.tabEffect.Controls.Add(this.label3);
		this.tabEffect.Location = new System.Drawing.Point(4, 23);
		this.tabEffect.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.tabEffect.Name = "tabEffect";
		this.tabEffect.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.tabEffect.Size = new System.Drawing.Size(520, 347);
		this.tabEffect.TabIndex = 1;
		this.tabEffect.Text = "Effect";
		this.tabEffect.UseVisualStyleBackColor = true;
		this.ckAddEffect2Image.AutoSize = true;
		this.ckAddEffect2Image.Location = new System.Drawing.Point(18, 266);
		this.ckAddEffect2Image.Name = "ckAddEffect2Image";
		this.ckAddEffect2Image.Size = new System.Drawing.Size(195, 18);
		this.ckAddEffect2Image.TabIndex = 16;
		this.ckAddEffect2Image.Text = "Chèn Effect vào ảnh, video";
		this.ckAddEffect2Image.UseVisualStyleBackColor = true;
		this.ckAddEffect2Image.CheckedChanged += new System.EventHandler(ckAddEffect2Image_CheckedChanged);
		this.btnAddEffects.BackColor = System.Drawing.Color.White;
		this.btnAddEffects.Enabled = false;
		this.btnAddEffects.Location = new System.Drawing.Point(393, 56);
		this.btnAddEffects.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnAddEffects.Name = "btnAddEffects";
		this.btnAddEffects.Size = new System.Drawing.Size(117, 38);
		this.btnAddEffects.TabIndex = 15;
		this.btnAddEffects.Text = "Thêm Effects";
		this.btnAddEffects.UseVisualStyleBackColor = false;
		this.btnAddEffects.Click += new System.EventHandler(btnAddEffects_Click);
		this.btnRemoveAllEffects.BackColor = System.Drawing.Color.White;
		this.btnRemoveAllEffects.Enabled = false;
		this.btnRemoveAllEffects.ForeColor = System.Drawing.Color.Red;
		this.btnRemoveAllEffects.Location = new System.Drawing.Point(393, 12);
		this.btnRemoveAllEffects.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnRemoveAllEffects.Name = "btnRemoveAllEffects";
		this.btnRemoveAllEffects.Size = new System.Drawing.Size(117, 38);
		this.btnRemoveAllEffects.TabIndex = 14;
		this.btnRemoveAllEffects.Text = "Xóa tất cả";
		this.btnRemoveAllEffects.UseVisualStyleBackColor = false;
		this.btnRemoveAllEffects.Click += new System.EventHandler(btnRemoveAllEffects_Click);
		this.label5.AutoSize = true;
		this.label5.Location = new System.Drawing.Point(148, 226);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(30, 14);
		this.label5.TabIndex = 13;
		this.label5.Text = "(%)";
		this.nEffectDurationRate.Location = new System.Drawing.Point(90, 224);
		this.nEffectDurationRate.Name = "nEffectDurationRate";
		this.nEffectDurationRate.Size = new System.Drawing.Size(52, 22);
		this.nEffectDurationRate.TabIndex = 12;
		this.nEffectDurationRate.ValueChanged += new System.EventHandler(nEffectDurationRate_ValueChanged);
		this.label4.AutoSize = true;
		this.label4.Location = new System.Drawing.Point(15, 226);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(69, 14);
		this.label4.TabIndex = 11;
		this.label4.Text = "Thời gian:";
		this.btnRemoveEffect.BackColor = System.Drawing.Color.White;
		this.btnRemoveEffect.Location = new System.Drawing.Point(123, 119);
		this.btnRemoveEffect.Name = "btnRemoveEffect";
		this.btnRemoveEffect.Size = new System.Drawing.Size(66, 23);
		this.btnRemoveEffect.TabIndex = 10;
		this.btnRemoveEffect.Text = "[-] Xóa";
		this.btnRemoveEffect.UseVisualStyleBackColor = false;
		this.btnRemoveEffect.Click += new System.EventHandler(btnRemoveEffect_Click);
		this.btnAddEffect.BackColor = System.Drawing.Color.White;
		this.btnAddEffect.Location = new System.Drawing.Point(18, 119);
		this.btnAddEffect.Name = "btnAddEffect";
		this.btnAddEffect.Size = new System.Drawing.Size(99, 23);
		this.btnAddEffect.TabIndex = 9;
		this.btnAddEffect.Text = "[+] Thêm";
		this.btnAddEffect.UseVisualStyleBackColor = false;
		this.btnAddEffect.Click += new System.EventHandler(btnAddEffect_Click);
		this.lstEffectUse.FormattingEnabled = true;
		this.lstEffectUse.ItemHeight = 14;
		this.lstEffectUse.Location = new System.Drawing.Point(18, 148);
		this.lstEffectUse.Name = "lstEffectUse";
		this.lstEffectUse.Size = new System.Drawing.Size(314, 46);
		this.lstEffectUse.TabIndex = 8;
		this.lstEffectUse.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(lstEffectUse_MouseDoubleClick);
		this.lstSearchEffectResult.FormattingEnabled = true;
		this.lstSearchEffectResult.ItemHeight = 14;
		this.lstSearchEffectResult.Location = new System.Drawing.Point(18, 49);
		this.lstSearchEffectResult.Name = "lstSearchEffectResult";
		this.lstSearchEffectResult.Size = new System.Drawing.Size(314, 46);
		this.lstSearchEffectResult.TabIndex = 7;
		this.lstSearchEffectResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(lstSearchEffectResult_MouseDoubleClick);
		this.txtSearchEffect.Location = new System.Drawing.Point(76, 21);
		this.txtSearchEffect.Name = "txtSearchEffect";
		this.txtSearchEffect.Size = new System.Drawing.Size(256, 22);
		this.txtSearchEffect.TabIndex = 6;
		this.txtSearchEffect.TextChanged += new System.EventHandler(txtSearchEffect_TextChanged);
		this.label3.AutoSize = true;
		this.label3.Location = new System.Drawing.Point(15, 24);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(55, 14);
		this.label3.TabIndex = 5;
		this.label3.Text = "Search:";
		this.tabTransitions.Controls.Add(this.btnAddTransitions);
		this.tabTransitions.Controls.Add(this.btnRemoveAllTransitions);
		this.tabTransitions.Controls.Add(this.label6);
		this.tabTransitions.Controls.Add(this.nTransitionDuration);
		this.tabTransitions.Controls.Add(this.label8);
		this.tabTransitions.Controls.Add(this.btnRemoveTransition);
		this.tabTransitions.Controls.Add(this.btnAddTransiton);
		this.tabTransitions.Controls.Add(this.lstTransitionUse);
		this.tabTransitions.Controls.Add(this.lstSearchTransitionResult);
		this.tabTransitions.Controls.Add(this.txtSearchTransition);
		this.tabTransitions.Controls.Add(this.label7);
		this.tabTransitions.Location = new System.Drawing.Point(4, 23);
		this.tabTransitions.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.tabTransitions.Name = "tabTransitions";
		this.tabTransitions.Size = new System.Drawing.Size(520, 347);
		this.tabTransitions.TabIndex = 2;
		this.tabTransitions.Text = "Transitions";
		this.tabTransitions.UseVisualStyleBackColor = true;
		this.btnAddTransitions.BackColor = System.Drawing.Color.White;
		this.btnAddTransitions.Enabled = false;
		this.btnAddTransitions.Location = new System.Drawing.Point(393, 56);
		this.btnAddTransitions.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnAddTransitions.Name = "btnAddTransitions";
		this.btnAddTransitions.Size = new System.Drawing.Size(117, 38);
		this.btnAddTransitions.TabIndex = 21;
		this.btnAddTransitions.Text = "Thêm Transitions";
		this.btnAddTransitions.UseVisualStyleBackColor = false;
		this.btnAddTransitions.Click += new System.EventHandler(btnAddTransitions_Click);
		this.btnRemoveAllTransitions.BackColor = System.Drawing.Color.White;
		this.btnRemoveAllTransitions.Enabled = false;
		this.btnRemoveAllTransitions.ForeColor = System.Drawing.Color.Red;
		this.btnRemoveAllTransitions.Location = new System.Drawing.Point(393, 12);
		this.btnRemoveAllTransitions.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnRemoveAllTransitions.Name = "btnRemoveAllTransitions";
		this.btnRemoveAllTransitions.Size = new System.Drawing.Size(117, 38);
		this.btnRemoveAllTransitions.TabIndex = 20;
		this.btnRemoveAllTransitions.Text = "Xóa tất cả";
		this.btnRemoveAllTransitions.UseVisualStyleBackColor = false;
		this.btnRemoveAllTransitions.Click += new System.EventHandler(btnRemoveAllTransitions_Click);
		this.label6.AutoSize = true;
		this.label6.Location = new System.Drawing.Point(148, 226);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(43, 14);
		this.label6.TabIndex = 19;
		this.label6.Text = "(giây)";
		this.nTransitionDuration.DecimalPlaces = 1;
		this.nTransitionDuration.Increment = new decimal(new int[4] { 1, 0, 0, 65536 });
		this.nTransitionDuration.Location = new System.Drawing.Point(90, 224);
		this.nTransitionDuration.Name = "nTransitionDuration";
		this.nTransitionDuration.Size = new System.Drawing.Size(52, 22);
		this.nTransitionDuration.TabIndex = 18;
		this.nTransitionDuration.ValueChanged += new System.EventHandler(nTransitionDuration_ValueChanged);
		this.label8.AutoSize = true;
		this.label8.Location = new System.Drawing.Point(15, 226);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(69, 14);
		this.label8.TabIndex = 17;
		this.label8.Text = "Thời gian:";
		this.btnRemoveTransition.BackColor = System.Drawing.Color.White;
		this.btnRemoveTransition.Location = new System.Drawing.Point(123, 119);
		this.btnRemoveTransition.Name = "btnRemoveTransition";
		this.btnRemoveTransition.Size = new System.Drawing.Size(66, 23);
		this.btnRemoveTransition.TabIndex = 16;
		this.btnRemoveTransition.Text = "[-] Xóa";
		this.btnRemoveTransition.UseVisualStyleBackColor = false;
		this.btnRemoveTransition.Click += new System.EventHandler(btnRemoveTransition_Click);
		this.btnAddTransiton.BackColor = System.Drawing.Color.White;
		this.btnAddTransiton.Location = new System.Drawing.Point(18, 119);
		this.btnAddTransiton.Name = "btnAddTransiton";
		this.btnAddTransiton.Size = new System.Drawing.Size(99, 23);
		this.btnAddTransiton.TabIndex = 15;
		this.btnAddTransiton.Text = "[+] Thêm";
		this.btnAddTransiton.UseVisualStyleBackColor = false;
		this.btnAddTransiton.Click += new System.EventHandler(btnAddTransiton_Click);
		this.lstTransitionUse.FormattingEnabled = true;
		this.lstTransitionUse.ItemHeight = 14;
		this.lstTransitionUse.Location = new System.Drawing.Point(18, 148);
		this.lstTransitionUse.Name = "lstTransitionUse";
		this.lstTransitionUse.Size = new System.Drawing.Size(314, 46);
		this.lstTransitionUse.TabIndex = 14;
		this.lstTransitionUse.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(lstTransitionUse_MouseDoubleClick);
		this.lstSearchTransitionResult.FormattingEnabled = true;
		this.lstSearchTransitionResult.ItemHeight = 14;
		this.lstSearchTransitionResult.Location = new System.Drawing.Point(18, 49);
		this.lstSearchTransitionResult.Name = "lstSearchTransitionResult";
		this.lstSearchTransitionResult.Size = new System.Drawing.Size(314, 46);
		this.lstSearchTransitionResult.TabIndex = 10;
		this.lstSearchTransitionResult.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(lstSearchTransitionResult_MouseDoubleClick);
		this.txtSearchTransition.Location = new System.Drawing.Point(76, 21);
		this.txtSearchTransition.Name = "txtSearchTransition";
		this.txtSearchTransition.Size = new System.Drawing.Size(256, 22);
		this.txtSearchTransition.TabIndex = 9;
		this.txtSearchTransition.TextChanged += new System.EventHandler(txtSearchTransition_TextChanged);
		this.label7.AutoSize = true;
		this.label7.Location = new System.Drawing.Point(15, 24);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(55, 14);
		this.label7.TabIndex = 8;
		this.label7.Text = "Search:";
		this.tabCaptions.Controls.Add(this.label15);
		this.tabCaptions.Controls.Add(this.label16);
		this.tabCaptions.Controls.Add(this.label17);
		this.tabCaptions.Controls.Add(this.nAddCaptionAnimationDuration);
		this.tabCaptions.Controls.Add(this.label18);
		this.tabCaptions.Controls.Add(this.btnAddCaptionAnimation);
		this.tabCaptions.Controls.Add(this.button2);
		this.tabCaptions.Controls.Add(this.btnRemoveCaptionAnimationConfig);
		this.tabCaptions.Controls.Add(this.btnAddCaptionAnimationConfig);
		this.tabCaptions.Controls.Add(this.lstCaptionAnimationConfig);
		this.tabCaptions.Controls.Add(this.lstCaptionAnimation);
		this.tabCaptions.Controls.Add(this.txtSearchCaptionAnimation);
		this.tabCaptions.Controls.Add(this.label14);
		this.tabCaptions.Location = new System.Drawing.Point(4, 23);
		this.tabCaptions.Name = "tabCaptions";
		this.tabCaptions.Padding = new System.Windows.Forms.Padding(3);
		this.tabCaptions.Size = new System.Drawing.Size(520, 347);
		this.tabCaptions.TabIndex = 3;
		this.tabCaptions.Text = "Captions";
		this.tabCaptions.UseVisualStyleBackColor = true;
		this.label15.AutoSize = true;
		this.label15.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 163);
		this.label15.Location = new System.Drawing.Point(87, 251);
		this.label15.Name = "label15";
		this.label15.Size = new System.Drawing.Size(169, 14);
		this.label15.TabIndex = 34;
		this.label15.Text = "(9999: nếu muốn fulltime)";
		this.label16.AutoSize = true;
		this.label16.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 163);
		this.label16.Location = new System.Drawing.Point(202, 225);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(75, 14);
		this.label16.TabIndex = 33;
		this.label16.Text = "(0: default)";
		this.label17.AutoSize = true;
		this.label17.Location = new System.Drawing.Point(162, 225);
		this.label17.Name = "label17";
		this.label17.Size = new System.Drawing.Size(43, 14);
		this.label17.TabIndex = 32;
		this.label17.Text = "(giây)";
		this.nAddCaptionAnimationDuration.DecimalPlaces = 1;
		this.nAddCaptionAnimationDuration.Increment = new decimal(new int[4] { 1, 0, 0, 65536 });
		this.nAddCaptionAnimationDuration.Location = new System.Drawing.Point(90, 223);
		this.nAddCaptionAnimationDuration.Maximum = new decimal(new int[4] { 9999, 0, 0, 0 });
		this.nAddCaptionAnimationDuration.Name = "nAddCaptionAnimationDuration";
		this.nAddCaptionAnimationDuration.Size = new System.Drawing.Size(66, 22);
		this.nAddCaptionAnimationDuration.TabIndex = 31;
		this.label18.AutoSize = true;
		this.label18.Location = new System.Drawing.Point(15, 225);
		this.label18.Name = "label18";
		this.label18.Size = new System.Drawing.Size(69, 14);
		this.label18.TabIndex = 30;
		this.label18.Text = "Thời gian:";
		this.btnAddCaptionAnimation.BackColor = System.Drawing.Color.White;
		this.btnAddCaptionAnimation.Enabled = false;
		this.btnAddCaptionAnimation.Location = new System.Drawing.Point(390, 57);
		this.btnAddCaptionAnimation.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnAddCaptionAnimation.Name = "btnAddCaptionAnimation";
		this.btnAddCaptionAnimation.Size = new System.Drawing.Size(117, 38);
		this.btnAddCaptionAnimation.TabIndex = 29;
		this.btnAddCaptionAnimation.Text = "Chèn Animation";
		this.btnAddCaptionAnimation.UseVisualStyleBackColor = false;
		this.btnAddCaptionAnimation.Click += new System.EventHandler(btnAddCaptionAnimation_Click);
		this.button2.BackColor = System.Drawing.Color.White;
		this.button2.Enabled = false;
		this.button2.ForeColor = System.Drawing.Color.Red;
		this.button2.Location = new System.Drawing.Point(390, 13);
		this.button2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.button2.Name = "button2";
		this.button2.Size = new System.Drawing.Size(117, 38);
		this.button2.TabIndex = 28;
		this.button2.Text = "Xóa tất cả";
		this.button2.UseVisualStyleBackColor = false;
		this.button2.Click += new System.EventHandler(button2_Click);
		this.btnRemoveCaptionAnimationConfig.BackColor = System.Drawing.Color.White;
		this.btnRemoveCaptionAnimationConfig.Location = new System.Drawing.Point(120, 120);
		this.btnRemoveCaptionAnimationConfig.Name = "btnRemoveCaptionAnimationConfig";
		this.btnRemoveCaptionAnimationConfig.Size = new System.Drawing.Size(66, 23);
		this.btnRemoveCaptionAnimationConfig.TabIndex = 27;
		this.btnRemoveCaptionAnimationConfig.Text = "[-] Xóa";
		this.btnRemoveCaptionAnimationConfig.UseVisualStyleBackColor = false;
		this.btnRemoveCaptionAnimationConfig.Click += new System.EventHandler(btnRemoveCaptionAnimationConfig_Click);
		this.btnAddCaptionAnimationConfig.BackColor = System.Drawing.Color.White;
		this.btnAddCaptionAnimationConfig.Location = new System.Drawing.Point(15, 120);
		this.btnAddCaptionAnimationConfig.Name = "btnAddCaptionAnimationConfig";
		this.btnAddCaptionAnimationConfig.Size = new System.Drawing.Size(99, 23);
		this.btnAddCaptionAnimationConfig.TabIndex = 26;
		this.btnAddCaptionAnimationConfig.Text = "[+] Thêm";
		this.btnAddCaptionAnimationConfig.UseVisualStyleBackColor = false;
		this.btnAddCaptionAnimationConfig.Click += new System.EventHandler(btnAddCaptionAnimationConfig_Click);
		this.lstCaptionAnimationConfig.FormattingEnabled = true;
		this.lstCaptionAnimationConfig.ItemHeight = 14;
		this.lstCaptionAnimationConfig.Location = new System.Drawing.Point(15, 149);
		this.lstCaptionAnimationConfig.Name = "lstCaptionAnimationConfig";
		this.lstCaptionAnimationConfig.Size = new System.Drawing.Size(314, 46);
		this.lstCaptionAnimationConfig.TabIndex = 25;
		this.lstCaptionAnimationConfig.ValueMemberChanged += new System.EventHandler(lstCaptionAnimationConfig_ValueMemberChanged);
		this.lstCaptionAnimation.FormattingEnabled = true;
		this.lstCaptionAnimation.ItemHeight = 14;
		this.lstCaptionAnimation.Location = new System.Drawing.Point(15, 50);
		this.lstCaptionAnimation.Name = "lstCaptionAnimation";
		this.lstCaptionAnimation.Size = new System.Drawing.Size(314, 46);
		this.lstCaptionAnimation.TabIndex = 24;
		this.txtSearchCaptionAnimation.Location = new System.Drawing.Point(73, 22);
		this.txtSearchCaptionAnimation.Name = "txtSearchCaptionAnimation";
		this.txtSearchCaptionAnimation.Size = new System.Drawing.Size(256, 22);
		this.txtSearchCaptionAnimation.TabIndex = 23;
		this.txtSearchCaptionAnimation.TextChanged += new System.EventHandler(txtSearchCaptionAnimation_TextChanged);
		this.label14.AutoSize = true;
		this.label14.Location = new System.Drawing.Point(12, 25);
		this.label14.Name = "label14";
		this.label14.Size = new System.Drawing.Size(55, 14);
		this.label14.TabIndex = 22;
		this.label14.Text = "Search:";
		this.tabKeyFrames.Controls.Add(this.Y1);
		this.tabKeyFrames.Controls.Add(this.Y2);
		this.tabKeyFrames.Controls.Add(this.X2);
		this.tabKeyFrames.Controls.Add(this.X1);
		this.tabKeyFrames.Controls.Add(this.nbZoomOutEnd);
		this.tabKeyFrames.Controls.Add(this.nbZoomOutStart);
		this.tabKeyFrames.Controls.Add(this.nbZoomInMoveY);
		this.tabKeyFrames.Controls.Add(this.nbZoomInEnd);
		this.tabKeyFrames.Controls.Add(this.nbZoomInStart);
		this.tabKeyFrames.Controls.Add(this.nbZoomInMoveX);
		this.tabKeyFrames.Controls.Add(this.cbZoomMoveY);
		this.tabKeyFrames.Controls.Add(this.cbZoomMoveX);
		this.tabKeyFrames.Controls.Add(this.cbZoomout);
		this.tabKeyFrames.Controls.Add(this.cbZoomIn);
		this.tabKeyFrames.Controls.Add(this.cbFulldurationtime);
		this.tabKeyFrames.Controls.Add(this.btnAddKeyFrames);
		this.tabKeyFrames.Controls.Add(this.btnClearKeyFrames);
		this.tabKeyFrames.Controls.Add(this.nStartKeyFrames);
		this.tabKeyFrames.Controls.Add(this.label31);
		this.tabKeyFrames.Controls.Add(this.label23);
		this.tabKeyFrames.Controls.Add(this.label25);
		this.tabKeyFrames.Controls.Add(this.label28);
		this.tabKeyFrames.Controls.Add(this.label29);
		this.tabKeyFrames.Controls.Add(this.label21);
		this.tabKeyFrames.Controls.Add(this.label24);
		this.tabKeyFrames.Controls.Add(this.label30);
		this.tabKeyFrames.Controls.Add(this.label26);
		this.tabKeyFrames.Controls.Add(this.label22);
		this.tabKeyFrames.Controls.Add(this.label27);
		this.tabKeyFrames.Location = new System.Drawing.Point(4, 23);
		this.tabKeyFrames.Name = "tabKeyFrames";
		this.tabKeyFrames.Padding = new System.Windows.Forms.Padding(3);
		this.tabKeyFrames.Size = new System.Drawing.Size(520, 347);
		this.tabKeyFrames.TabIndex = 4;
		this.tabKeyFrames.Text = "KeyFrames";
		this.tabKeyFrames.UseVisualStyleBackColor = true;
		this.Y1.Location = new System.Drawing.Point(358, 259);
		this.Y1.Maximum = new decimal(new int[4] { 9999, 0, 0, 0 });
		this.Y1.Minimum = new decimal(new int[4] { 9999, 0, 0, -2147483648 });
		this.Y1.Name = "Y1";
		this.Y1.Size = new System.Drawing.Size(61, 22);
		this.Y1.TabIndex = 26;
		this.Y1.ValueChanged += new System.EventHandler(Y1_ValueChanged);
		this.Y2.Location = new System.Drawing.Point(453, 259);
		this.Y2.Maximum = new decimal(new int[4] { 9999, 0, 0, 0 });
		this.Y2.Minimum = new decimal(new int[4] { 9999, 0, 0, -2147483648 });
		this.Y2.Name = "Y2";
		this.Y2.Size = new System.Drawing.Size(61, 22);
		this.Y2.TabIndex = 26;
		this.Y2.ValueChanged += new System.EventHandler(Y2_ValueChanged);
		this.X2.Location = new System.Drawing.Point(453, 225);
		this.X2.Maximum = new decimal(new int[4] { 9999, 0, 0, 0 });
		this.X2.Minimum = new decimal(new int[4] { 9999, 0, 0, -2147483648 });
		this.X2.Name = "X2";
		this.X2.Size = new System.Drawing.Size(61, 22);
		this.X2.TabIndex = 26;
		this.X2.ValueChanged += new System.EventHandler(X2_ValueChanged);
		this.X1.Location = new System.Drawing.Point(358, 225);
		this.X1.Maximum = new decimal(new int[4] { 9999, 0, 0, 0 });
		this.X1.Minimum = new decimal(new int[4] { 9999, 0, 0, -2147483648 });
		this.X1.Name = "X1";
		this.X1.Size = new System.Drawing.Size(61, 22);
		this.X1.TabIndex = 26;
		this.X1.ValueChanged += new System.EventHandler(X1_ValueChanged);
		this.nbZoomOutEnd.Location = new System.Drawing.Point(329, 183);
		this.nbZoomOutEnd.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nbZoomOutEnd.Name = "nbZoomOutEnd";
		this.nbZoomOutEnd.Size = new System.Drawing.Size(61, 22);
		this.nbZoomOutEnd.TabIndex = 26;
		this.nbZoomOutEnd.ValueChanged += new System.EventHandler(nbZoomOutEnd_ValueChanged);
		this.nbZoomOutStart.Location = new System.Drawing.Point(195, 181);
		this.nbZoomOutStart.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nbZoomOutStart.Name = "nbZoomOutStart";
		this.nbZoomOutStart.Size = new System.Drawing.Size(61, 22);
		this.nbZoomOutStart.TabIndex = 26;
		this.nbZoomOutStart.ValueChanged += new System.EventHandler(nbZoomOutStart_ValueChanged);
		this.nbZoomInMoveY.Location = new System.Drawing.Point(262, 257);
		this.nbZoomInMoveY.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nbZoomInMoveY.Name = "nbZoomInMoveY";
		this.nbZoomInMoveY.Size = new System.Drawing.Size(61, 22);
		this.nbZoomInMoveY.TabIndex = 26;
		this.nbZoomInMoveY.ValueChanged += new System.EventHandler(nbZoomInMoveY_ValueChanged);
		this.nbZoomInEnd.Location = new System.Drawing.Point(329, 151);
		this.nbZoomInEnd.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nbZoomInEnd.Name = "nbZoomInEnd";
		this.nbZoomInEnd.Size = new System.Drawing.Size(61, 22);
		this.nbZoomInEnd.TabIndex = 26;
		this.nbZoomInEnd.ValueChanged += new System.EventHandler(nbZoomInEnd_ValueChanged);
		this.nbZoomInStart.Location = new System.Drawing.Point(195, 149);
		this.nbZoomInStart.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nbZoomInStart.Name = "nbZoomInStart";
		this.nbZoomInStart.Size = new System.Drawing.Size(61, 22);
		this.nbZoomInStart.TabIndex = 26;
		this.nbZoomInStart.ValueChanged += new System.EventHandler(nbZoomInStart_ValueChanged);
		this.nbZoomInMoveX.Location = new System.Drawing.Point(262, 225);
		this.nbZoomInMoveX.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.nbZoomInMoveX.Name = "nbZoomInMoveX";
		this.nbZoomInMoveX.Size = new System.Drawing.Size(61, 22);
		this.nbZoomInMoveX.TabIndex = 26;
		this.nbZoomInMoveX.ValueChanged += new System.EventHandler(nbZoomInMoveX_ValueChanged);
		this.cbZoomMoveY.AutoSize = true;
		this.cbZoomMoveY.Location = new System.Drawing.Point(6, 265);
		this.cbZoomMoveY.Name = "cbZoomMoveY";
		this.cbZoomMoveY.Size = new System.Drawing.Size(139, 18);
		this.cbZoomMoveY.TabIndex = 25;
		this.cbZoomMoveY.Text = "Zoom In + Move Y";
		this.cbZoomMoveY.UseVisualStyleBackColor = true;
		this.cbZoomMoveY.CheckedChanged += new System.EventHandler(cbZoomMoveY_CheckedChanged);
		this.cbZoomMoveX.AutoSize = true;
		this.cbZoomMoveX.Location = new System.Drawing.Point(6, 230);
		this.cbZoomMoveX.Name = "cbZoomMoveX";
		this.cbZoomMoveX.Size = new System.Drawing.Size(140, 18);
		this.cbZoomMoveX.TabIndex = 25;
		this.cbZoomMoveX.Text = "Zoom In + Move X";
		this.cbZoomMoveX.UseVisualStyleBackColor = true;
		this.cbZoomMoveX.CheckedChanged += new System.EventHandler(cbZoomMoveX_CheckedChanged);
		this.cbZoomout.AutoSize = true;
		this.cbZoomout.Location = new System.Drawing.Point(6, 186);
		this.cbZoomout.Name = "cbZoomout";
		this.cbZoomout.Size = new System.Drawing.Size(88, 18);
		this.cbZoomout.TabIndex = 25;
		this.cbZoomout.Text = "Zoom Out";
		this.cbZoomout.UseVisualStyleBackColor = true;
		this.cbZoomout.CheckedChanged += new System.EventHandler(cbZoomout_CheckedChanged);
		this.cbZoomIn.AutoSize = true;
		this.cbZoomIn.Location = new System.Drawing.Point(6, 147);
		this.cbZoomIn.Name = "cbZoomIn";
		this.cbZoomIn.Size = new System.Drawing.Size(78, 18);
		this.cbZoomIn.TabIndex = 25;
		this.cbZoomIn.Text = "Zoom In";
		this.cbZoomIn.UseVisualStyleBackColor = true;
		this.cbZoomIn.CheckedChanged += new System.EventHandler(cbZoomIn_CheckedChanged);
		this.cbFulldurationtime.AutoSize = true;
		this.cbFulldurationtime.Location = new System.Drawing.Point(157, 67);
		this.cbFulldurationtime.Name = "cbFulldurationtime";
		this.cbFulldurationtime.Size = new System.Drawing.Size(134, 18);
		this.cbFulldurationtime.TabIndex = 24;
		this.cbFulldurationtime.Text = "Full DurationTime";
		this.cbFulldurationtime.UseVisualStyleBackColor = true;
		this.cbFulldurationtime.CheckedChanged += new System.EventHandler(cbFulldurationtime_CheckedChanged);
		this.btnAddKeyFrames.BackColor = System.Drawing.Color.White;
		this.btnAddKeyFrames.Enabled = false;
		this.btnAddKeyFrames.Location = new System.Drawing.Point(398, 80);
		this.btnAddKeyFrames.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnAddKeyFrames.Name = "btnAddKeyFrames";
		this.btnAddKeyFrames.Size = new System.Drawing.Size(117, 51);
		this.btnAddKeyFrames.TabIndex = 23;
		this.btnAddKeyFrames.Text = "Thêm KeyFrames";
		this.btnAddKeyFrames.UseVisualStyleBackColor = false;
		this.btnAddKeyFrames.Click += new System.EventHandler(btnAddKeyFrames_Click);
		this.btnClearKeyFrames.BackColor = System.Drawing.Color.White;
		this.btnClearKeyFrames.Enabled = false;
		this.btnClearKeyFrames.ForeColor = System.Drawing.Color.Red;
		this.btnClearKeyFrames.Location = new System.Drawing.Point(398, 36);
		this.btnClearKeyFrames.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnClearKeyFrames.Name = "btnClearKeyFrames";
		this.btnClearKeyFrames.Size = new System.Drawing.Size(117, 38);
		this.btnClearKeyFrames.TabIndex = 22;
		this.btnClearKeyFrames.Text = "Xóa tất cả";
		this.btnClearKeyFrames.UseVisualStyleBackColor = false;
		this.btnClearKeyFrames.Click += new System.EventHandler(btnClearKeyFrames_Click);
		this.nStartKeyFrames.DecimalPlaces = 1;
		this.nStartKeyFrames.Increment = new decimal(new int[4] { 1, 0, 0, 65536 });
		this.nStartKeyFrames.Location = new System.Drawing.Point(96, 67);
		this.nStartKeyFrames.Name = "nStartKeyFrames";
		this.nStartKeyFrames.Size = new System.Drawing.Size(52, 22);
		this.nStartKeyFrames.TabIndex = 19;
		this.nStartKeyFrames.ValueChanged += new System.EventHandler(nStartKeyFrames_ValueChanged);
		this.label31.AutoSize = true;
		this.label31.Location = new System.Drawing.Point(258, 188);
		this.label31.Name = "label31";
		this.label31.Size = new System.Drawing.Size(54, 14);
		this.label31.TabIndex = 1;
		this.label31.Text = "End(%)";
		this.label23.AutoSize = true;
		this.label23.Location = new System.Drawing.Point(19, 69);
		this.label23.Name = "label23";
		this.label23.Size = new System.Drawing.Size(57, 14);
		this.label23.TabIndex = 1;
		this.label23.Text = "Time (s)";
		this.label25.AutoSize = true;
		this.label25.Location = new System.Drawing.Point(258, 151);
		this.label25.Name = "label25";
		this.label25.Size = new System.Drawing.Size(54, 14);
		this.label25.TabIndex = 1;
		this.label25.Text = "End(%)";
		this.label28.AutoSize = true;
		this.label28.Location = new System.Drawing.Point(181, 228);
		this.label28.Name = "label28";
		this.label28.Size = new System.Drawing.Size(61, 14);
		this.label28.TabIndex = 1;
		this.label28.Text = "Start(%)";
		this.label29.AutoSize = true;
		this.label29.ForeColor = System.Drawing.Color.Firebrick;
		this.label29.Location = new System.Drawing.Point(425, 267);
		this.label29.Name = "label29";
		this.label29.Size = new System.Drawing.Size(22, 14);
		this.label29.TabIndex = 1;
		this.label29.Text = "Y2";
		this.label21.AutoSize = true;
		this.label21.Location = new System.Drawing.Point(181, 263);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(61, 14);
		this.label21.TabIndex = 1;
		this.label21.Text = "Start(%)";
		this.label24.AutoSize = true;
		this.label24.ForeColor = System.Drawing.Color.Firebrick;
		this.label24.Location = new System.Drawing.Point(334, 266);
		this.label24.Name = "label24";
		this.label24.Size = new System.Drawing.Size(22, 14);
		this.label24.TabIndex = 1;
		this.label24.Text = "Y1";
		this.label30.AutoSize = true;
		this.label30.Location = new System.Drawing.Point(121, 188);
		this.label30.Name = "label30";
		this.label30.Size = new System.Drawing.Size(61, 14);
		this.label30.TabIndex = 1;
		this.label30.Text = "Start(%)";
		this.label26.AutoSize = true;
		this.label26.ForeColor = System.Drawing.Color.Firebrick;
		this.label26.Location = new System.Drawing.Point(425, 228);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(23, 14);
		this.label26.TabIndex = 1;
		this.label26.Text = "X2";
		this.label22.AutoSize = true;
		this.label22.Location = new System.Drawing.Point(121, 151);
		this.label22.Name = "label22";
		this.label22.Size = new System.Drawing.Size(61, 14);
		this.label22.TabIndex = 1;
		this.label22.Text = "Start(%)";
		this.label27.AutoSize = true;
		this.label27.ForeColor = System.Drawing.Color.Firebrick;
		this.label27.Location = new System.Drawing.Point(334, 227);
		this.label27.Name = "label27";
		this.label27.Size = new System.Drawing.Size(23, 14);
		this.label27.TabIndex = 1;
		this.label27.Text = "X1";
		this.tabExportSrt.Controls.Add(this.btnOutputSrt);
		this.tabExportSrt.Controls.Add(this.btnOneClickSync);
		this.tabExportSrt.Controls.Add(this.btnMergeAudio);
		this.tabExportSrt.Controls.Add(this.btnSplitVideoBySrt);
		this.tabExportSrt.Controls.Add(this.btnGenerateCaption);
		this.tabExportSrt.Controls.Add(this.groupBox2);
		this.tabExportSrt.Controls.Add(this.btnExportSrt);
		this.tabExportSrt.Location = new System.Drawing.Point(4, 23);
		this.tabExportSrt.Name = "tabExportSrt";
		this.tabExportSrt.Padding = new System.Windows.Forms.Padding(3);
		this.tabExportSrt.Size = new System.Drawing.Size(520, 347);
		this.tabExportSrt.TabIndex = 5;
		this.tabExportSrt.Text = "Captions && Sync";
		this.tabExportSrt.UseVisualStyleBackColor = true;
		this.btnOutputSrt.BackColor = System.Drawing.Color.White;
		this.btnOutputSrt.Location = new System.Drawing.Point(438, 15);
		this.btnOutputSrt.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnOutputSrt.Name = "btnOutputSrt";
		this.btnOutputSrt.Size = new System.Drawing.Size(69, 35);
		this.btnOutputSrt.TabIndex = 31;
		this.btnOutputSrt.Text = "Output";
		this.btnOutputSrt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnOutputSrt.UseVisualStyleBackColor = false;
		this.btnOutputSrt.Click += new System.EventHandler(btnOutputSrt_Click);
		this.btnOneClickSync.BackColor = System.Drawing.Color.White;
		this.btnOneClickSync.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.btnOneClickSync.ForeColor = System.Drawing.Color.Green;
		this.btnOneClickSync.Location = new System.Drawing.Point(140, 141);
		this.btnOneClickSync.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnOneClickSync.Name = "btnOneClickSync";
		this.btnOneClickSync.Size = new System.Drawing.Size(367, 38);
		this.btnOneClickSync.TabIndex = 30;
		this.btnOneClickSync.Text = "#. Tự động đồng bộ video && audio pro (One Click)";
		this.btnOneClickSync.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnOneClickSync.UseVisualStyleBackColor = false;
		this.btnOneClickSync.Click += new System.EventHandler(btnOneClickSync_Click);
		this.btnMergeAudio.BackColor = System.Drawing.Color.White;
		this.btnMergeAudio.Location = new System.Drawing.Point(261, 97);
		this.btnMergeAudio.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnMergeAudio.Name = "btnMergeAudio";
		this.btnMergeAudio.Size = new System.Drawing.Size(246, 38);
		this.btnMergeAudio.TabIndex = 29;
		this.btnMergeAudio.Text = "Gộp audio";
		this.btnMergeAudio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnMergeAudio.UseVisualStyleBackColor = false;
		this.btnMergeAudio.Click += new System.EventHandler(btnMergeAudio_Click);
		this.btnSplitVideoBySrt.BackColor = System.Drawing.Color.White;
		this.btnSplitVideoBySrt.Location = new System.Drawing.Point(261, 56);
		this.btnSplitVideoBySrt.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnSplitVideoBySrt.Name = "btnSplitVideoBySrt";
		this.btnSplitVideoBySrt.Size = new System.Drawing.Size(246, 35);
		this.btnSplitVideoBySrt.TabIndex = 28;
		this.btnSplitVideoBySrt.Text = "Cắt Video Theo Srt";
		this.btnSplitVideoBySrt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnSplitVideoBySrt.UseVisualStyleBackColor = false;
		this.btnSplitVideoBySrt.Click += new System.EventHandler(btnSplitVideoBySrt_Click);
		this.btnGenerateCaption.BackColor = System.Drawing.Color.White;
		this.btnGenerateCaption.Enabled = false;
		this.btnGenerateCaption.Location = new System.Drawing.Point(17, 15);
		this.btnGenerateCaption.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnGenerateCaption.Name = "btnGenerateCaption";
		this.btnGenerateCaption.Size = new System.Drawing.Size(234, 35);
		this.btnGenerateCaption.TabIndex = 10;
		this.btnGenerateCaption.Text = "Generate Captions (Tách Sub)";
		this.btnGenerateCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnGenerateCaption.UseVisualStyleBackColor = false;
		this.btnGenerateCaption.Click += new System.EventHandler(btnGenerateCaption_Click);
		this.groupBox2.Controls.Add(this.label42);
		this.groupBox2.Controls.Add(this.nVideoSyncPlus);
		this.groupBox2.Controls.Add(this.label41);
		this.groupBox2.Controls.Add(this.label32);
		this.groupBox2.Controls.Add(this.cbbVideoOverAudio);
		this.groupBox2.Controls.Add(this.btnSyncSound);
		this.groupBox2.Location = new System.Drawing.Point(17, 207);
		this.groupBox2.Name = "groupBox2";
		this.groupBox2.Size = new System.Drawing.Size(490, 122);
		this.groupBox2.TabIndex = 25;
		this.groupBox2.TabStop = false;
		this.groupBox2.Text = "Đồng bộ âm thanh";
		this.label42.AutoSize = true;
		this.label42.Location = new System.Drawing.Point(134, 74);
		this.label42.Name = "label42";
		this.label42.Size = new System.Drawing.Size(24, 14);
		this.label42.TabIndex = 14;
		this.label42.Text = "(s)";
		this.nVideoSyncPlus.DecimalPlaces = 1;
		this.nVideoSyncPlus.Increment = new decimal(new int[4] { 1, 0, 0, 65536 });
		this.nVideoSyncPlus.Location = new System.Drawing.Point(77, 72);
		this.nVideoSyncPlus.Name = "nVideoSyncPlus";
		this.nVideoSyncPlus.Size = new System.Drawing.Size(51, 22);
		this.nVideoSyncPlus.TabIndex = 13;
		this.nVideoSyncPlus.ValueChanged += new System.EventHandler(nVideoSyncPlus_ValueChanged);
		this.label41.AutoSize = true;
		this.label41.Location = new System.Drawing.Point(16, 74);
		this.label41.Name = "label41";
		this.label41.Size = new System.Drawing.Size(55, 14);
		this.label41.TabIndex = 12;
		this.label41.Text = "Video +";
		this.label32.AutoSize = true;
		this.label32.Location = new System.Drawing.Point(16, 29);
		this.label32.Name = "label32";
		this.label32.Size = new System.Drawing.Size(190, 14);
		this.label32.TabIndex = 11;
		this.label32.Text = "Nếu video dài hơn âm thanh:";
		this.cbbVideoOverAudio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.cbbVideoOverAudio.FormattingEnabled = true;
		this.cbbVideoOverAudio.Items.AddRange(new object[2] { "Cắt Video", "Tăng Tốc" });
		this.cbbVideoOverAudio.Location = new System.Drawing.Point(212, 26);
		this.cbbVideoOverAudio.Name = "cbbVideoOverAudio";
		this.cbbVideoOverAudio.Size = new System.Drawing.Size(128, 22);
		this.cbbVideoOverAudio.TabIndex = 10;
		this.cbbVideoOverAudio.SelectedIndexChanged += new System.EventHandler(cbbVideoOverAudio_SelectedIndexChanged);
		this.btnSyncSound.BackColor = System.Drawing.Color.White;
		this.btnSyncSound.Enabled = false;
		this.btnSyncSound.Location = new System.Drawing.Point(305, 66);
		this.btnSyncSound.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnSyncSound.Name = "btnSyncSound";
		this.btnSyncSound.Size = new System.Drawing.Size(167, 38);
		this.btnSyncSound.TabIndex = 9;
		this.btnSyncSound.Text = "Đồng bộ âm thanh";
		this.btnSyncSound.UseVisualStyleBackColor = false;
		this.btnSyncSound.Click += new System.EventHandler(btnSyncSound_Click);
		this.btnExportSrt.BackColor = System.Drawing.Color.White;
		this.btnExportSrt.Enabled = false;
		this.btnExportSrt.Location = new System.Drawing.Point(261, 15);
		this.btnExportSrt.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnExportSrt.Name = "btnExportSrt";
		this.btnExportSrt.Size = new System.Drawing.Size(172, 35);
		this.btnExportSrt.TabIndex = 26;
		this.btnExportSrt.Text = "Export Srt (Xuất phụ đề)";
		this.btnExportSrt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
		this.btnExportSrt.UseVisualStyleBackColor = false;
		this.btnExportSrt.Click += new System.EventHandler(btnExportSrt_Click);
		this.gbSettings.Controls.Add(this.txtExportPath);
		this.gbSettings.Controls.Add(this.label9);
		this.gbSettings.Controls.Add(this.txtCapcutPath);
		this.gbSettings.Controls.Add(this.label1);
		this.gbSettings.Controls.Add(this.tabMain);
		this.gbSettings.Controls.Add(this.btnSave);
		this.gbSettings.Location = new System.Drawing.Point(12, 12);
		this.gbSettings.Name = "gbSettings";
		this.gbSettings.Size = new System.Drawing.Size(547, 461);
		this.gbSettings.TabIndex = 3;
		this.gbSettings.TabStop = false;
		this.gbSettings.Text = "Settings";
		this.txtExportPath.Location = new System.Drawing.Point(108, 51);
		this.txtExportPath.Name = "txtExportPath";
		this.txtExportPath.ReadOnly = true;
		this.txtExportPath.Size = new System.Drawing.Size(318, 22);
		this.txtExportPath.TabIndex = 6;
		this.label9.AutoSize = true;
		this.label9.Location = new System.Drawing.Point(13, 55);
		this.label9.Name = "label9";
		this.label9.Size = new System.Drawing.Size(86, 14);
		this.label9.TabIndex = 5;
		this.label9.Text = "Export Path:";
		this.txtCapcutPath.Location = new System.Drawing.Point(108, 23);
		this.txtCapcutPath.Name = "txtCapcutPath";
		this.txtCapcutPath.Size = new System.Drawing.Size(318, 22);
		this.txtCapcutPath.TabIndex = 4;
		this.txtCapcutPath.TextChanged += new System.EventHandler(txtCapcutPath_TextChanged);
		this.label1.AutoSize = true;
		this.label1.Location = new System.Drawing.Point(13, 26);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(89, 14);
		this.label1.TabIndex = 3;
		this.label1.Text = "Capcut Path:";
		this.groupBox1.Controls.Add(this.btnCompoundClip);
		this.groupBox1.Controls.Add(this.btnStop);
		this.groupBox1.Controls.Add(this.btnOutput);
		this.groupBox1.Controls.Add(this.btnAutoRender);
		this.groupBox1.Controls.Add(this.btnRefresh);
		this.groupBox1.Controls.Add(this.btnAddAnimation);
		this.groupBox1.Controls.Add(this.ckAllProj);
		this.groupBox1.Controls.Add(this.btnRemoveAllAnimation);
		this.groupBox1.Controls.Add(this.dgvProject);
		this.groupBox1.Location = new System.Drawing.Point(565, 12);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new System.Drawing.Size(338, 461);
		this.groupBox1.TabIndex = 4;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "Project";
		this.btnCompoundClip.BackColor = System.Drawing.Color.Orange;
		this.btnCompoundClip.Location = new System.Drawing.Point(6, 373);
		this.btnCompoundClip.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnCompoundClip.Name = "btnCompoundClip";
		this.btnCompoundClip.Size = new System.Drawing.Size(152, 38);
		this.btnCompoundClip.TabIndex = 12;
		this.btnCompoundClip.Text = "Compound Clip";
		this.btnCompoundClip.UseVisualStyleBackColor = false;
		this.btnCompoundClip.Click += new System.EventHandler(btnCompoundClip_Click);
		this.btnStop.BackColor = System.Drawing.Color.White;
		this.btnStop.ForeColor = System.Drawing.Color.Red;
		this.btnStop.Location = new System.Drawing.Point(6, 417);
		this.btnStop.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnStop.Name = "btnStop";
		this.btnStop.Size = new System.Drawing.Size(108, 38);
		this.btnStop.TabIndex = 11;
		this.btnStop.Text = "Stop";
		this.btnStop.UseVisualStyleBackColor = false;
		this.btnStop.Click += new System.EventHandler(btnStop_Click);
		this.btnOutput.BackColor = System.Drawing.Color.White;
		this.btnOutput.Location = new System.Drawing.Point(126, 417);
		this.btnOutput.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnOutput.Name = "btnOutput";
		this.btnOutput.Size = new System.Drawing.Size(202, 38);
		this.btnOutput.TabIndex = 10;
		this.btnOutput.Text = "Output";
		this.btnOutput.UseVisualStyleBackColor = false;
		this.btnOutput.Click += new System.EventHandler(btnOutput_Click);
		this.btnAutoRender.BackColor = System.Drawing.Color.White;
		this.btnAutoRender.Enabled = false;
		this.btnAutoRender.Location = new System.Drawing.Point(168, 373);
		this.btnAutoRender.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnAutoRender.Name = "btnAutoRender";
		this.btnAutoRender.Size = new System.Drawing.Size(160, 38);
		this.btnAutoRender.TabIndex = 8;
		this.btnAutoRender.Text = "Auto Render";
		this.btnAutoRender.UseVisualStyleBackColor = false;
		this.btnAutoRender.Click += new System.EventHandler(btnAutoRender_Click);
		this.btnRefresh.BackColor = System.Drawing.Color.White;
		this.btnRefresh.Location = new System.Drawing.Point(6, 285);
		this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnRefresh.Name = "btnRefresh";
		this.btnRefresh.Size = new System.Drawing.Size(322, 38);
		this.btnRefresh.TabIndex = 7;
		this.btnRefresh.Text = "Refresh";
		this.btnRefresh.UseVisualStyleBackColor = false;
		this.btnRefresh.Click += new System.EventHandler(btnRefresh_Click);
		this.btnAddAnimation.BackColor = System.Drawing.Color.White;
		this.btnAddAnimation.Enabled = false;
		this.btnAddAnimation.Location = new System.Drawing.Point(6, 329);
		this.btnAddAnimation.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnAddAnimation.Name = "btnAddAnimation";
		this.btnAddAnimation.Size = new System.Drawing.Size(152, 38);
		this.btnAddAnimation.TabIndex = 5;
		this.btnAddAnimation.Text = "Chèn Animation";
		this.btnAddAnimation.UseVisualStyleBackColor = false;
		this.btnAddAnimation.Click += new System.EventHandler(btnAddAnimation_Click);
		this.ckAllProj.AutoSize = true;
		this.ckAllProj.Location = new System.Drawing.Point(16, 28);
		this.ckAllProj.Name = "ckAllProj";
		this.ckAllProj.Size = new System.Drawing.Size(15, 14);
		this.ckAllProj.TabIndex = 5;
		this.ckAllProj.UseVisualStyleBackColor = true;
		this.ckAllProj.CheckedChanged += new System.EventHandler(ckAllProj_CheckedChanged);
		this.btnRemoveAllAnimation.BackColor = System.Drawing.Color.White;
		this.btnRemoveAllAnimation.Enabled = false;
		this.btnRemoveAllAnimation.ForeColor = System.Drawing.Color.Red;
		this.btnRemoveAllAnimation.Location = new System.Drawing.Point(168, 329);
		this.btnRemoveAllAnimation.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		this.btnRemoveAllAnimation.Name = "btnRemoveAllAnimation";
		this.btnRemoveAllAnimation.Size = new System.Drawing.Size(160, 38);
		this.btnRemoveAllAnimation.TabIndex = 6;
		this.btnRemoveAllAnimation.Text = "Xóa tất cả Animation";
		this.btnRemoveAllAnimation.UseVisualStyleBackColor = false;
		this.btnRemoveAllAnimation.Click += new System.EventHandler(btnRemoveAllAnimation_Click);
		this.dgvProject.AllowUserToAddRows = false;
		this.dgvProject.AllowUserToDeleteRows = false;
		this.dgvProject.AllowUserToResizeRows = false;
		this.dgvProject.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
		this.dgvProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
		this.dgvProject.BackgroundColor = System.Drawing.Color.White;
		this.dgvProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.dgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
		this.dgvProject.Location = new System.Drawing.Point(6, 23);
		this.dgvProject.Name = "dgvProject";
		this.dgvProject.RowHeadersVisible = false;
		this.dgvProject.RowHeadersWidth = 51;
		this.dgvProject.Size = new System.Drawing.Size(326, 256);
		this.dgvProject.TabIndex = 1;
		this.entityCommand1.CommandTimeout = 0;
		this.entityCommand1.CommandTree = null;
		this.entityCommand1.Connection = null;
		this.entityCommand1.EnablePlanCaching = true;
		this.entityCommand1.Transaction = null;
		this.lblLicense.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
		this.lblLicense.Font = new System.Drawing.Font("Verdana", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 163);
		this.lblLicense.ForeColor = System.Drawing.Color.Purple;
		this.lblLicense.Location = new System.Drawing.Point(321, 480);
		this.lblLicense.Name = "lblLicense";
		this.lblLicense.Size = new System.Drawing.Size(582, 17);
		this.lblLicense.TabIndex = 17;
		this.lblLicense.Text = "...";
		this.lblLicense.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
		this.timer1.Enabled = true;
		this.timer1.Interval = 5000;
		this.timer1.Tick += new System.EventHandler(timer1_Tick);
		this.lblSubtitle.AutoSize = true;
		this.lblSubtitle.Location = new System.Drawing.Point(9, 481);
		this.lblSubtitle.Name = "lblSubtitle";
		this.lblSubtitle.Size = new System.Drawing.Size(12, 14);
		this.lblSubtitle.TabIndex = 43;
		this.lblSubtitle.Text = "-";
		base.AutoScaleDimensions = new System.Drawing.SizeF(8f, 14f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(253, 247, 255);
		base.ClientSize = new System.Drawing.Size(917, 501);
		base.Controls.Add(this.lblSubtitle);
		base.Controls.Add(this.lblLicense);
		base.Controls.Add(this.groupBox1);
		base.Controls.Add(this.gbSettings);
		this.Font = new System.Drawing.Font("Verdana", 9f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 163);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
		base.MaximizeBox = false;
		base.Name = "Form1";
		this.Text = "Dgt Auto CapCut - tipseotop.com V1.48";
		base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(Form1_FormClosing);
		base.Load += new System.EventHandler(Form1_Load);
		base.Shown += new System.EventHandler(Form1_Shown);
		this.tabMain.ResumeLayout(false);
		this.tabCreateProj.ResumeLayout(false);
		this.tabCreateProj.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nImageDuration).EndInit();
		this.tabAnimation.ResumeLayout(false);
		this.tabAnimation.PerformLayout();
		this.groupBox3.ResumeLayout(false);
		this.groupBox3.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nWaitRender).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nAnimationTime).EndInit();
		this.tabControl2.ResumeLayout(false);
		this.tabIn.ResumeLayout(false);
		this.tabIn.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvAnimationIn).EndInit();
		this.tabOut.ResumeLayout(false);
		this.tabOut.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvAnimationOut).EndInit();
		this.tabCombo.ResumeLayout(false);
		this.tabCombo.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvAnimationCombo).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nRandomAnimationEach).EndInit();
		this.tabEffect.ResumeLayout(false);
		this.tabEffect.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nEffectDurationRate).EndInit();
		this.tabTransitions.ResumeLayout(false);
		this.tabTransitions.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nTransitionDuration).EndInit();
		this.tabCaptions.ResumeLayout(false);
		this.tabCaptions.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nAddCaptionAnimationDuration).EndInit();
		this.tabKeyFrames.ResumeLayout(false);
		this.tabKeyFrames.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.Y1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.Y2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.X2).EndInit();
		((System.ComponentModel.ISupportInitialize)this.X1).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nbZoomOutEnd).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nbZoomOutStart).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nbZoomInMoveY).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nbZoomInEnd).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nbZoomInStart).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nbZoomInMoveX).EndInit();
		((System.ComponentModel.ISupportInitialize)this.nStartKeyFrames).EndInit();
		this.tabExportSrt.ResumeLayout(false);
		this.groupBox2.ResumeLayout(false);
		this.groupBox2.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.nVideoSyncPlus).EndInit();
		this.gbSettings.ResumeLayout(false);
		this.gbSettings.PerformLayout();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.dgvProject).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
