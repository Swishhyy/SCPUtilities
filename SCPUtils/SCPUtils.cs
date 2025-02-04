using System;
using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Player;
using SCPUtils.Editors;
using Player = Exiled.Events.Handlers.Player; // Ensure we're referencing the correct Player event handler

namespace SCPUtils
{
    public class SCPUtilsPlugin : Plugin<Config>
    {
        public override string Name => "SCPUtils";
        public override string Author => "Swishhyy";
        public override Version Version => new Version(1, 0, 0);

        // A list to hold each SCP editor; initialized inline to avoid nullability issues.
        private List<IScpEditor> scpEditors = new List<IScpEditor>();

        public override void OnEnabled()
        {
            // Instantiate your SCP editors.
            scpEditors = new List<IScpEditor>
            {
                new Scp049Editor(),
                // new Scp0492Editor(), // Uncomment and implement as needed.
                new Scp079Editor(),
                // Add additional editors (e.g., Scp096Editor, Scp106Editor, etc.) here.
            };

            // Subscribe to the Verified event (invoked after a player has been verified).
            Player.Verified += OnPlayerVerified;

            Log.Info($"{Name} v{Version} by {Author} has been enabled!");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            // Unsubscribe from events to ensure a clean shutdown or dynamic update.
            Player.Verified -= OnPlayerVerified;
            Log.Info($"{Name} has been disabled!");
            base.OnDisabled();
        }

        /// <summary>
        /// Loops through each SCP editor to apply custom modifications based on the player's role.
        /// </summary>
        /// <param name="ev">The Verified event arguments.</param>
        private void OnPlayerVerified(VerifiedEventArgs ev)
        {
            foreach (var editor in scpEditors)
            {
                editor.TryEdit(ev, Config);
            }
        }
    }
}
