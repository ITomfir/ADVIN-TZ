using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UniRx;

using CameraType = CameraData.CameraType;

public class CameraView : MonoBehaviour, ICameraView
{
    [SerializeField] private CinemachineVirtualCamera _firstPerson;
    [SerializeField] private CinemachineVirtualCamera _thirdPerson;

    private CameraData _data;

    public void Bind(CameraData data) {
        _data = data;

        _data.type.Subscribe(_ => SwitchType(_));
    }

    private void SwitchType(CameraType type) {
        OffAllCameras();

        switch (type) {
            case CameraType.FirstPerson: _firstPerson.gameObject.SetActive(true); break;
            case CameraType.ThirdPerson: _thirdPerson.gameObject.SetActive(true); break;
        }
    }

    private void OffAllCameras() {
        _firstPerson.gameObject.SetActive(false);
        _thirdPerson.gameObject.SetActive(false);
    }
}
