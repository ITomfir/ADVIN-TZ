using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private InputService _input;
    [SerializeField] private CameraViewProvider _cameraPovider;
    [SerializeField] private PlayerMovement _movement;
    [SerializeField] private TakeItemHendler takeItemHendler;
    [SerializeField] private PlayerItemHendler itemHandler;
    [SerializeField] private WeaponService weaponService;

    private ICameraControler _cameraControler;
    private IInputService _inputService => _input;
    private IInputMovement _inputMovement => _movement;
    private ITakeItemHendler _takeItemHendler => takeItemHendler;
    private IItemHendler _itemHandler => itemHandler;
    private IWeaponService _weaponService => weaponService;

    private void Awake() {
        _cameraControler = new CameraControler();

        Init();
    }

    private void OnEnable() {
        _inputService.OnSwitchCam += _cameraControler.SetNextType;
        _inputService.OnShoot += _weaponService.Shoot;
        _takeItemHendler.OnTakeItem += _itemHandler.HandleItem;
    }

    private void OnDisable() {
        _inputService.OnSwitchCam -= _cameraControler.SetNextType;
        _inputService.OnShoot -= _weaponService.Shoot;
        _takeItemHendler.OnTakeItem -= _itemHandler.HandleItem;
    }

    private void Init() {
        _cameraControler.Init(_cameraPovider);
        _inputMovement.Init(_inputService);
    }
}
