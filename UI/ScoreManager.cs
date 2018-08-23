using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;  // 追加しましょう

public class ScoreManager : MonoBehaviour {

    public GameObject score_object = null; // Textオブジェクト

		private int score = 0;
		private Text score_text;

    void Start () {}

    void Update () {
			score++;
			score_text = score_object.GetComponent<Text> ();
      score_text.text = "SCORE:"+score;
    }
}
