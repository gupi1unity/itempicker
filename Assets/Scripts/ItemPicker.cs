using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemPicker : MonoBehaviour
{
    private bool _isItemPicked = false;

    private Transform _itemPosition;

    private Item _item;

    [SerializeField] private KeyCode _useKey = KeyCode.Space;

    public void Initialize(Transform itemPosition)
    {
        _itemPosition = itemPosition;
    }

    private void Update()
    {
        UseItem();
    }

    public void Pick(Item item)
    {
        if (_isItemPicked == true || item.IsPickable == false)
            return;

        _item = item;
        _item.transform.SetParent(transform);
        _item.transform.localPosition = _itemPosition.transform.localPosition;
        _isItemPicked = true;
    }

    private void UseItem()
    {
        if (Input.GetKeyDown(_useKey) && _item != null)
        {
            _item.Use(gameObject);
            _item.transform.SetParent(null);
            _isItemPicked = false;
            _item = null;
        }
    }
}
