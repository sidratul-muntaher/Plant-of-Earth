using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameArea : MonoBehaviour
{
    Plant plant;
    int time;
    public static int[,] activePlaces;
    // Start is called before the first frame update
    void Start()
    {
        activePlaces = new int[10, 10];
        for (int i = 0; i <9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                activePlaces[i, j] = 0;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSelectedPlant(Plant plant, int time)
    {
        this.plant = plant;
        this.time = time;
    }

    private void OnMouseDown()
    {
        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 snapPosition = new Vector2(Mathf.RoundToInt(worldPosition.x), Mathf.RoundToInt(worldPosition.y));
        
        if ( Timer.timerS <= 0 && activePlaces[(int) snapPosition.x, (int)snapPosition.y] == 0)
        {
            Timer.timerS = Timer.timerS + time;
            activePlaces[(int)snapPosition.x, (int)snapPosition.y] = 1;
            Instantiate(plant, snapPosition, Quaternion.identity);
        }

    }
}
