using UnityEngine;

namespace ScriptableEvents
{
    /// <summary>
    /// Can be used as a collection for all events.
    /// Solely used in this project to create a custom editor for Events.
    /// </summary>
    public class GenericEvent : ScriptableObject
    {
        public virtual void Raise() { }
    }
}