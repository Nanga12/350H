using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{

    private float elapsedTime = 0;
    private float endTime = 0;
    private bool running = false;

    
    // Start is called before the first frame update
    void Start()
    {


    }

    public bool Finish()
    {
        return !running;
       
    }

 

    public void TimerSet(int etime)
    {
        endTime = etime;
        elapsedTime = 0;



    }
    public void Run()
    {
        running = true;

    }
    public float getElapsedTime()
    {
        return elapsedTime;
    }

    public void Update()
    {
        if (running)
        {
            elapsedTime += Time.deltaTime;
            if (elapsedTime >= endTime)
            {
                Debug.Log("Timer finished!");
                // Add code here to destroy or spawn an object
                running = false; // Optional: Automatically end the timer when it finishes
            }
        }
    }

}

