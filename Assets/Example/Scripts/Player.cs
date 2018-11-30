using ScriptableEvents.Events;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Health;
    public int MaxHealth;
    public IntegerEvent HealthChangedEvent;
    public IntegerEvent HealthReducedEvent;
    public IntegerEvent HealthRestoredEvent;
    public GameEvent PlayerDiedEvent;

    public void GetHit(DamageStat damageStat)
    {
        ChangeHealth(damageStat.GetDamageDone(), false);
    }

    public void GetHealed(int amount)
    {
        ChangeHealth(amount, true);
    }

    private void ChangeHealth(int amount, bool add)
    {
        if (add)
        {
            Health += amount;
            HealthRestoredEvent.Sent = amount;
            HealthRestoredEvent.Raise();
        }
        else
        {
            Health -= amount;
            HealthReducedEvent.Sent = amount;
            HealthReducedEvent.Raise();
        }

        if (Health < 0)
        {
            PlayerDiedEvent.Raise();
            Health = 0;
        }

        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }

        HealthChangedEvent.Sent = Health;
        HealthChangedEvent.Raise();
    }
}