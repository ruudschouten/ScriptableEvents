using ScriptableEvents.Events;
using UnityEngine;

namespace Example
{
    public class DamageHealer : MonoBehaviour
    {
        public int Healed;
        public IntegerEvent DamageHealedEvent;

        public void Heal()
        {
            DamageHealedEvent.Sent = Healed;
            DamageHealedEvent.Raise();
        }
    }
}