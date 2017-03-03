using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace AlainPinelRealtors
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			//app.Tap("button1");
			app.WaitForElement(x => x.Marked("button1"));
			app.Tap("button1");

			//app.Query(x => x.Marked("button1").Invoke("callOnClick"));

			//app.Flash(x => x.Marked("menuImage").Index(0));
			//app.Query(x => x.Marked("menuImage").Index(1).Invoke("callOnClick"));





		}



	}
}
