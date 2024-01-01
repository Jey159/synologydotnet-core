using Newtonsoft.Json;

namespace SynologyDotNet.Core.Model
{
    /// <summary>
    /// SystemInfo
    /// </summary>
    public struct SytemInfo
    {
        /// <summary>
        /// Gets and sets the CPU Clock Speed
        /// </summary>
        /// <value>
        /// The CPU Clock Speed
        /// </value>
        [JsonProperty("cpu_clock_speed")]
        public int CPU_Clock_Speed { get; set; }

        /// <summary>
        /// Gets and sets the CPU Cores
        /// </summary>
        /// <value>
        /// The CPU Cores
        /// </value>
        [JsonProperty("cpu_cores")]
        public int CPU_Cores { get; set; }

        /// <summary>
        /// Gets and sets the CPU Family
        /// </summary>
        /// <value>
        /// The CPU Family
        /// </value>
        [JsonProperty("cpu_family")]
        public string CPU_Family { get; set; }

        /// <summary>
        /// Gets and sets the CPU Series
        /// </summary>
        /// <value>
        /// The CPU Series
        /// </value>
        [JsonProperty("cpu_series")]
        public string CPU_Series { get; set; }

        /// <summary>
        /// Gets and sets the CPU Vendor
        /// </summary>
        /// <value>
        /// The CPU Vendor
        /// </value>
        [JsonProperty("cpu_vendor")]
        public string CPU_Vendor { get; set; }

        /// <summary>
        /// Gets and sets the Enabled NTP
        /// </summary>
        /// <value>
        /// The Enabled NTP
        /// </value>
        [JsonProperty("enabled_ntp")]
        public bool Enabled_NTP { get; set; }

        /// <summary>
        /// Gets and sets the Firmware Date
        /// </summary>
        /// <value>
        /// The Firmware Date
        /// </value>
        [JsonProperty("firmware_date")]
        public string Firmware_Date { get; set; }

        /// <summary>
        /// Gets and sets the Firmware Version
        /// </summary>
        /// <value>
        /// The Firmware Version
        /// </value>
        [JsonProperty("firmware_ver")]
        public string Firmware_Ver { get; set; }

        /// <summary>
        /// Gets and sets the Model
        /// </summary>
        /// <value>
        /// The Model
        /// </value>
        [JsonProperty("model")]
        public string Model { get; set; }

        /// <summary>
        /// Gets and sets the NTP Server
        /// </summary>
        /// <value>
        /// The NTP Server
        /// </value>
        [JsonProperty("ntp_server")]
        public string NTP_Server { get; set; }

        /// <summary>
        /// Gets and sets the RAM Size
        /// </summary>
        /// <value>
        /// The RAM Size
        /// </value>
        [JsonProperty("ram_size")]
        public int RAM_Size { get; set; }

        /// <summary>
        /// Gets and sets the Serial Number
        /// </summary>
        /// <value>
        /// The Serial Number
        /// </value>
        [JsonProperty("serial")]
        public string Serial { get; set; }

        /// <summary>
        /// Gets and sets the Time
        /// </summary>
        /// <value>
        /// The Time
        /// </value>
        [JsonProperty("time")]
        public string Time { get; set; }

        /// <summary>
        /// Gets and sets the Time Zone
        /// </summary>
        /// <value>
        /// The Time Zone
        /// </value>
        [JsonProperty("time_zone")]
        public string Time_Zone { get; set; }

        /// <summary>
        /// Gets and sets the Time Zone Desc
        /// </summary>
        /// <value>
        /// The Time Zone Desc
        /// </value>
        [JsonProperty("time_zone_desc")]
        public string Time_Zone_Desc { get; set; }

        /// <summary>
        /// Gets and sets the Up Time
        /// </summary>
        /// <value>
        /// The Up Time
        /// </value>
        [JsonProperty("up_time")]
        public string Up_Time { get; set; }

        /// <summary>
        /// Gets and sets the Support for ESATA
        /// </summary>
        /// <value>
        /// The Support ESATA Flag
        /// </value>
        [JsonProperty("support_esata")]
        public string Support_ESATA { get; set; }

        /// <summary>
        /// Gets and sets the System Temperatur
        /// </summary>
        /// <value>
        /// The System Temperatur
        /// </value>
        [JsonProperty("sys_temp")]
        public int Sys_Temp { get; set; }

        /// <summary>
        /// Gets and sets the System Tempwarning Flag
        /// </summary>
        /// <value>
        /// The System Tempwarning Flag
        /// </value>
        [JsonProperty("sys_tempwarn")]
        public bool Sys_Tempwarn { get; set; }

        /// <summary>
        /// Gets and sets the System P Warning Flag
        /// </summary>
        /// <value>
        /// The System P Warning Flag
        /// </value>
        [JsonProperty("systempwarn")]
        public bool Systempwarn { get; set; }

        /// <summary>
        /// Gets and sets the Temperature Warning
        /// </summary>
        /// <value>
        /// The Temperature Warning
        /// </value>
        [JsonProperty("temperature_warning")]
        public bool Temperature_Warning { get; set; }

        /// <summary>
        /// Gets and sets the Array of USB Devices
        /// </summary>
        /// <value>
        /// The Array of USB Devices
        /// </value>
        [JsonProperty("usb_dev")]
        public USBDevice[] USB_Dev { get; set; }
    }
}