using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpeedBottle : Item
{
    public override bool IsPickable { get; set; } = true;

    [SerializeField] private float _multiplier;
    [SerializeField] private ParticleSystem _particleSystem;

    public override void Use(GameObject character)
    {
        _particleSystem.Play();
        character.GetComponent<Mover>().Speed *= _multiplier;
        gameObject.SetActive(false);
    }
}
