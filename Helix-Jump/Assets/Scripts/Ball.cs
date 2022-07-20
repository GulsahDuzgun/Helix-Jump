using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    //ball nesnesine RigidBody özelliği ile yer çekiminden etkilenme özelliği kazandırıldı
    public Rigidbody rb;
    public float jumpForce;//topun geri zıplaması için itme kuvveti
    public GameObject splashPrefab;//topun şıçrayan boyası
    private GameManager gm;
    private float _jumpForce = 5f;
    
    void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();// oyun başladığı anda bir GamaManeger tipinde nesne oluşturulur
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)//çarpışma olduğunda ne olacak?-çarptığı obje other ile belirtilmiş-
    {
        //AdForce methodu ile her zıplayışta daha yükseğe çıkar bunu çözmek içim velocity kullanılmalı
        //rb.AddForce(Vector3.up * jumpForce);
        rb.velocity=Vector3.up * _jumpForce;
        
        GameObject splash = Instantiate(splashPrefab, transform.position + new Vector3(0f , -0.1f ,0f), transform.rotation);//top her platforma çarptığında splashPrefabın özelliklerinde splash nesnesi yaratılır bir nesnesi yaratılmıi
        splash.transform.SetParent(other.gameObject.transform);
        //çarpıştığı her platformun metarial özelliği kontrol edilerek oyun gidişatı belirlenir
        
        string metarialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
        //Debug.Log("Metarial Adı: "+metarialName);

        
        if (metarialName == "Unsafe Color (Instance)")
        {
         gm.RestartGame();   
        }else if (metarialName == "Last Ring (Instance)")
        {
            Debug.Log("Next Level");
        }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}
