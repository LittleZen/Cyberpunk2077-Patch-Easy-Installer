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

        [JsonProperty("memory_pool")]
        public bool MemoryPool { get; set; }

        [JsonProperty("unlock_menu")]
        public bool UnlockMenu { get; set; }

        [JsonProperty("cpu_memory_pool_fraction")]
        public decimal CPUMemoryPoolFraction { get; set; }

        [JsonProperty("gpu_memory_pool_fraction")]
        public decimal GPUMemoryPoolFraction { get; set; }

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
    }
}
