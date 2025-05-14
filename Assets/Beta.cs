using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Beta : Enemy
{
    protected override void PrintStats()
    {
        base.PrintStats();
        print(stats.digimonName);
    }

    protected override void Skills()
    {
        Debug.Log(stats.skillName);
    }
}
