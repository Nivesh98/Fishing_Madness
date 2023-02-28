﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using UnityEditor;
using System.Threading;
using System.Runtime.ConstrainedExecution;
using Unity.Collections.LowLevel.Unsafe;

public class ScoreL1ss : MonoBehaviour
{
    public GameObject WinmenuUI;
    public GameObject LoseMenuUI;
    public static bool gameIsPaused = false;
    public float cnt;
    public Text myScoreText;
    private Object enemyRef;
    public static int ScoreNum;
    public float countnm = 0;
    public int soutnm;
    //public GameObject fishobj;


    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        myScoreText.text = "Score : " + ScoreNum;
        //countnm = cnt.getCoundDownValue();
        //cnt = new Count();
        //Count cnt = GetComponent<Count>();
        //cnt = Count.countDownNumber;
    }

    void Update()
    {
        cnt = Count.currentTime;
    }

    public void los()
    {
        if (cnt == 0)
        {
            LoseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            print("Count is 0");
        }
    }

    public void OnTriggerEnter2D(Collider2D Fish)
    {
        //cnt = Count.countDownNumber;
        //cnt = Count.currentTime;

        if (cnt == 0)
        {
            LoseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            print("Count is 0");
        }

        if (Fish.tag == "SmallFish")
        {
            ScoreNum += 5;
            Destroy(Fish.gameObject);
            myScoreText.text = "Score : " + ScoreNum;

        }
        else if (Fish.tag == "GreenFish")
        {
            ScoreNum += 10;
            Destroy(Fish.gameObject);
            myScoreText.text = "Score : " + ScoreNum;
        }
        else if (Fish.tag == "BlueYelloewFish")
        {
            ScoreNum += 15;
            Destroy(Fish.gameObject);
            myScoreText.text = "Score : " + ScoreNum;
        }
        else if (Fish.tag == "PurppleFish")
        {
            ScoreNum += 5;
            Destroy(Fish.gameObject);
            myScoreText.text = "Score : " + ScoreNum;
        }
        else if (Fish.tag == "YelloewFish")
        {
            ScoreNum += 15;
            Destroy(Fish.gameObject);
            myScoreText.text = "Score : " + ScoreNum;
        }
        else if (Fish.tag == "Shark")
        {
            ScoreNum += 10;
            Destroy(Fish.gameObject);
            myScoreText.text = "Score : " + ScoreNum;
        }
        else if (Fish.tag == "GreenBoot")
        {
            ScoreNum -= 10;
            Destroy(Fish.gameObject);
            myScoreText.text = "Score : " + ScoreNum;
        }
        else if (Fish.tag == "BlackSock")
        {
            ScoreNum -= 5;
            Destroy(Fish.gameObject);
            myScoreText.text = "Score : " + ScoreNum;
        }

        //countnm = cnt.getCoundDownValue();

        //if (cnt == 0)
        //{
        //LoseMenuUI.SetActive(true);
        //Time.timeScale = 0f;
        //print("Count is 0");
        //}


        if (ScoreNum >= 125)
        {
            WinmenuUI.SetActive(true);
            Time.timeScale = 0f;
            print("Count is " + cnt);
        }

    }



}
