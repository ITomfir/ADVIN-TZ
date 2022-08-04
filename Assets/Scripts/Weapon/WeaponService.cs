using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponService : MonoBehaviour, IWeaponService
{
    [SerializeField] private WeaponControler _weaponControler;
    
    public bool HasWeapon() {
        return _weaponControler.HasWeapon();
    }
    
    public void Shoot() {
        if (HasWeapon())
            _weaponControler.Shoot();
    }
}
