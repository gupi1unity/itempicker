using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBottle : Item
{
    public override bool IsPickable { get; set; } = true; 

    [SerializeField] private int _healthPoints;
    [SerializeField] private ParticleSystem _particleSystem;

    public override void Use(GameObject character)
    {
        _particleSystem.Play();
        character.GetComponent<Health>().HealthPoints += _healthPoints;
        gameObject.SetActive(false);
    }
}
