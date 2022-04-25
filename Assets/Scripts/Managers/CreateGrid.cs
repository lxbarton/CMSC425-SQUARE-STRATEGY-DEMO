using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGrid : MonoBehaviour
{
    public int width, length;
    public Tile tilePrefab;

    void Start()
    {
        Generate();
    }

    void Generate() {
        for (int x = 0; x < width; x++) {
            for (int z = 0; z < length; z++) {
                Vector3 newTileLoc = new Vector3(x, 0, z);
                var newTile = Instantiate(tilePrefab, newTileLoc, Quaternion.identity);
                newTile.name = $"Tile {x} {z}";
                newTile.transform.parent = this.gameObject.transform;
            }
        }
    }

    // pos is the 2d position of the tile on the grid,
    // last is the default tile to return if Unit is not on the tile, usually the last one it was on.
    public static Tile GetTile(Vector2 pos, Tile last) {
        GameObject finding = GameObject.Find($"Tile {pos.x} {pos.y}");
        return finding == null ? last : finding.GetComponent<Tile>();
    }
}