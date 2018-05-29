using Newtonsoft.Json;

namespace MinerStatusChecker.Models
{
    public class RigDetails
    {
        private string m_Condition;
        private string m_Version;
        private string m_Driver;
        private string m_Miner;
        private string m_Gpus;
        private string m_MinerInstance;
        private string m_MinerHashes;
        private string m_Bioses;
        private string m_MemInfo;
        private string m_VRamSize;
        private string m_DriveName;
        private string m_Mobo;
        private string m_BiosVersion;
        private string m_LanChip;
        private string m_ConnectedDisplays;
        private string m_Ram;
        private string m_Flags;
        private string m_RackLoc;
        private string m_Ip;
        private int m_ServerTime;
        private string m_UpTime;
        private int m_MinerSecs;
        private string m_RxKbps;
        private string m_TxKbps;
        private string m_Load;
        private string m_CpuTemp;
        private double m_FreeSpace;
        private double m_Hash;
        private string m_Pool;
        private string m_Temp;
        private string m_PowerTune;
        private string m_Voltage;
        private string m_Watts;
        private string m_FanRpm;
        private string m_Core;
        private string m_Mem;

        [JsonProperty(PropertyName = "condition")]
        public string Condition { get => m_Condition; set => m_Condition = value; }
        [JsonProperty(PropertyName = "version")]
        public string Version { get => m_Version; set => m_Version = value; }
        [JsonProperty(PropertyName = "driver")]
        public string Driver { get => m_Driver; set => m_Driver = value; }
        [JsonProperty(PropertyName = "miner")]
        public string Miner { get => m_Miner; set => m_Miner = value; }
        [JsonProperty(PropertyName = "gpus")]
        public string Gpus { get => m_Gpus; set => m_Gpus = value; }
        [JsonProperty(PropertyName = "miner_instance")]
        public string MinerInstance { get => m_MinerInstance; set => m_MinerInstance = value; }
        [JsonProperty(PropertyName = "miner_hashes")]
        public string MinerHashes { get => m_MinerHashes; set => m_MinerHashes = value; }
        [JsonProperty(PropertyName = "bioses")]
        public string Bioses { get => m_Bioses; set => m_Bioses = value; }
        [JsonProperty(PropertyName = "meminfo")]
        public string MemInfo { get => m_MemInfo; set => m_MemInfo = value; }
        [JsonProperty(PropertyName = "vramsize")]
        public string VRamSize { get => m_VRamSize; set => m_VRamSize = value; }
        [JsonProperty(PropertyName = "driver_name")]
        public string DriveName { get => m_DriveName; set => m_DriveName = value; }
        [JsonProperty(PropertyName = "mobo")]
        public string Mobo { get => m_Mobo; set => m_Mobo = value; }
        [JsonProperty(PropertyName = "biosversion")]
        public string BiosVersion { get => m_BiosVersion; set => m_BiosVersion = value; }
        [JsonProperty(PropertyName = "lan_chip")]
        public string LanChip { get => m_LanChip; set => m_LanChip = value; }
        [JsonProperty(PropertyName = "connected_displays")]
        public string ConnectedDisplays { get => m_ConnectedDisplays; set => m_ConnectedDisplays = value; }
        [JsonProperty(PropertyName = "ram")]
        public string Ram { get => m_Ram; set => m_Ram = value; }
        [JsonProperty(PropertyName = "flags")]
        public string Flags { get => m_Flags; set => m_Flags = value; }
        [JsonProperty(PropertyName = "rack_loc")]
        public string RackLoc { get => m_RackLoc; set => m_RackLoc = value; }
        [JsonProperty(PropertyName = "ip")]
        public string Ip { get => m_Ip; set => m_Ip = value; }
        [JsonProperty(PropertyName = "server_time")]
        public int ServerTime { get => m_ServerTime; set => m_ServerTime = value; }
        [JsonProperty(PropertyName = "uptime")]
        public string UpTime { get => m_UpTime; set => m_UpTime = value; }
        [JsonProperty(PropertyName = "miner_secs")]
        public int MinerSecs { get => m_MinerSecs; set => m_MinerSecs = value; }
        [JsonProperty(PropertyName = "rx_kbps")]
        public string RxKbps { get => m_RxKbps; set => m_RxKbps = value; }
        [JsonProperty(PropertyName = "tx_kbps")]
        public string TxKbps { get => m_TxKbps; set => m_TxKbps = value; }
        [JsonProperty(PropertyName = "load")]
        public string Load { get => m_Load; set => m_Load = value; }
        [JsonProperty(PropertyName = "cpu_temp")]
        public string CpuTemp { get => m_CpuTemp; set => m_CpuTemp = value; }
        [JsonProperty(PropertyName = "freespace")]
        public double FreeSpace { get => m_FreeSpace; set => m_FreeSpace = value; }
        [JsonProperty(PropertyName = "hash")]
        public double Hash { get => m_Hash; set => m_Hash = value; }
        [JsonProperty(PropertyName = "pool")]
        public string Pool { get => m_Pool; set => m_Pool = value; }
        [JsonProperty(PropertyName = "temp")]
        public string Temp { get => m_Temp; set => m_Temp = value; }
        [JsonProperty(PropertyName = "powertune")]
        public string PowerTune { get => m_PowerTune; set => m_PowerTune = value; }
        [JsonProperty(PropertyName = "voltage")]
        public string Voltage { get => m_Voltage; set => m_Voltage = value; }
        [JsonProperty(PropertyName = "watts")]
        public string Watts { get => m_Watts; set => m_Watts = value; }
        [JsonProperty(PropertyName = "fanrpm")]
        public string FanRpm { get => m_FanRpm; set => m_FanRpm = value; }
        [JsonProperty(PropertyName = "core")]
        public string Core { get => m_Core; set => m_Core = value; }
        [JsonProperty(PropertyName = "mem")]
        public string Mem { get => m_Mem; set => m_Mem = value; }
    }
}
