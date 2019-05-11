using System;
using Newtonsoft.Json;

namespace Cicerone.Models
{
	public abstract class BaseResponse<T>
	{
		[JsonProperty("response")]
		public T Response { get; set; }
	}
}
