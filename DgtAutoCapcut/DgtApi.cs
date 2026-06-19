using System;
using System.Collections.Generic;

namespace DgtAutoCapcut;

public class DgtApi
{
	public class AccountResponse
	{
		public string Id { get; set; }

		public string email { get; set; }

		public string password { get; set; }

		public string status { get; set; }
	}

	public class APIResponse
	{
		public string Token { get; set; }

		public int Result { get; set; }

		public string Msg { get; set; }

		public string Details { get; set; }

		public string Data { get; set; }

		public DateTime ExpiredDate { get; set; }

		public long MaxTab { get; set; }

		public long Money { get; set; }
	}

	public class ReadEmail
	{
		public class Result
		{
			public string id { get; set; }

			public string subject { get; set; }

			public string from { get; set; }
		}

		public class GetAll
		{
			public List<Result> results { get; set; }
		}

		public class EmailDetail
		{
			public string uid { get; set; }

			public string subject { get; set; }

			public string from { get; set; }

			public string receiver { get; set; }

			public string html_body { get; set; }

			public string text_body { get; set; }
		}
	}
}
