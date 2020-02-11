using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nuclaeus : MonoBehaviour
{

    private float maxSpeed = 150;
    [SerializeField]
    private float speed = 5;
    public float Speed
    {
        get { return speed; }
        set
        {
            if (value > maxSpeed)
                value = maxSpeed;
            speed = value;
        }
    }


    [SerializeField]
    private float rotationSpeed = 300f;
    [SerializeField]
    private float connectionRadius = 1.2f;
    [SerializeField]
    private float radiusSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
