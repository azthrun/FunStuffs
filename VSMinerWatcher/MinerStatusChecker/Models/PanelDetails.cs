using Newtonsoft.Json;
using System.Collections.Generic;

namespace MinerStatusChecker.Models
{
    public class PanelDetails
    {
        private Dictionary<string, RigDetails> m_Rigs;
        private double m_TotalHash;
        private int m_AliveGpus;
        private int m_TotalGpus;
        private int m_AliveRigs;
        private int m_TotalRigs;
        private string m_CurrentVersion;
        private double m_AvgTemp;
        private string m_Capacity;
        private Dictionary<string, PerInfoDetails> m_PerInfo;

        [JsonProperty(PropertyName = "rigs")]
        public Dictionary<string, RigDetails> Rigs { get => m_Rigs; set => m_Rigs = value; }
        [JsonProperty(PropertyName = "total_hash")]
        public double TotalHash { get => m_TotalHash; set => m_TotalHash = value; }
        [JsonProperty(PropertyName = "alive_gpus")]
        public int AliveGpus { get => m_AliveGpus; set => m_AliveGpus = value; }
        [JsonProperty(PropertyName = "total_gpus")]
        public int TotalGpus { get => m_TotalGpus; set => m_TotalGpus = value; }
        [JsonProperty(PropertyName = "alive_rigs")]
        public int AliveRigs { get => m_AliveRigs; set => m_AliveRigs = value; }
        [JsonProperty(PropertyName = "total_rigs")]
        public int TotalRigs { get => m_TotalRigs; set => m_TotalRigs = value; }
        [JsonProperty(PropertyName = "current_version")]
        public string CurrentVersion { get => m_CurrentVersion; set => m_CurrentVersion = value; }
        [JsonProperty(PropertyName = "avg_temp")]
        public double AvgTemp { get => m_AvgTemp; set => m_AvgTemp = value; }
        [JsonProperty(PropertyName = "capacity")]
        public string Capacity { get => m_Capacity; set => m_Capacity = value; }
        [JsonProperty(PropertyName = "per_info")]
        public Dictionary<string, PerInfoDetails> PerInfo { get => m_PerInfo; set => m_PerInfo = value; }
    }
}
