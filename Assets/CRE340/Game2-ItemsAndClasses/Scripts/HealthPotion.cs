using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Item        //Derived class HealthPotion that inherits from Item
{
    public int healthRestoreAmount;     // Amount of health this potion restores
    public int minRestoreAmount = 30;   // Minumum restore amount for random range
    public int maxRestoreamount = 70;   // Maximum restore amount for random range

    // Defauly Constructor, sets the name and description of the health potion

    public HealthPotion()
    {
        itemName = "Health Potion";
        description = "A potion that restores health.";
    }

    // Called when the object is instantiated
    private void Start()
    {
        // Assign a random value for healthRestoreAmount within the specified range
        healthRestoreAmount = Random.Range(minRestoreAmount, maxRestoreamount);
        Debug.Log($"HealthPotion: Random restore amount set to {healthRestoreAmount}.");
    }

    // Override metof ti display specific health potion info
    


}
