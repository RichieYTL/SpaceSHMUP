using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	static public Main S;

	public GameObject[] prefabEnemies;
	public float enemySpawnPerSecond = .5f;
	public float enemySpawnPadding = 1.5f;

	public float enemySpawnRate;

	void Awake(){
		S = this;
		Utils.SetCameraBounds (this.camera);
		enemySpawnRate = 1f / enemySpawnPerSecond;
		Invoke ("SpawnEnemy", enemySpawnRate);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
