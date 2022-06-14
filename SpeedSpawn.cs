using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedSpawn : MonoBehaviour
{
    public float speed = 10;
    void Update()
    {
        catusMove();
    }
    public virtual void catusMove()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed );
          
    }

}
