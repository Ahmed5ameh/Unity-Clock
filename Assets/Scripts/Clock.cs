using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] Transform hours;
    [SerializeField] Transform minutes;
    [SerializeField] Transform seconds;

    const float degreesPerHour = 30;
    const float degreesPerMinute = 6;
    const float degreesPerSecond = 6;

    private void Update()
    {
        DateTime time = DateTime.Now;
        hours.localRotation = Quaternion.Euler(0, time.Hour * degreesPerHour, 0);
        minutes.localRotation = Quaternion.Euler(0, time.Minute * degreesPerMinute, 0);
        seconds.localRotation = Quaternion.Euler(0, time.Second * degreesPerSecond, 0);
        //Debug.Log(time);
    }
}
