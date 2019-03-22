using System;
using Newtonsoft.Json;

namespace GrandSteal.Client.Models.Extensions.Json
{
	// Token: 0x02000011 RID: 17
	public static class JsonExtensions
	{
		// Token: 0x06000077 RID: 119 RVA: 0x00002405 File Offset: 0x00000605
		public static T FromJSON<T>(this string message)
		{
			return JsonConvert.DeserializeObject<T>(message);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000240D File Offset: 0x0000060D
		public static string ToJSON<T>(this T message)
		{
			return JsonConvert.SerializeObject(message);
		}
	}
}
