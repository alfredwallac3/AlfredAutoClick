using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlfredAutoClick
{
    /// <summary>
    /// Contains global information about the application.
    /// </summary>
    public static class AppInfo
    {
        /// <summary>
        /// Application name.
        /// </summary>
        public const string Name = "AlfredAutoClick";

        /// <summary>
        /// Application version.
        /// </summary>
        public const string Version = "1.0.0";

        /// <summary>
        /// Gets the full app name including version.
        /// </summary>
        public static string GetAppName()
        {
            return Name + " v" + Version;
        }
    }

}
