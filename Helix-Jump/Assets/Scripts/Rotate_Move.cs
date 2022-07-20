using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Move : MonoBehaviour
{
    //rotate=döndürmek=>aynı konum ve boyutta nenesin açısal olarak dönmesidir
    public float rotateSpeed;//Silindirin dönüş hızını temsil eder
    private float moveX;
    
    void Update()
    {
        moveX = Input.GetAxis("Mouse X");

        if (Input.GetMouseButton(0))//left click yazılır
        {
            transform.Rotate(0f,moveX*rotateSpeed*Time.deltaTime,0f);//x-y-z eksenleri 
            //deltatime ile cihazlar arası pixsel uyumsuzluğu ve zamanla  hareket etme sağlanır
        }

    }
}





















