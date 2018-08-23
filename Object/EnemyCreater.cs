using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCreater : MonoBehaviour {

    // インスペクタからこのスクリプトにballPrefabをアタッチすることで、変数にballPrefabが格納される
    public GameObject EnemyPrefab;
		public float timeOut = 3.0f;
    private float timeElapsed = 0.0f;

		/*
    void Start() {
        // 10個ランダムな場所にballを生成する
        for(int i = 0; i < 10; i++){
            // Instantiateの引数にPrefabを渡すことでインスタンスを生成する
            GameObject enemy = Instantiate(EnemyPrefab) as GameObject;
            // ランダムな場所に配置する
            enemy.transform.position = new Vector3(Random.Range(-7,7), 0.5f, Random.Range(-4,4));
        }
    }
		*/

		void Update() {
			timeElapsed += Time.deltaTime;

			if(timeElapsed >= timeOut) {
				GameObject enemy = Instantiate(EnemyPrefab) as GameObject;
				//enemy.transform.position = new Vector3(Random.Range(-7,7), 0.5f, Random.Range(-15,-10));
				enemy.transform.position = new Vector3(80.0f*(Random.Range(0.0f,1.0f)-0.5f), 0.5f, 80.0f*(Random.Range(0.0f,1.0f)-0.5f));
				timeElapsed = 0.0f;
			}
		}
}
