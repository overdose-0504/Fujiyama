﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//見つけられなかったので作りましたシリーズ
public class Std : MonoBehaviour
{
    public static void Swap<T>(ref T a,ref T b)
    {
        T tmp;
        tmp = a;
        a = b;
        b = tmp;
    }

    public static bool CheckKeyList(List<KeyCode> keyCodes)
    {
        foreach (var a in keyCodes)
        {
            if (Input.GetKey(a))
            {
                return true;
            }
        }
        return false;
    }
}
