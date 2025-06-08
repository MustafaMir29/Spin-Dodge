using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private bool goRight;

    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        if(goRight){
            transform.Rotate(0f, 0f, -speed * Time.deltaTime);
        } else{
            transform.Rotate(0f, 0f, speed * Time.deltaTime);
        }
    }

    public void Click(){
        goRight = !goRight;
    }
}
