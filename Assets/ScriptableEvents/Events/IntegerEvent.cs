using ScriptableEvents.Abstracts;
using UnityEngine;

namespace ScriptableEvents.Events
{
    [CreateAssetMenu(menuName = "Scriptables/Integer Event", order = 2)]
    public class IntegerEvent : AbstractEvent<int>
    { }
}