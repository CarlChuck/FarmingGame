using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Item selectedItem;
    private List<Item> inventory;

    public void AddItem(Item item)
    {
        inventory.Add(item);
    }

    public void RemoveItem(Item item)
    {
        inventory.Remove(item);
    }

    public List<Item> ShowInventoryByType(ItemType type)
    {
        List<Item> tempList = new List<Item>();
        if (type == ItemType.Seed)
        {
            foreach (Seed seed in inventory)
            {
                tempList.Add(seed);
            }
        }
        else if (type == ItemType.Herb)
        {
            foreach (Herb herb in inventory)
            {
                tempList.Add(herb);
            }

        }
        else if (type == ItemType.Remedy)
        {
            foreach (Remedy remedy in inventory)
            {
                tempList.Add(remedy);
            }
        }
        return tempList;
    }
}
public enum ItemType {Seed, Herb, Remedy}