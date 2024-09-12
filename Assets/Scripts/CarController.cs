using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector3 startPos; //Vector3 = x, y, z
                      //Vector2 = x, y
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   //마우스 클릭 코드
        /*if (input.getmousebuttondown(0))
        {
            this.speed = 0.1f;
        }
        else if (input.getmousebuttondown(1))
        {
            this.speed = -0.1f;
        }
        transform.translate(this.speed, 0, 0);
        this.speed *= 0.98f; */

        if (Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLenght = endPos.x - this.startPos.x;

            this.speed = swipeLenght / 800.0f;
        }
        transform.Translate(this.speed, 0, 0);
        this.speed *= 0.98f;
    }

    
        
}
