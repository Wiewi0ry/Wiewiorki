using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    [Range(-3, 3)] public float ruchLewoPrawo;
    public float Speed;
    Rigidbody rigid;
    private GameObject moneyScore;
    private int moneyCollected;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
        moneyScore = GameObject.Find("MoneyScore");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(ruchLewoPrawo, transform.position.y, transform.position.z);
        rigid.velocity = (Vector3.forward * Time.deltaTime * 1000f);
        if (Input.GetButtonDown ("Right"))
        {
            if (ruchLewoPrawo == 3)
                return;
            ruchLewoPrawo += 3;
        }
        if (Input.GetButtonDown("Left"))
        {
            if (ruchLewoPrawo == -3)
                return;
            ruchLewoPrawo -= 3;
        }
        
    }

    void OnTriggerEnter(Collider otherl)
    {
            moneyCollected += 1;
            moneyScore.GetComponent<Text>().text = " Monety: " + moneyCollected;
        
    }
}
