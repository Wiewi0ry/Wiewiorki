using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovee : MonoBehaviour
{

    Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rigid.velocity = (Vector3.forward * Time.deltaTime * 1000f);
        Vector3 newRotation = new Vector3(0, 0, 0);
        transform.eulerAngles = newRotation;
        transform.position = new Vector3(0f, 0.75f, transform.position.z);



    }


}
