using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionController : MonoBehaviour
{
    // Start is called before the first frame update
    private float startX=-3.0f;
    private float endX=0f;
    private float speed;

    private float newTheta;
    //private bool movingRight = false;


    void Start()
    {
        newTheta = Random.Range(0f, Mathf.PI);
        speed = Random.Range(0.5f, 1.6f);
    }

    // Update is called once per frame
    void Update()
    {
        newTheta += speed * Time.deltaTime;
        transform.localPosition = new Vector3((Mathf.Abs(endX)- Mathf.Abs(startX)) /2+ Mathf.Cos(newTheta) * (endX - startX) / 2,transform.localPosition.y,transform.localPosition.z);

        //float newX=currentX+(movingRight ? speed*Time.deltaTime : -speed * Time.deltaTime);
        //newX=Mathf.Clamp(newX,Mathf.Min(startX,endX),Mathf.Max(startX,endX));

        //transform.position=new Vector3(newX,transform.position.y,transform.position.z);

        //if(newX==startX ||  newX==endX)
        //{
        //    movingRight = !movingRight;
        //}
        //currentX = newX;
    }
}
