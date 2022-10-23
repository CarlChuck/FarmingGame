using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe : ScriptableObject
{
    private string recipeName;
    private List<Item> listOfInputs;
    private Item outputItem;
    private float timeToCraft;
}
