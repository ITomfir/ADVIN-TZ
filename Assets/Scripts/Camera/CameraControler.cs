using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : ICameraControler
{
    private ICameraView _view;
    private CameraData _data;

    private ICameraViewProvider _provider;

    public void Init(ICameraViewProvider provider) {
        _provider = provider;
        _view = provider.Get();
        _data = new CameraData();

        _view.Bind(_data);
    }

    public void Init(ICameraViewProvider provider, CameraData data) {
        _provider = provider;
        _view = provider.Get();
        _data = data;

        _view.Bind(_data);
    }

    public void SetType(CameraData.CameraType type) {
        _data.type.Value = type;
    }

    public void SetNextType() {
        switch(_data.type.Value) {
            case CameraData.CameraType.FirstPerson: SetType(CameraData.CameraType.ThirdPerson); break;
            case CameraData.CameraType.ThirdPerson: SetType(CameraData.CameraType.FirstPerson); break;
        }
    }
}
