using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Previous : MonoBehaviour {


    public GameObject[] standbyGroup;

    public int[] showGroup;

    public int sgLimit=2;

    public static float timeFrame = 1f;

    public Button ButtonSpeed;

    public float TimeFrame
    {
        get
        {
            return timeFrame;
        }
    }

    private void Awake()
    {
        timeFrame = 1f;

        showGroup = new int[sgLimit];

        FillShowGroup();

        ButtonSpeed.onClick.AddListener(SpeedListener);
    }

    void Start () {


	}
	
	void Update () {

    }
    void SpeedListener()
    {
        Time.timeScale = 5;
    }

    public int Next()
    {
        int currentPieces = showGroup[0];
        FlushShowGroup();
        FillShowGroup(sgLimit-1);
        return currentPieces;
    }

    private void FlushShowGroup() {
        GameObject[] currentPieces = GameObject.FindGameObjectsWithTag("ShowGroup");
        Destroy(currentPieces[0]);
        MoveUp();
    }

    private void MoveUp(int i=0) {
        if (i < sgLimit - 1)
        {
            showGroup[i] = showGroup[++i];
            GameObject[] previousPieces = GameObject.FindGameObjectsWithTag("ShowGroup");
            previousPieces[i].transform.position += new Vector3(0,5.0f,0);
            MoveUp(i);
        }
    }

    private void FillShowGroup(int i=0) {
        if (i < sgLimit)
        {
            AddToShowGroup(i);
            FillShowGroup(++i);   
        }
    }

    private void AddToShowGroup(int i)
    {
        Time.timeScale = 1;

        showGroup[i] = Random.Range(0,standbyGroup.Length);

        GameObject go = Instantiate(standbyGroup[showGroup[i]],transform.position+new Vector3(0.5f,i*-5,-1),Quaternion.identity);

        go.transform.parent = this.transform;
    }
}
