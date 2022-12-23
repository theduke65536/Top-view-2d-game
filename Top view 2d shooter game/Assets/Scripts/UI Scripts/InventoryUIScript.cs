using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

// This script changes the hotbar of the player when they pick up a weapon.
public class InventoryUIScript : MonoBehaviour
{
    public Image Slot1;
    public Image Slot2;
    public Image Slot3;

    public IDictionary<int, Image> validSlotsDict;
    public int validSlot = 0;

    public Sprite shotgunSprite;
    public Sprite handgunSprite;
    public Sprite assaultrifleSprite;


    private void Start()
    {
        validSlot = 0;

        validSlotsDict = new Dictionary<int, Image>()
        {
            { 1, Slot1 },
            { 2, Slot2 },
            { 3, Slot3 }
        };
    }



    public void EquipShotgun()
    {
        Image slot = GetValidImage();
        slot.sprite = shotgunSprite;
        slot.color = new Color(255, 255, 255);
    }


    public void EquipAssaultrifle()
    {
        Image slot = GetValidImage();
        slot.sprite = assaultrifleSprite;
        slot.color = new Color(255, 255, 255);
    }


    public Image GetValidImage()
    {
        validSlot += 1;
        return validSlotsDict[validSlot];
    }


    public void EquipHandgun()
    {
        Image slot = GetValidImage();
        slot.sprite = handgunSprite;
        slot.color = new Color(255, 255, 255);
    }
    
}
