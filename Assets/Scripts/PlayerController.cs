using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController _characterController;
    private Mover _mover;
    private ItemPicker _itemPicker;
    private Health _health;
    private DisplayHealth _displayer;

    [SerializeField] private float _speed;
    [SerializeField] private int _healthPoints;
    [SerializeField] private Transform _itemPosition;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
        _mover = GetComponent<Mover>();
        _itemPicker = GetComponent<ItemPicker>();
        _health = GetComponent<Health>();
        _displayer = GetComponent<DisplayHealth>();

        _displayer.Initialize(_health);
        _health.Initialize(_healthPoints);
        _mover.Initialize(_speed);
        _itemPicker.Initialize(_itemPosition);
    }

    public void Update()
    {
        _mover.Move(_characterController);
    }
}
