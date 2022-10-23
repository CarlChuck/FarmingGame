using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Herb : Item
{
    private Seed seed;
    private int value;

    public Seed GetSeed()
    {
        return seed;
    }

    public void SetSeed(Seed aSeed)
    {
        seed = aSeed;
    }
}
