using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float Speed = 10f;
    // Update is called once per frame
    void Update()
    {
        Moveleft();
    }
    public virtual void Moveleft()
    {

         transform.Translate(Vector3.left * Time.deltaTime * Speed); 
    }    
}
