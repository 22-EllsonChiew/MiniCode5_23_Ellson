using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class GameManager_23 : MonoBehaviour
{
    public static GameManager_23 instance;
    public GameObject addEnergyPreFab;
    public GameObject minusEnergyRreFab;
    public int numberOfSpawn;
    public float LevelTime;

    
    public Text Timer;
    float timer = 10.0f;



    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }

        if (LevelTime > 0)
        {
            for (int i = 0; i < numberOfSpawn; i++)
            {
                Vector3 randomPos = new Vector3(Random.Range(-15, 15),
                    0,
                    Random.Range(-15, 15));

                //Instantiate(addEnergyPreFab, randomPos, Quaternion.identity);

                if (Random.Range(0, 2) < 1)
                {
                    Instantiate(addEnergyPreFab, randomPos, Quaternion.identity);
                }
                else
                {
                    Instantiate(minusEnergyRreFab, randomPos, Quaternion.identity);
                }
            }
        }

        Timer.GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {

        
        if(LevelTime> 0)
        {
            LevelTime -= Time.deltaTime;
           // print("LevelTime: " + FormatTime(LevelTime));
            Timer.GetComponent<Text>().text = "Time: " + LevelTime.ToString("0");
        }
        else
        {
            LevelTime = 0;
            //print("Times Up!");
            Timer.GetComponent<Text>().text = "Ran Out Of Time";
            
        }
        
    }

    public string FormatTime(float time)
    {
        int minutes = (int)time / 60;
        int seconds = (int)time - 60 * minutes;
        int milliseconds = (int)(1000 * (time - minutes * 60 - seconds));
        return string.Format("{0:00:{1:00:{2.00}", minutes, seconds, milliseconds);
    }


}
