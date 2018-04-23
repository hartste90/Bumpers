using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteTiledArea : MonoBehaviour {


	public SpriteRenderer tilePrefab;
	public Sprite[] sprites;
	public Vector2 size = new Vector2 (10, 10);

	public void Start()
	{
		Vector2 tileSize = tilePrefab.bounds.size;



		for (float x = 0; x < size.x; x += tileSize.x)
		{
			for (float y = 0; y < size.y; y += tileSize.y)
			{
				//create a tile for our background grid
				SpriteRenderer rend = Instantiate<SpriteRenderer> (tilePrefab);
				//assign a cool image to that tile
				rend.sprite = sprites [Random.Range (0, sprites.Length)];
				//make yourself a child of this gameobject (Background)
				rend.transform.parent = transform;
				//set your position based on math
				rend.transform.localPosition = new Vector3 (
					x - size.x / 2f + tileSize.x / 2f - 5, 
					y - size.y / 2f + tileSize.y / 2f - 5, 0f);
			}
		}

	}

}
