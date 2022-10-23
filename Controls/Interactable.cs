using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public int radius;
    public bool mouseOver;
    InteractionController iController;

    private void Start()
    {
        iController = Player.instance.GetComponent<InteractionController>();
    }

    public virtual void Interact1()
    {
        //For Overide
    }
    public virtual void Interact2()
    {
        //For Overide
    }
    public virtual void Interact3()
    {
        //For Overide
    }
    public virtual void Interact4()
    {
        //For Overide
    }
    public virtual void OnEnterExtras()
    {
        //For Overide        
        //Add UI overlay for interaction state
        UIMaster.instance.SetInteractionLayerActive();
    }
    public virtual void OnExitExtras()
    {
        //For Overide        
        //Add UI overlay for interaction state
        UIMaster.instance.SetInteractionLayerInactive();
    }

    public void OnMouseEnter()
    {
        if (CheckDistance())
        {
            mouseOver = true;
            iController.SetCurrentInteractable(this);
            Selected();
            OnEnterExtras();
        }
    }

    public void OnMouseExit()
    {
        mouseOver = false;
        iController.SetCurrentInteractableToNull(this);
        UnSelected();
        OnExitExtras();
    }

    public void Selected()
    {
        //TODO - Visuals - Outline
        //Debug.Log("Selected");
    }

    public void UnSelected()
    {
        //TODO - Stop Visuals - Outline
        //Debug.Log("DeSelected");
    }

    public bool CheckDistance()
    {
        float distance = Vector3.Distance(this.transform.position, Player.instance.transform.position);
        if (distance < radius)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
