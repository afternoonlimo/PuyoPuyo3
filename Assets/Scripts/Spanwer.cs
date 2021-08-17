using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spanwer : MonoBehaviour {

    public GameObject[] standbyGroup;

    private void Awake()
    {
     
    }

    void Start()
    {
        SpawnNext();
    }

    public void SpawnNext() {

        GetComponent<AudioSource>().Play();
       

        GameObject go = Instantiate(standbyGroup[FindObjectOfType<Previous>().Next()],this.transform.position,Quaternion.identity);

        go.transform.parent = this.transform;
    }
}
