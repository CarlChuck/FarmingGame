using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InteractionControls : MonoBehaviour
{
    [SerializeField] InteractionController iController;


    void OnRightHand(InputValue value)
    {
        //Debug.Log("M1");
        if (iController.interactableMousedOver != null)
        {
            iController.interactableMousedOver.Interact1();
        }
    }
    void OnLeftHand(InputValue value)
    {
        //Debug.Log("M2");
        if (iController.interactableMousedOver != null)
        {
            iController.interactableMousedOver.Interact2();
        }
    }
    void OnInteract(InputValue value)
    {
        //Debug.Log("E");
        if (iController.interactableMousedOver != null)
        {
            iController.interactableMousedOver.Interact3();
        }
    }
    void OnInteract2(InputValue value)
    {
        //Debug.Log("M3");
        if (iController.interactableMousedOver != null)
        {
            iController.interactableMousedOver.Interact4();
        }
    }
    void OnCursorLock(InputValue value)
    {
        iController.SetCursorLockState();
    }
}
