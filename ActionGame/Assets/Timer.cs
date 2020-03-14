using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float LimitTime;
    public Text TimeText;

    // Start is called before the first frame update
    void Start()
    {
        LimitTime = 15.0f;    
    }

    // Update is called once per frame
    void Update()
    {
        TimeText.text = "残り" + LimitTime.ToString();
        LimitTime -= Time.deltaTime;

        if(LimitTime <= 0)
        {
            TimeText.text = "Time Up!!";
        }
    }
}
