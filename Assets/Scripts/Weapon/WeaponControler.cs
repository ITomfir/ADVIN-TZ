using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponControler : MonoBehaviour, IWeaponControler
{
    [SerializeField] private WeaponView weaponView;

    private WeaponData _data;

    public void SetData(WeaponData data) {
        _data = data;
    }

    public bool HasWeapon() {
        return _data;
    }

    public void Shoot() {
        weaponView.Source.PlayOneShot(_data.ShootClip);
    }
}
