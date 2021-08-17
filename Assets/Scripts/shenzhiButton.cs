using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class shenzhiButton : MonoBehaviour
{
  
    public Button GameAgainPlayButton; 
    public Button GameRePlayButton;   
    public Button GameQuitButton;    

    public Slider slider;

    public bool TimeOnOff = false;

    // Start is called before the first frame update
    void Start()
    {  
        GameAgainPlayButton.onClick.AddListener(GameAgainPlayButtonListener);   
        GameRePlayButton.onClick.AddListener(GameRePlayButtonClickListener);    
        GameQuitButton.onClick.AddListener(GameQuitButtonClickListener);      

        slider.value = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeOnOff == false)
        {
            Time.timeScale = slider.value;
        }    
    }

    void GameAgainPlayButtonListener()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    void GameQuitButtonClickListener()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
      Application.Quit();
#endif
    }

    void GameRePlayButtonClickListener()
    {
        if (TimeOnOff == true)
        {
            TimeOnOff = false;
            Time.timeScale = slider.value;    
        }
        else
        {
            TimeOnOff = true;

            Time.timeScale = 0;  
        }


    }


}
