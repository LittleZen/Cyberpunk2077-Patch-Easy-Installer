using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

        /// <summary>
        /// Gets the latest version of Cyberpunk2077-Patch-Easy-Installer according to the Github API.
        /// </summary>
        /// <returns>A Version representing the latest available version of Cyberpunk2077-Patch-Easy-Installer, or null if the latest version could not be determined.</returns>
        public static Version GetLatestApplicationVersion()
        {
            string responseJson = GetGitHubAPIDetails("LittleZen", "Cyberpunk2077-Patch-Easy-Installer");
            if (string.IsNullOrEmpty(responseJson))
                return null;

            GitHub tagName = JsonConvert.DeserializeObject<GitHub>(responseJson);

            return !Version.TryParse(tagName.TagName.Remove(0, 1), out var latestVersion) ? null : latestVersion;
        }


        /// <summary>
        /// Gets the latest version of CyberEngineTweaks according to the Github API.
        /// </summary>
        /// <returns>The filename of the release zip.</returns>
        public static string GetLatestModRelease()
        {
            string responseJson = GetGitHubAPIDetails("yamashi", "CyberEngineTweaks");
            if (string.IsNullOrEmpty(responseJson))
                return null;
            
            GitHub releaseName = JsonConvert.DeserializeObject<GitHub>(responseJson);

            return releaseName.Assets[0].Name;
        }

        private static string GetGitHubAPIDetails(string username, string repo) => GetStringFromURL($"https://api.github.com/repos/{username}/{repo}/releases/latest");
    }
}
