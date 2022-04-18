using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    Tile tile;
    public PlayerMovement moveScript;

    void Start() {
        moveScript = this.GetComponent<PlayerMovement>();
        tile = CreateGrid.getTile((new Vector2(transform.position.x, transform.position.z)), tile);
    }

    void OnMouseDown() {
        UnitSelection.setSelected(((new Vector2(transform.position.x, transform.position.z)), this));
    }

    void OnMouseEnter() {
        tile = CreateGrid.getTile((new Vector2(transform.position.x, transform.position.z)), tile);
        tile.enableHighlight();
    }

    void OnMouseExit() {
        tile = CreateGrid.getTile((new Vector2(transform.position.x, transform.position.z)), tile);
        tile.disableHighlight();
    }
}
