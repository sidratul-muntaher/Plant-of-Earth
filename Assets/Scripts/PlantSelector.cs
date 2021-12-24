using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantSelector : MonoBehaviour
{
    public Plant plant;
    int time = 0;

    private void OnMouseDown()
    {
        foreach (var item in FindObjectsOfType<PlantSelector>())
        {
            item.GetComponent<SpriteRenderer>().color = Color.HSVToRGB(34, 34, 34);
        }

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.white;
        if (plant.GetComponent<PaperTree>())
        {
            time = 8;
        }
        else if (plant.GetComponent<TrantEgg>())
        {
            time = 6;
        }
        else if (plant.GetComponent<TrantFruit>())
        {
            time = 10;
        }
        else if (plant.GetComponent<TransGas>())
        {
            time = 12;
        }

        FindObjectOfType<GameArea>().SetSelectedPlant(plant, time);
    }
}
