using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIManager : Singleton<GUIManager>
{
    //create observer
    ObservedValue<int> health = new ObservedValue<int>(99);   

    Transform tf;

    // Start is called before the first frame update
    void Start()
    {
        //class inherited from Singelton<T>
        Instance.health.Value += 1;
        var i = Instance.health;

        //Transform extension
        tf.SetX(1); 

        //register on the Observer
        health.OnValueChange += () => { if (health.Value <= 0) Die(); };
    }

    private void Die()
    {
       //let something die, when health drops to 0
    }

    protected override void OnAwake()
    {
        throw new NotImplementedException();
    }
}
