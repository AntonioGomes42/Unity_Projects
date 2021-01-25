using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    public float Speed = 7f;
    public bool isRight;
    public bool isLeft;
    // Update is called once per frame
    void Update()
    {
        if(isRight){
            transform.Translate(0f, Input.GetAxis("Vertical") * Speed * Time.deltaTime, 0f);
        }else if(isLeft){
            transform.Translate(0f, Input.GetAxis("Vertical2") * Speed * Time.deltaTime, 0f);
        }
    }
}
