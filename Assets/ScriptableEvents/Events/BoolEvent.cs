using ScriptableEvents.Abstracts;
using UnityEngine;

namespace ScriptableEvents.Events
{
    [CreateAssetMenu(menuName = "Scriptables/Bool Event", order = 1)]
    public class BoolEvent : AbstractEvent<bool>
    { }
}