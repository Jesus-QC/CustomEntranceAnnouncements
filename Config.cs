using Exiled.API.Interfaces;
using System.ComponentModel;

namespace CEA
{
    public sealed class Config : IConfig
    {
        [Description("Is the plugin enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Is the mtf sound enabled?")]
        public bool IsMTFEnabled { get; set; } = true;
        [Description("Name of the mp3 of mtf entry sound file inside Plugins/CustomEA")]
        public string MTFEntranceAudioPath { get; set; } = "mtfentry.mp3";
        [Description("Volume of MTFEntranceSound")]
        public float MTFEntranceVolume { get; set; } = 0.25f;

        [Description("Is the chaos sound enabled?")]
        public bool IsChaosEnabled { get; set; } = true;
        [Description("Name of the mp3 of chaos entry sound file inside Plugins/CustomEA")]
        public string ChaosEntranceAudioPath { get; set; } = "chaosentry.mp3";
        [Description("Volume of ChaosEntranceSound")]
        public float ChaosEntranceVolume { get; set; } = 0.75f;
    }
}
