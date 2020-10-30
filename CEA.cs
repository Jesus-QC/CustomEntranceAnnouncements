using Exiled.API.Features;
using System;
using System.IO;

namespace CEA
{
    public class CEA : Plugin<Config>
    {
        public override string Name { get; } = "Entrance Messages";
        public override string Author { get; } = "JesusQC";
        public override string Prefix { get; } = "EntranceMessages";

        private EventHandlers EventHandlers;

        public override void OnEnabled()
        {
            base.OnEnabled();

            try
            {
                if (!Directory.Exists(Path.Combine(Paths.Plugins, "CustomEA")))
                {
                    Directory.CreateDirectory(Path.Combine(Paths.Plugins, "CustomEA"));
                }
            }
            catch (Exception error)
            {
                Log.Debug($"Error while creating directory: {error}");
            }

            EventHandlers = new EventHandlers(this);

            Exiled.Events.Handlers.Map.AnnouncingNtfEntrance += EventHandlers.AnnouncingMTF;
            Exiled.Events.Handlers.Server.RespawningTeam += EventHandlers.OnTeamRespawn;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            Exiled.Events.Handlers.Map.AnnouncingNtfEntrance -= EventHandlers.AnnouncingMTF;
            Exiled.Events.Handlers.Server.RespawningTeam -= EventHandlers.OnTeamRespawn;

            EventHandlers = null;
        }
    }
}