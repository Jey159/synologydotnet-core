using Newtonsoft.Json;

namespace SynologyDotNet.Core.Model
{
    /// <summary>
    /// USBDevice
    /// </summary>
    public struct USBDevice
    {
        /// <summary>
        /// Gets and sets the CLS
        /// </summary>
        /// <value>
        /// The CLS
        /// </value>
        [JsonProperty("cls")]
        public string CLS { get; set; }

        /// <summary>
        /// Gets and sets the PID
        /// </summary>
        /// <value>
        /// The PID
        /// </value>
        [JsonProperty("pid")]
        public string PID { get; set; }

        /// <summary>
        /// Gets and sets the Producer
        /// </summary>
        /// <value>
        /// The Producer
        /// </value>
        [JsonProperty("producer")]
        public string Producer { get; set; }

        /// <summary>
        /// Gets and sets the Product
        /// </summary>
        /// <value>
        /// The Product
        /// </value>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// Gets and sets the REV
        /// </summary>
        /// <value>
        /// The REV
        /// </value>
        [JsonProperty("rev")]
        public string REV { get; set; }

        /// <summary>
        /// Gets and sets the VID
        /// </summary>
        /// <value>
        /// The VID
        /// </value>
        [JsonProperty("vid")]
        public string VID { get; set; }
    }
}