using System;
using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using SCPUtils.Editors;
using Player = Exiled.Events.Handlers.Player;

namespace SCPUtils
{
    public class SCPUtilsPlugin : Plugin<Config>
    {
        public override string Name => "SCPUtils";
        public override string Author => "Swishhyy";
        public override Version Version => new Version(1, 0, 0);

        private readonly List<IScpEditor> scpEditors = new List<IScpEditor>();

        public override void OnEnabled()
        {
            InitializeEditors();
            Player.Verified += OnPlayerVerified;

            Log.Info($"{Name} v{Version} by {Author} has been enabled!");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.Verified -= OnPlayerVerified;
            Log.Info($"{Name} has been disabled!");
            base.OnDisabled();
        }

        private void InitializeEditors()
        {
            scpEditors.Clear();
            scpEditors.AddRange(new IScpEditor[]
            {
                new Scp049Editor(),
                new Scp0492Editor(),
                new Scp079Editor(),
                new Scp096Editor(),
                new Scp106Editor(),
                new Scp173Editor(),
                new Scp939Editor()
            });
        }

        private void OnPlayerVerified(VerifiedEventArgs ev)
        {
            foreach (var editor in scpEditors)
            {
                editor.TryEdit(ev, Config);
            }
        }
    }
}
