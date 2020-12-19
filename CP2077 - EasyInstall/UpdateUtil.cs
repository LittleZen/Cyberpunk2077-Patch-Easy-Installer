using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace CP2077___EasyInstall
{
    class UpdateUtil
    {
        public static string GetStringFromURL(string url)
        {
            try
            {
                var stream = GetStreamFromURL(url);
                using (var reader = new StreamReader(stream))
                    return reader.ReadToEnd();
            }
            // No internet?
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return null;
            }
        }

        private static Stream GetStreamFromURL(string url)
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            // The GitHub API will fail if no user agent is provided
            httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/60.0.3112.113 Safari/537.36";

            var httpWebResponse = httpWebRequest.GetResponse();
            return httpWebResponse.GetResponseStream();
        }

        private static readonly Regex LatestGitTagRegex = new Regex("\\\"tag_name\"\\s*\\:\\s*\\\"([v])([0-9]+\\.[0-9])\\\""); // Match `"tag_name": "v2.7"`. Group 1 is `v2.7`

        /// <summary>
        /// Gets the latest version of Cyberpunk2077-Patch-Easy-Installer according to the Github API
        /// </summary>
        /// <returns>A version representing the latest available version of Cyberpunk2077-Patch-Easy-Installer, or null if the latest version could not be determined</returns>
        public static Version GetLatestVersion()
        {
            const string apiEndpoint = "https://api.github.com/repos/LittleZen/Cyberpunk2077-Patch-Easy-Installer/releases/latest";
            var responseJson = GetStringFromURL(apiEndpoint);
            if (string.IsNullOrEmpty(responseJson))
                return null;

            // Using a regex to get the tag to avoid importing an entire JSON parsing library
            var tagMatch = LatestGitTagRegex.Match(responseJson);
            if (!tagMatch.Success)
                return null;

            var tagString = tagMatch.Groups[2].Value;
            return !Version.TryParse(tagString, out var latestVersion) ? null : latestVersion;
        }
    }
}
