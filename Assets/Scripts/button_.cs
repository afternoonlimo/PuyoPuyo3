using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button_ : MonoBehaviour {

    public Button ButtonLeft;
    public Button ButtonRigth;
    public Button ButtonRotate;
    public Button ButtonRotateRigth;
    public static int Button_num = 0;

	// Use this for initialization
	void Start () {
        ButtonLeft.onClick.AddListener(onLeftClick);
        ButtonRigth.onClick.AddListener(onRigthClick);
        ButtonRotate.onClick.AddListener(onRotateClick);
        ButtonRotateRigth.onClick.AddListener(onRotateRigthClick);

        Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A))
        {
            Button_num = 1;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Button_num = 2;
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            Button_num = 4;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Button_num = 3;
        }

    }

    void onLeftClick()
    {
        Button_num = 1;
    }

    void onRigthClick()
    {
        Button_num = 2;
    }

    void onRotateClick()
    {
        Button_num = 4;
    }

    void onRotateRigthClick()
    {
        Button_num = 3;
    }

}
