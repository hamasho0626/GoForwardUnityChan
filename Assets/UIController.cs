using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour {

    //ゲームオブジェクト
    private GameObject gameOverText;

    //走行距離テキスト
    private GameObject runLengthtext;

    //走った距離
    private float len = 0;

    //走る距離
    private float speed = 0.03f;

    //走る速度
    private bool isGameOver = false;

	// Use this for initialization
	void Start () {
        this.gameOverText = GameObject.Find("GameOver");
        this.runLengthtext = GameObject.Find("RunLength");
	}
	
	// Update is called once per frame
	void Update () {
		if(this.isGameOver == false)
        {
            //走った距離を更新する
            this.len += this.speed;

            //走った距離を表示する
            this.runLengthtext.GetComponent<Text>().text = "Distance:" + len.ToString("F2") + "m";
        }

        if(this.isGameOver == true)
        {
            //クリックされたらシーンをロードする
            if(Input.GetMouseButtonDown(0))
            {
                //GameSceneを読み込む
                SceneManager.LoadScene("GameScene");
            }
        }
	}

    public void GameOver()
    {
        //ゲームオーバーになったときに、画面上にゲームオーバーを穂湯辞する
        this.gameOverText.GetComponent<Text>().text = "GameOver";
        this.isGameOver = true;
    }
}
