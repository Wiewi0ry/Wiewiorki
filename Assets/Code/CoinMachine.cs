using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMachine : MonoBehaviour
{
    public GameObject CubeObj;
    Vector3 Pos;
    bool next;
    public float[] posX;
    public float[] posY;
    int value = 1;
    public int lastpos = 1;

    void FixedUpdate()
    {
        StartCoroutine(WaitSys());
    }
    IEnumerator WaitSys()
    {
        yield return new WaitForSeconds(1f);
        next = true;
        Generate();
    }
    void Generate()
    {
        if (!next)
            return;
        int i = Random.Range(0, 3);
        Pos.x = posX[i];
        Pos.y += posY[i];
        GameObject CubeClone = Instantiate(CubeObj, Pos, CubeObj.transform.rotation);
        CubeClone.GetComponent<CoinsScript>().myNum = value;
        CubeClone.transform.SetParent(this.transform);
        value += 1;
        next = false;
        return;
    }

    public void Message(int i)
    {
        if(lastpos == i)
        {
            lastpos += 1;
            Debug.Log("found!");
        }
        else
        {
            Debug.Log("not found");
        }
    }
}
