using System;
using NodaTime;

namespace NodaTimeTestings
{
	class Program
	{
		static void Main()
		{
			Instant now = SystemClock.Instance.Now;
			Console.WriteLine("now       : {0}",now);
			ZonedDateTime utcNow = now.InUtc();
			Console.WriteLine("utcNow    : {0}",utcNow);
			var poland = DateTimeZoneProviders.Tzdb["Europe/Warsaw"];

			var polandTime = now.InZone(poland);
			Console.WriteLine("in poland : {0}", polandTime);
		}
	}
}
