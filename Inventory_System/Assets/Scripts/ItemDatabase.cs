﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour {
    public List<Item> items = new List<Item>();


    void Awake()
    {
        BuildDatabase();
    }

    // Get item by id number.
    public Item GetItem(int id)
    {
        return items.Find(item=> item.id == id);
    }

    // Get item by name
    public Item GetItem(string itemName)
    {
        return items.Find(item => item.title == itemName);
    }


    /// <summary>
    /// This is where you add items.
    /// Each item requires:
    /// An int which scales by 1 each time.
    /// A name (that is the same as the sprite name.
    /// A description.
    /// And finally declare all the "stats" of the item in the dict.
    /// </summary>
    void BuildDatabase()
    {
        items = new List<Item>()
        {
            new Item(0, "Gold Ore", "Ore from a gold node.",
            new Dictionary<string, int>
            {
                { "Value", 100 }, { "Weight", 2 }
            }),
            new Item(1, "Azure Ore", "Ore from an Azure node.",
            new Dictionary<string, int>
            {
                { "Value", 40 }, { "Weight", 4 }
            }),
            new Item(2, "Pickaxe", "A pickaxe used for mining nodes.",
            new Dictionary<string, int>
            {
                { "Value", 500 }, { "Weight", 16}, { "Mining", 10}, { "Attack", 4}, { "Defence", 1 }
            })
        };
    }
}
