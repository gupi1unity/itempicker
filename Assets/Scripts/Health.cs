using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int HealthPoints { get; set; }

    public void Initialize(int health)
    {
        HealthPoints = health;
    }

    public void AddHealth(int value)
    {
        if (value < 0)
            HealthPoints += value;
    }

    public void TakeDamage(int value)
    {
        if (HealthPoints < 0)
            HealthPoints = 0;
        if (value >= 0)
            HealthPoints -= value;
    }
}
