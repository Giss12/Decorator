using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Decorator_2 : CustomDebugerDecorator
{
    public Decorator_2(IDebugable debugable) : base(debugable)
    {

    }

    public override void Show(string s)
    {
        using (StreamWriter sw = new StreamWriter(Path.Combine(Application.dataPath, "Test.txt")))
        {
            if(!File.Exists(Path.Combine(Application.dataPath, "Test.txt")))
            {
                File.Create(Path.Combine(Application.dataPath, "Test.txt"));
            }
            sw.WriteLine(s);
        }
            base.Show(s);
    }
}
