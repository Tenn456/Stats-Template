using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Stats stats;

    private void Start()
    {
        PrintStats();
        Skills();
    }
    protected virtual void PrintStats()
    {
        Debug.Log("We will print the stats of each enemy");
    }

    protected virtual void Skills()
    {
        //Debug.Log("We will print the stats of each enemy");
    }
}
