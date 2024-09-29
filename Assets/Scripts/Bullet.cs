using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Item
{
    public override bool IsPickable { get; set; } = true;

    [SerializeField] private float _speed;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    public override void Use(GameObject character)
    {
        if (IsPickable)
        {
            _rigidbody.velocity = transform.forward * _speed;
            transform.SetParent(null);
            IsPickable = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
