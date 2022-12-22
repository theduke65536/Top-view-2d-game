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

    private IDictionary<int, Image> validSlotsDict;
    private int validSlot;

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
        validSlot += 1;

        Image slot = validSlotsDict[validSlot];
        slot.sprite = shotgunSprite;
        slot.color = new Color(255, 255, 255);
    }


    public void EquipAssaultrifle()
    {
        validSlot += 1;

        Image slot = validSlotsDict[validSlot];
        slot.sprite = assaultrifleSprite;
        slot.color = new Color(255, 255, 255);
    }


    public void EquipHandgun()
    {
        validSlot += 1;

        Image slot = validSlotsDict[validSlot];
        slot.sprite = handgunSprite;
        slot.color = new Color(255, 255, 255);
    }
}
