using Exiled.Events.EventArgs;
using Exiled.Events.EventArgs.Player;

namespace SCPUtils.Editors
{
    public interface IScpEditor
    {
        /// <summary>
        /// Checks if the player's role matches this SCP type and applies modifications.
        /// </summary>
        /// <param name="ev">The Verified event arguments.</param>
        /// <param name="config">The plugin configuration.</param>
        void TryEdit(VerifiedEventArgs ev, global::SCPUtils.Config config);
    }
}
