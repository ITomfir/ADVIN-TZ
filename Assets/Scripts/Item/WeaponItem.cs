using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponItem : MonoBehaviour, IItem
{
    public WeaponData data;

    public void OnTake() {
        Destroy(gameObject);
    }
}
