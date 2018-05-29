using Newtonsoft.Json;

namespace MinerStatusChecker.Models
{
    public class PerInfoDetails
    {
        private int m_Hash;
        private int m_PerAliveGpus;
        private int m_PerTotalGpus;
        private int m_PerAliveRigs;
        private int m_PerTotalRigs;
        private string m_PerHashGpu;
        private string m_PerHashRig;
        private int m_CurrentTime;

        [JsonProperty(PropertyName = "hash")]
        public int Hash { get => m_Hash; set => m_Hash = value; }
        [JsonProperty(PropertyName = "per_alive_gpus")]
        public int PerAliveGpus { get => m_PerAliveGpus; set => m_PerAliveGpus = value; }
        [JsonProperty(PropertyName = "per_total_gpus")]
        public int PerTotalGpus { get => m_PerTotalGpus; set => m_PerTotalGpus = value; }
        [JsonProperty(PropertyName = "per_alive_rigs")]
        public int PerAliveRigs { get => m_PerAliveRigs; set => m_PerAliveRigs = value; }
        [JsonProperty(PropertyName = "per_total_rigs")]
        public int PerTotalRigs { get => m_PerTotalRigs; set => m_PerTotalRigs = value; }
        [JsonProperty(PropertyName = "per_hash-gpu")]
        public string PerHashGpu { get => m_PerHashGpu; set => m_PerHashGpu = value; }
        [JsonProperty(PropertyName = "per_hash-rig")]
        public string PerHashRig { get => m_PerHashRig; set => m_PerHashRig = value; }
        [JsonProperty(PropertyName = "current_time")]
        public int CurrentTime { get => m_CurrentTime; set => m_CurrentTime = value; }
    }
}
