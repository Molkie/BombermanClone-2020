using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{

    [SerializeField]
    GameObject tile;

    [SerializeField]
    int width;

    [SerializeField]
    int height;


    // Start is called before the first frame update
    void Start()
    {
        //float offsetX = width / 2f - 0.5f;
        //float offsetY = height / 2f - 0.5f;

        Vector3 Offset = new Vector2(
            width / 2f - 0.5f,
            height / 2f - 0.5f
        );


        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                PlaceTiles(Offset, x, y);
            }
        }
        
    }

    private void PlaceTiles(Vector3 Offset, int x, int y)
    {
        GameObject newTile = Instantiate(tile,
        new Vector3(x, y) - Offset,
        Quaternion.identity);

        newTile.name = "(" + x + "," + y + ")";

        newTile.transform.parent = this.transform;
    }

    private void NewMeth()
    {

    }
}
