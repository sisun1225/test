using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour

{


    private static GameManager _instance;
    public static GameManager instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<GameManager>();
            }
            return _instance;
        }
    }

    private int score;

    [SerializeField]
    private Text scoreTxt;


    [SerializeField]
    public GameObject poop;

    [SerializeField]
    private Text bestScore;
    [SerializeField]
    private GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
       


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool stopTrigger = true;
    public void GameOver()
    {
        stopTrigger = false;
        StopCoroutine(CreatepoopRoutine());


        panel.SetActive(true);
    }


    public void GameStart()
    {
        stopTrigger = true;
        StartCoroutine(CreatepoopRoutine());
        panel.SetActive(false);

        score = 0;
        scoreTxt.text = "Score : " + score;

    }


    public void Score()
    {
        if (stopTrigger)
            score++;
        scoreTxt.text = "Score :" + score;
    }

    IEnumerator CreatepoopRoutine()
    {
        while (true)
        {
            if (stopTrigger)
                CreatePoop();
            yield return new WaitForSeconds(1);
        }


    }

    private void CreatePoop() 
    {

        Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f,1.0f),1.1f,0));
        pos.z = 0.0f;
        Instantiate(poop,pos,Quaternion.identity);
    
    }



}
