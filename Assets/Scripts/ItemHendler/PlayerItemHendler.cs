using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItemHendler : MonoBehaviour, IItemHendler
{
    [SerializeField] private WeaponControler _weapon; 

    private IWeaponControler _weaponControler => _weapon;

    public void HandleItem(IItem item) {
        if (item is WeaponItem) Handle((WeaponItem)item);
    }

    private void Handle(WeaponItem item) {
        _weapon.SetData(item.data);
    }
}
