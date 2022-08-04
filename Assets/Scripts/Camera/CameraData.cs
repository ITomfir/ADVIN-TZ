using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class CameraData
{
    public ReactiveProperty<CameraType> type = new ReactiveProperty<CameraType>();

    public enum CameraType {
        FirstPerson,
        ThirdPerson
    }
}
