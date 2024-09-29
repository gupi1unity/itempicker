using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Item : MonoBehaviour
{
    public abstract bool IsPickable { get; set; }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<ItemPicker>(out ItemPicker itemPicker))
        {
            itemPicker.Pick(this);
        }
    }

    public abstract void Use(GameObject character);
}
