using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Base class item with virtua DisplayInfo method
public class Item : MonoBehaviour
{
    protected string itemName;         // Name of the item (accessible to derived classes)
    protected string description;      // Description of te item (accessible to derived classes)

    // Default constructor for Item, called hen an Item object is created
    public Item() 
    {
        itemName = "Generic Item";
        description = "A generic item";
        Debug.Log("1st Item Constructor Called");
    }

    // Constructor with parameters, allows setting name and description during instantiation
    public Item(string newItemName, string newDescription)
    {
        itemName = newItemName;
        description = newDescription;
        Debug.Log("2nd Item Constructor Called");
    }

    // Virtual method to be overridden in derived classes
    public virtual void DisplayInfo()
    {
        Debug.Log($"{itemName} : {description}");
    }

    // A simple method to greet
    public void SayHello()
    {
        Debug.Log("Hello, I am an item");
    }
}
