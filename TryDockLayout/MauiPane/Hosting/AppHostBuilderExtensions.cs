using Microsoft.Maui.Controls.Compatibility.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryDockLayout.MauiPane.Hosting
{
    public static class AppHostBuilderExtensions
    {
        public static MauiAppBuilder ConfigureMauiPane(this MauiAppBuilder builder)
        {
            builder
                .UseMauiCompatibility();

            return builder;
        }
    }
}
