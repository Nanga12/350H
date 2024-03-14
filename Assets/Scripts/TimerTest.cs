using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTest : MonoBehaviour
{
    Timer timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.TimerSet(2);
        timer.Run();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer.Finish())
        {
            //Debug.Log(timer.getElapsedTime());
            timer.TimerSet(2);
            timer.Run();
        }
        
    }
}
