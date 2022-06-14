using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackGround : MonoBehaviour
{
    private Vector2 StartPos;
    private void Start()
    {
        StartPos = transform.position;
    }

    private void Update()
    {
        BackGroundRepeat();

    }
    private void BackGroundRepeat()
    { 
        if(transform.position.x < - 7)
        {
            transform.position = StartPos;
        }
    }
}
