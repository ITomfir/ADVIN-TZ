using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[RequireComponent(typeof(Collider))]
public class TakeItemHendler : MonoBehaviour, ITakeItemHendler
{
    public event Action<IItem> OnTakeItem;

    private void Awake() {
        if (GetComponent<Collider>().isTrigger == false) throw new Exception($"{gameObject.name} Couldn't find trigger"); 
    }

    private void OnTriggerEnter(Collider other) {
        if (other.TryGetComponent<IItem>(out var item)) {
            OnTakeItem?.Invoke(item);
            item.OnTake();
        }
    }
}
