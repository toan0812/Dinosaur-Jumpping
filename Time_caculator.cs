using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class Time_caculator : MonoBehaviour
{
    public Text Timecounter;
    private TimeSpan TimePlaying;
    private bool TimeGoing;
    private float elapsedTime;

    private void Start()
    {
        Timecounter.text = "00:00.00";
        TimeGoing = true;
        elapsedTime = 0f;
    }
    private void Update()
    {
      
            BeginTimer();
        
    }
    public void BeginTimer()
    {
        StartCoroutine(UpdateTimer());
    }   
 
    private IEnumerator UpdateTimer()
    {
        while(TimeGoing)
        {
            elapsedTime += Time.deltaTime;
            TimePlaying = TimeSpan.FromSeconds(elapsedTime);
            string TimePlayingstr = "Time: " + TimePlaying.ToString("hh':'mm':'ss'.'ff");
            Timecounter.text = TimePlayingstr;
            yield return null;
        }    
    }    
}
