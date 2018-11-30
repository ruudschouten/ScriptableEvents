using System;
using Random = UnityEngine.Random;

[Serializable]
public class DamageStat
{
    public int Min;
    public int Max;

    public int GetDamageDone()
    {
        return Random.Range(Min, Max);
    }
}