﻿using Microsoft.Extensions.Logging;
using System.Globalization;

namespace JsonParser;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
