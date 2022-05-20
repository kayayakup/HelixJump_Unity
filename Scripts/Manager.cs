using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{

    int score = 0;
    float passedObstacle = 0.0f;
    public float sumObstacles;
    public TMPro.TextMeshProUGUI scoreTxt;
    public Image fill;

    public GameObject panel;

    public void letObstacle()
    {
        score += 25;
        scoreTxt.text = score.ToString();

        passedObstacle += 1.0f;
        fill.fillAmount = passedObstacle / sumObstacles;
    }

    public void Again()
    {
        SceneManager.LoadScene(0);
    }

    public void NextLevel()
    {
        panel.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
