using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starting : MonoBehaviour
{

    void Start()
    {
        CustomDebuger cd = new CustomDebuger();
        Decorator_1 dc1 = new Decorator_1(cd);
        Decorator_2 dc2 = new Decorator_2(dc1);
        dc2.Show("Decorator_1");
    }
}
