using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMaster : MonoBehaviour
{
    public static UIMaster instance;
    private void Awake()
    {
        instance = this;
    }

    [SerializeField] private GameObject interactionLayer;
    [SerializeField] private GameObject interact1layer;
    [SerializeField] private GameObject interact2layer;
    [SerializeField] private GameObject interact3layer;
    [SerializeField] private GameObject interact4layer;
    [SerializeField] private GameObject inventoryLayer;
    [SerializeField] private Image interact1Image;
    [SerializeField] private Image interact2Image;
    [SerializeField] private Image interact3Image;
    [SerializeField] private Image interact4Image;

    private void Start()
    {
        SetInteract1Inactive();
        SetInteract2Inactive();
        SetInteract3Inactive();
        SetInteract4Inactive();
        SetInteractionLayerInactive();
    }

    public void SetInteractionLayerActive()
    {
        interactionLayer.SetActive(true);
    }
    public void SetInteractionLayerInactive()
    {
        interactionLayer.SetActive(false);
    }
    public void SetInteract1Active(Sprite sprite)
    {
        interact1layer.SetActive(true);
        interact1Image.sprite = sprite;
    }
    public void SetInteract1Inactive()
    {
        interact1layer.SetActive(false);
    }
    public void SetInteract2Active(Sprite sprite)
    {
        interact2layer.SetActive(true);
        interact2Image.sprite = sprite;
    }
    public void SetInteract2Inactive()
    {
        interact2layer.SetActive(false);
    }
    public void SetInteract3Active(Sprite sprite)
    {
        interact3layer.SetActive(true);
        interact3Image.sprite = sprite;
    }
    public void SetInteract3Inactive()
    {
        interact3layer.SetActive(false);
    }
    public void SetInteract4Active(Sprite sprite)
    {
        interact3layer.SetActive(true);
        interact4Image.sprite = sprite;
    }
    public void SetInteract4Inactive()
    {
        interact4layer.SetActive(false);
    }
    public void SetInventoryActive()
    {
        inventoryLayer.SetActive(true);
    }
    public void SetInventoryInactive()
    {
        inventoryLayer.SetActive(false);
    }

}
