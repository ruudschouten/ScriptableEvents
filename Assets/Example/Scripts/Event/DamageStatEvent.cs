using ScriptableEvents.Abstracts;
using UnityEngine;

namespace ScriptableEvents.Events
{
    [CreateAssetMenu(menuName = "Scriptables/DamageStat Event", order = 6)]
    public class DamageStatEvent : AbstractEvent<DamageStat>
    { }
}