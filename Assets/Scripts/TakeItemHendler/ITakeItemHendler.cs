using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public interface ITakeItemHendler
{
    event Action<IItem> OnTakeItem;
}
