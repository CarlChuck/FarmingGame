using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionController : MonoBehaviour
{

    //Selected object
    public Interactable interactableMousedOver;

    public void Start()
    {
        SetCursorLockState();
    }

    public void SetCursorLockState()
    {
        if (Cursor.lockState == CursorLockMode.Locked)
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public Interactable GetCurrentInteractable()
    {
        return interactableMousedOver;
    }

    public void SetCurrentInteractable(Interactable interactable)
    {
        interactableMousedOver = interactable;
    }

    public void SetCurrentInteractableToNull(Interactable interactable)
    {
        if (interactable = interactableMousedOver)
        {
            interactableMousedOver = null;
        }
    }
}
