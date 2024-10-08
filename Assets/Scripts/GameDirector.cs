using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   //UI를 사용하는 데 필요하다. 
using TMPro;

public class GameDirector : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject car;
    GameObject flag;
    GameObject distance;
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        this.distance.GetComponent<TextMeshProUGUI>().text = "목표 지점까지" + length.ToString("F2") + "m";
    }
}
