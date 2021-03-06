﻿using UnityEngine;
using System.Collections;

public class ColumnPool : MonoBehaviour {

	public float columnMin = -1f;
	public float columnMax = 3.5f;

	private GameObject[] columns;
	public int columnPoolSize = 5;

	public GameObject columnPrefab;
	private Vector2 objectPoolPosition = new Vector2 (-15f, -25f);

	private float timeSinceSpawned = 4;
	public float spawnRate = 4f;
	private float spawnXPosition = 10f;
	private int currentColumn = 4;

	// Use this for initialization
	void Start () 
	{
		columns = new GameObject[columnPoolSize];
		for (int i = 0; i < columnPoolSize; i++) 
		{
			columns [i] = (GameObject) Instantiate(columnPrefab, objectPoolPosition, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		timeSinceSpawned += Time.deltaTime;

		if (GameControl.instance.gameOver == false && timeSinceSpawned >= spawnRate) 
		{
			timeSinceSpawned = 0;
			float spawnYPosition = Random.Range (columnMin, columnMax);

			columns[currentColumn].transform.position = (new Vector2(spawnXPosition, spawnYPosition));

			currentColumn++;
			if (currentColumn >= columnPoolSize)
				currentColumn = 0;

		}
			
	}
}
