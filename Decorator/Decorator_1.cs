using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decorator_1 : CustomDebugerDecorator
{
    public Decorator_1(IDebugable debugable) : base(debugable)
    {
        
    }
    public override void Show(string s) 
    {
        Debug.Log(s.Length);
        base.Show(s);
    }
}
