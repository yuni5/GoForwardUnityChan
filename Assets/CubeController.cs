using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	// キューブの移動速度
	private float speed = -0.2f;

	// 消滅位置
	private float deadLine = -10;

	// Unityちゃんを取得
	public GameObject UnityChan2D;

	// AudioSorceを格納する変数の宣言
	public AudioClip impact;
	private	AudioSource	audio;

	// Use this for initialization
	void Start(){

		audio = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {
		// キューブを移動させる
		transform.Translate (this.speed, 0, 0);

		// 画面外に出たら破棄する
		if (transform.position.x < this.deadLine){
			Destroy (gameObject);
		}

	}

	void OnCollisionEnter2D(Collision2D other){


		if(other.gameObject.tag == "CubePrefab"||other.gameObject.tag == "ground"){
			audio.PlayOneShot(impact, 1F);
		}
	}

}
