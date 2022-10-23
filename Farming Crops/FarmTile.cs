using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FarmTile : Interactable
{
    [SerializeField] private FarmTyleType fType;
    [SerializeField] private FarmState fState;
    [SerializeField] private Seed seed;
    [SerializeField] private Upgrade upgrade;
    [SerializeField] private Image plantCrop;
    [SerializeField] private Image pickCrop;
    [SerializeField] private Image uprootCrop;
    [SerializeField] private Image upgradeTile;

    public override void Interact1()
    {
        if (fState == FarmState.Empty)
        {
            //Plant Crop
        }
        else if (fState == FarmState.Growing)
        {
            //None
        }
        else if (fState == FarmState.Grown)
        {
            //Pick Crop
        }
    }
    public override void Interact2()
    {
        if (fState == FarmState.Empty)
        {
            //None
        }
        else if (fState == FarmState.Growing)
        {
            //Uproot Crop
        }
        else if (fState == FarmState.Grown)
        {
            //Pick Crop + Uproot Crop
        }
    }
    public override void Interact3()
    {
        //Upgrade Tile
    }
    public override void Interact4()
    {
        //None
    }

    public override void OnEnterExtras()
    {
        base.OnEnterExtras();
        if (fState == FarmState.Empty)
        {
            UIMaster.instance.SetInteract1Active(plantCrop.sprite);
            UIMaster.instance.SetInteract3Active(upgradeTile.sprite);
        }
        else if (fState == FarmState.Growing)
        {
            UIMaster.instance.SetInteract2Active(uprootCrop.sprite);
            UIMaster.instance.SetInteract3Active(upgradeTile.sprite);
        }
        else if (fState == FarmState.Grown)
        {
            UIMaster.instance.SetInteract1Active(pickCrop.sprite);
            UIMaster.instance.SetInteract2Active(uprootCrop.sprite);
            UIMaster.instance.SetInteract3Active(upgradeTile.sprite);
        }
    }
    public override void OnExitExtras()
    {
        base.OnExitExtras();
        //Remove UI for farmtile
    }

    private void PlantCrop(Seed aSeed)
    {

    }

    private void HarvestCrop()
    {
        
    }
}
public enum FarmState {Empty, Growing, Grown }
public enum FarmTyleType {Herb, Mushroom, Water }
public enum Upgrade {Empty, BoundSpirit }
