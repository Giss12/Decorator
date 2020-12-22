using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomDebuger : IDebugable
{
    public void Show(string s)
    {
        Debug.Log(s);
    }
}
