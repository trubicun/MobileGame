using System;
using UnityEngine;

public class Collector : MonoBehaviour
{
    int collectableAmount = 100;
    float collectDelay = 1f;
    float elapsedTime = 0;
    Pocket pocket;
    
    public void Init(Pocket pocket)
    {
        this.pocket = pocket;
    }

    void Update()
    {
        if (Time.time - elapsedTime > collectDelay)
        {
            elapsedTime = Time.time;
            pocket.AddMoney(collectableAmount);
        }
    }
}
