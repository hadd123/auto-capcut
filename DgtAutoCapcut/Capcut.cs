using System.Collections.Generic;
using Newtonsoft.Json;

namespace DgtAutoCapcut;

public class Capcut
{
	public class GetDataResponse
	{
		public int status { get; set; }

		public string message { get; set; }

		public List<CommonAttr> items { get; set; }
	}

	public class Author
	{
		public string name { get; set; }

		public string avatar_url { get; set; }

		public int source { get; set; }

		public string uid { get; set; }
	}

	public class BusinessInfo
	{
		public string json_str { get; set; }

		public string sign { get; set; }
	}

	public class CommonAttr
	{
		public bool isSelected { get; set; }

		public string id { get; set; }

		public string effect_id { get; set; }

		public int effect_type { get; set; }

		public string third_resource_id { get; set; }

		public string title { get; set; }

		public string description { get; set; }

		public List<string> item_urls { get; set; }

		public string md5 { get; set; }

		public string extra { get; set; }

		public string sdk_extra { get; set; }

		public List<int> category_ids { get; set; }
	}

	public class CoverUrl
	{
		public string small { get; set; }

		public string static_img { get; set; }
	}

	public class Data
	{
		public bool has_more { get; set; }

		public int next_offset { get; set; }

		public List<EffectItemList> effect_item_list { get; set; }

		public string version_code { get; set; }

		public string request_id { get; set; }

		public string fail_reason { get; set; }

		public bool compress_data { get; set; }

		public object specific_item_list { get; set; }
	}

	public class DownloadInfo
	{
		public string url { get; set; }

		public string format { get; set; }
	}

	public class EffectItemList
	{
		public CommonAttr common_attr { get; set; }

		public Author author { get; set; }

		public SpecialEffect special_effect { get; set; }
	}

	public class ReviewInfo
	{
		public int review_status { get; set; }

		public List<object> review_code_list { get; set; }

		public string extra_reason { get; set; }

		public List<object> review_reason_list { get; set; }
	}

	public class Category
	{
		[JsonProperty("category_id")]
		public int category_id { get; set; }

		[JsonProperty("category_name")]
		public string category_name { get; set; }

		[JsonProperty("category_key")]
		public string category_key { get; set; }

		[JsonProperty("category_is_top")]
		public bool category_is_top { get; set; }

		[JsonProperty("category_is_vip")]
		public bool category_is_vip { get; set; }

		[JsonProperty("category_source")]
		public int category_source { get; set; }

		[JsonProperty("category_icon")]
		public string category_icon { get; set; }

		[JsonProperty("category_selected_icon")]
		public string category_selected_icon { get; set; }

		[JsonProperty("name_starling_key")]
		public string name_starling_key { get; set; }

		[JsonProperty("sub_categories")]
		public object sub_categories { get; set; }

		[JsonProperty("category_extra")]
		public string category_extra { get; set; }

		[JsonProperty("parent_category")]
		public int parent_category { get; set; }

		[JsonProperty("panel")]
		public string panel { get; set; }
	}

	public class AllResource
	{
		[JsonProperty("categories")]
		public List<Category> categories { get; set; }

		public Dictionary<string, Data> category_resources { get; set; }
	}

	public class ResponseAllResource
	{
		public string ret { get; set; }

		public string errmsg { get; set; }

		public string systime { get; set; }

		public string logid { get; set; }

		public string sign { get; set; }

		public string response { get; set; }

		public AllResource data { get; set; }
	}

	public class Response
	{
		public string ret { get; set; }

		public string errmsg { get; set; }

		public string systime { get; set; }

		public string logid { get; set; }

		public string sign { get; set; }

		public string response { get; set; }

		public Data data { get; set; }
	}

	public class SpecialEffect
	{
		public int effect_duration { get; set; }
	}

	public class AllDraftStore
	{
		public bool isSelected { get; set; }

		public bool draft_cloud_last_action_download { get; set; }

		public string draft_cloud_purchase_info { get; set; }

		public string draft_cloud_template_id { get; set; }

		public string draft_cloud_tutorial_info { get; set; }

		public string draft_cloud_videocut_purchase_info { get; set; }

		public string draft_cover { get; set; }

		public string draft_fold_path { get; set; }

		public string draft_id { get; set; }

		public bool draft_is_ai_shorts { get; set; }

		public bool draft_is_invisible { get; set; }

		public string draft_json_file { get; set; }

		public string draft_name { get; set; }

		public string draft_new_version { get; set; }

		public string draft_root_path { get; set; }

		public long draft_timeline_materials_size { get; set; }

		public string draft_type { get; set; }

		public string tm_draft_cloud_completed { get; set; }

		public long tm_draft_cloud_modified { get; set; }

		public object tm_draft_create { get; set; }

		public long tm_draft_modified { get; set; }

		public long tm_draft_removed { get; set; }

		public long tm_duration { get; set; }

		public string status { get; set; }
	}

	public class Project
	{
		public List<AllDraftStore> all_draft_store { get; set; }

		public int draft_ids { get; set; }

		public string root_path { get; set; }
	}

	public class Animation
	{
		public object anim_adjust_params { get; set; }

		public string category_id { get; set; }

		public string category_name { get; set; }

		public long duration { get; set; }

		public string id { get; set; }

		public string material_type { get; set; }

		public string name { get; set; }

		public string panel { get; set; }

		public string path { get; set; }

		public string platform { get; set; }

		public string request_id { get; set; }

		public string resource_id { get; set; }

		public int source_platform { get; set; }

		public long start { get; set; }

		public string third_resource_id { get; set; }

		public string type { get; set; }
	}

	public class MaterialAnimation
	{
		public List<Animation> animations { get; set; }

		public string id { get; set; }

		public string multi_language_current { get; set; }

		public string type { get; set; }
	}

	public class Transition
	{
		public string category_id { get; set; }

		public string category_name { get; set; }

		public long duration { get; set; }

		public string effect_id { get; set; }

		public string id { get; set; }

		public bool is_overlap { get; set; }

		public string name { get; set; }

		public string path { get; set; }

		public string platform { get; set; }

		public string request_id { get; set; }

		public string resource_id { get; set; }

		public int source_platform { get; set; }

		public string third_resource_id { get; set; }

		public string type { get; set; }
	}

	public class AdjustParam
	{
		public double default_value { get; set; }

		public string name { get; set; }

		public double value { get; set; }
	}

	public class VideoEffects
	{
		public List<AdjustParam> adjust_params { get; set; }

		public string algorithm_artifact_path { get; set; }

		public int apply_target_type { get; set; }

		public object apply_time_range { get; set; }

		public string category_id { get; set; }

		public string category_name { get; set; }

		public string bind_segment_id { get; set; }

		public string transparent_params { get; set; }

		public List<object> common_keyframes { get; set; }

		public int covering_relation_change { get; set; }

		public List<object> disable_effect_faces { get; set; }

		public string effect_id { get; set; }

		public List<object> effect_mask { get; set; }

		public bool enable_mask { get; set; }

		public string formula_id { get; set; }

		public string id { get; set; }

		public int item_effect_type { get; set; }

		public string name { get; set; }

		public string path { get; set; }

		public string platform { get; set; }

		public int render_index { get; set; }

		public string request_id { get; set; }

		public string resource_id { get; set; }

		public int source_platform { get; set; }

		public object time_range { get; set; }

		public int track_render_index { get; set; }

		public string type { get; set; }

		public double value { get; set; }

		public string version { get; set; }
	}

	public class RenderTimerange
	{
		public long duration { get; set; }

		public int start { get; set; }
	}

	public class ResponsiveLayout
	{
		public bool enable { get; set; }

		public int horizontal_pos_layout { get; set; }

		public int size_layout { get; set; }

		public string target_follow { get; set; }

		public int vertical_pos_layout { get; set; }
	}

	public class Track
	{
		public int attribute { get; set; }

		public int flag { get; set; }

		public string id { get; set; }

		public bool is_default_name { get; set; }

		public string name { get; set; }

		public List<TrackSegment> segments { get; set; }

		public string type { get; set; }
	}

	public class TrackSegment
	{
		public object caption_info { get; set; }

		public bool cartoon { get; set; }

		public object clip { get; set; }

		public string color_correct_alg_result { get; set; }

		public List<common_keyframe> common_keyframes { get; set; }

		public string desc { get; set; }

		public string digital_human_template_group_id { get; set; }

		public bool enable_adjust { get; set; }

		public bool enable_adjust_mask { get; set; }

		public bool enable_color_correct_adjust { get; set; }

		public bool enable_color_curves { get; set; }

		public bool enable_color_match_adjust { get; set; }

		public bool enable_color_wheels { get; set; }

		public bool enable_hsl { get; set; }

		public bool enable_lut { get; set; }

		public bool enable_smart_color_adjust { get; set; }

		public bool enable_video_mask { get; set; }

		public List<object> extra_material_refs { get; set; }

		public string group_id { get; set; }

		public object hdr_settings { get; set; }

		public string id { get; set; }

		public bool intensifies_audio { get; set; }

		public bool is_loop { get; set; }

		public bool is_placeholder { get; set; }

		public bool is_tone_modify { get; set; }

		public List<object> keyframe_refs { get; set; }

		public double last_nonzero_volume { get; set; }

		public object lyric_keyframes { get; set; }

		public string material_id { get; set; }

		public string raw_segment_id { get; set; }

		public int render_index { get; set; }

		public RenderTimerange render_timerange { get; set; }

		public ResponsiveLayout responsive_layout { get; set; }

		public bool reverse { get; set; }

		public object source_timerange { get; set; }

		public double speed { get; set; }

		public int state { get; set; }

		public TargetTimerange target_timerange { get; set; }

		public string template_id { get; set; }

		public string template_scene { get; set; }

		public int track_attribute { get; set; }

		public int track_render_index { get; set; }

		public object uniform_scale { get; set; }

		public bool visible { get; set; }

		public double volume { get; set; }
	}

	public class TargetTimerange
	{
		public long duration { get; set; }

		public long start { get; set; }
	}

	public class Sound
	{
		public class Segment
		{
			public string id { get; set; }

			public string material_id { get; set; }

			public TargetTimerange source_timerange { get; set; }

			public TargetTimerange target_timerange { get; set; }
		}
	}

	public class ControlPoint
	{
		public double x { get; set; }

		public double y { get; set; }
	}

	public class common_keyframe
	{
		public string id { get; set; }

		public List<Keyframe> keyframe_list { get; set; }

		public string material_id { get; set; }

		public string property_type { get; set; }
	}

	public class Keyframe
	{
		public string curveType { get; set; }

		public string graphID { get; set; }

		public string id { get; set; }

		public ControlPoint left_control { get; set; }

		public ControlPoint right_control { get; set; }

		public string string_value { get; set; }

		public long time_offset { get; set; }

		public List<double> values { get; set; }
	}

	public class Subtitle
	{
		public int index { get; set; }

		public string id { get; set; }

		public string content { get; set; }

		public long startTime { get; set; }

		public long endTime { get; set; }
	}

	public class MediaFile
	{
		public string Type { get; set; }

		public string Filename { get; set; }

		public string Path { get; set; }

		public double Duration { get; set; }
	}

	public class ProjectResult
	{
		public string Path { get; set; }

		public string Id { get; set; }

		public string Name { get; set; }
	}
}
