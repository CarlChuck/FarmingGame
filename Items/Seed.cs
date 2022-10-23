using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seed : Item
{
    public SeedType sType;
    public int growthSpeed;
    public int yield;
    public GameObject plantPrefab;
}
public enum SeedType {Dsih, Mithli, Yikran, Resh, Hyreth}