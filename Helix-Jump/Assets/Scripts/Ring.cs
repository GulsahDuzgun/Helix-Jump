using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ball;
    private GameManager gm;
        
    void Start()//oyun ilk başladığında sadece 1 kere çağrılır
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

 
    void Update() //frame başına güncelleme yapar ekrdaki görüntünün ilerlemsini sağlar
    {
        if (transform.position.y + 12.5f >= ball.position.y)//il halkanın konumu 0 iken ball 13. Eklema yaparak halkanın destroy edilmesi sağlandı
        {
            Destroy(gameObject);
            gm.GameScore(25);
        }
        
    }
}

















