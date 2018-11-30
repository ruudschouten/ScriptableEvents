using ScriptableEvents.Abstracts;
using UnityEngine;

namespace ScriptableEvents.Events
{
    [CreateAssetMenu(menuName = "Scriptables/String Event", order = 4)]
    public class StringEvent : AbstractEvent<string>
    { }
}