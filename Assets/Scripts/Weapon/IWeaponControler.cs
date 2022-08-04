using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeaponControler
{
    void SetData(WeaponData data);
    bool HasWeapon();
    void Shoot();
}
