namespace LegacyConquer.Api
{
   /// <summary>
   /// This is your base class for creating a npc script.
   /// Example: public class MyNpcScript:INpcScript { }
   /// </summary>
    public abstract class INpcScript
    {
        /// <summary>
        /// Set internally via the server.
        /// Handles the npc dialog
        /// </summary>
        public INpcDialog Dialog { get; set; }
        /// <summary>
        /// Set internally via the server.
        /// It is the player interacting with the npc
        /// </summary>
        public IGameClient Client { get; set; }
        /// <summary>
        /// Set internally via the server.
        /// The current npc we are interacting with.
        /// </summary>
        public INpcApi Npc { get; set; }
        /// <summary>
        /// The EntryPoint for npc scripts
        /// </summary>
        public abstract void Start();
    } 
}