using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
		public GameObject enemy1;
		public GameObject enemy2;
		public GameObject enemy3;
		public GameObject enemy4;

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
			//	Instantiate (enemy, GenerateStart (), Quaternion.identity);


				switch(Random.Range(1,5)){
					case 1: 
						Instantiate (enemy1, GenerateStart (true), Quaternion.identity);
						enemy1.GetComponent<Movement>().ground = true;
						break;
					case 2: 
						Instantiate (enemy2, GenerateStart (true), Quaternion.identity);
						enemy2.GetComponent<Movement>().ground = true;
						break;
					case 3: 
						Instantiate (enemy3, GenerateStart (false), Quaternion.identity);
						enemy3.GetComponent<Movement>().ground = false;
						break;
					case 4: 
						Instantiate (enemy4, GenerateStart (false), Quaternion.identity);
						enemy4.GetComponent<Movement>().ground = false;
						break;
				}

				//enemy.GetComponent<Movement> ().setLives ((int)(Random.value * (maxLives-1))+1);
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

Vector3 GenerateStart(bool ground){

		int y = 0;
		int x = 0;
		int z = 0;

		if (ground) {
			y = 0;
			x = (int)(Random.Range (300, xRange)) * randNum ();
			z = (int)(Random.Range (300, zRange)) * randNum ();
		} else {
			y = (int)(Random.Range (80, yRange));
			x = (int)(Random.Range (300, xRange)) * randNum ();
			z = (int)(Random.Range (300, zRange)) * randNum ();
		}

	
			

			//	int x = (int)(Random.value*20);
			//	int z = (int)(Random.value *20);
			//	int y = (int)(Random.value * yRange);
	

		return new Vector3(x,y,z);
	}


int randNum(){
	float rand = (Random.value);
	if (rand > .5) {
		return 1;
	} else {
		return -1;
	}
}

}
