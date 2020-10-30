using CommsHack;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System.IO;

namespace CEA
{
    internal class EventHandlers
    {
        private readonly CEA plugin;
        public EventHandlers(CEA plugin) => this.plugin = plugin;

        private string mainpath = Path.Combine(Paths.Plugins, "CustomEA");

        public void AnnouncingMTF(AnnouncingNtfEntranceEventArgs ev)
        {
            if (plugin.Config.IsMTFEnabled)
            {
                ev.IsAllowed = false;
                AudioAPI.API.PlayFile(Path.Combine(mainpath, plugin.Config.MTFEntranceAudioPath), plugin.Config.MTFEntranceVolume);
            }
        }

        internal void OnTeamRespawn(RespawningTeamEventArgs ev)
        {
            if (ev.NextKnownTeam == Respawning.SpawnableTeamType.ChaosInsurgency && plugin.Config.IsChaosEnabled)
            {
                AudioAPI.API.PlayFileRaw(Path.Combine(mainpath, plugin.Config.ChaosEntranceAudioPath), plugin.Config.ChaosEntranceVolume);
            }
        }
    }
}