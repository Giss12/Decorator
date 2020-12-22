using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomDebugerDecorator : IDebugable
{
    public CustomDebugerDecorator(IDebugable debugable) { ss = debugable; }
    protected IDebugable ss;
    public virtual void Show(string s)
    {
        ss.Show(s);
    }
}
