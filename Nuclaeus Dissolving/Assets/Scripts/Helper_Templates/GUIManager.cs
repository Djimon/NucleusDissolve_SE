using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : Singleton<GUIManager>
{
    public int Helth = 1;

    //create observer
    ObservedValue<int> health = new ObservedValue<int>(100);

    

    Transform tf;
    // Start is called before the first frame update
    void Start()
    {
        //class inherited from Singelton<T>
        Instance.Helth = 1;
        var i = instance.Helth;

        //Transform extension
        tf.SetX(1); 

        //register on the Observer
        health.OnValueChange += () => { if (health.Value <= 0) Die(); };
    }



    private void Die()
    {
       //let something die, when health drops to 0
    }
}
