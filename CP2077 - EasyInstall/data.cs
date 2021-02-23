using Newtonsoft.Json;

namespace CP2077___EasyInstall
{
    public class Data
    {
        [JsonProperty("avx")]
        public bool AVX { get; set; }

        [JsonProperty("smt")]
        public bool SMT { get; set; }

        [JsonProperty("spectre")]
        public bool Spectre { get; set; }

        [JsonProperty("virtual_input")]
        public bool VirtualInput { get; set; }

        [JsonProperty("enable_debug")]
        public bool UnlockMenu { get; set; }

        [JsonProperty("remove_pedestrians")]
        public bool RemovePedestrians { get; set; }

        [JsonProperty("skip_start_menu")]
        public bool SkipStartMenu { get; set; }

        [JsonProperty("disable_async_compute")]
        public bool DisableAsyncCompute { get; set; }

        [JsonProperty("disable_antialiasing")]
        public bool DisableAntialiasing { get; set; }

        [JsonProperty("console")]
        public bool Console { get; set; }

        [JsonProperty("dump_game_options")]
        public bool DumpOption { get; set; }

        [JsonProperty("disable_boundary_teleport")]
        public bool DisableBoundaryTeleport { get; set; }

        [JsonProperty("disable_intro_movies")]
        public bool DisableIntroMovies { get; set; }

        [JsonProperty("disable_vignette")]
        public bool DisableVignette { get; set; }

        [JsonProperty("console_key")]
        public int ConsoleKey { get; set; }
    }
}
