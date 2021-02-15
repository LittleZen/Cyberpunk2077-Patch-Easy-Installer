using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;

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
        /// Gets the latest version of CyberEngineTweaks according to the Github API.
        /// </summary>
        /// <returns>The filename of the release zip.</returns>
        public static GitHub GetGitHubAPIInfo(string username, string repo)
        {
            string responseJson = GetGitHubAPIDetails(username, repo);
            if (string.IsNullOrEmpty(responseJson))
                return null;

            return JsonConvert.DeserializeObject<GitHub>(responseJson);
        }

        private static string GetGitHubAPIDetails(string username, string repo) => GetStringFromURL($"https://api.github.com/repos/{username}/{repo}/releases/latest");
    }
}
