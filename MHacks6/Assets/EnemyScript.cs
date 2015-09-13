using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
		public GameObject enemy;
		public float spawnRate = 3.0F;
		//public int waveNum = 0;
		public int xRange = 20;
		public int yRange = 20;
		public int zRange = 20;
		
		
		
		private int numEnemy = 0;
		private float nextSpawn = 0.0F;
		private int level = 1;
		private int maxLives = 0;
		public int waveNum = 0;

	void Start() {

	}

	void Update(){
		
		if (numEnemy < waveNum) {
			if (Time.time > nextSpawn) {
				numEnemy++;
				nextSpawn = Time.time + (Random.value * 3 + spawnRate);
				Instantiate (enemy, GenerateStart (), Quaternion.identity);
				enemy.GetComponent<Movement> ().setLives ((int)(Random.value * (maxLives-1))+1);
				//enemy.GetComponent<Movement> ().setSpeed((Random.value * maxLives)+3);
				//Debug.Log (numEnemy);
			} 
		} else {
			//if(GameObject.FindGameObjectWithTag("Enemy") == null){
				numEnemy = 0;
				waveNum = (level-1)*5+5;
				//Debug.Log(waveNum);
				level++;
				if(maxLives < 4){
					maxLives++;
				}
		//	}
		}
	}

Vector3 GenerateStart(){
		int x = (int)(Random.Range(100,xRange))*(int)(Random.value*2)-1;
		int z = (int)(Random.Range(100,zRange))*(int)(Random.value*2)-1;
		int y = (int)(Random.Range(80,yRange));

	//	int x = (int)(Random.value*20);
	//	int z = (int)(Random.value *20);
	//	int y = (int)(Random.value * yRange);

		return new Vector3(x,y,z);
	}
}
