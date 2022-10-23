using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Workbench : Interactable
{
    private List<Recipe> listOfRecipes;

    public override void Interact1()
    {
        OpenWorkbench();
    }
    public override void Interact2()
    {
        //TODO
    }
    public override void Interact3()
    {
        //TODO
    }
    public override void Interact4()
    {
        //TODO
    }

    public void OpenWorkbench()
    {
        //TODO
    }

    public List<Recipe> GetRecipes()
    {
        return listOfRecipes;
    }
}
