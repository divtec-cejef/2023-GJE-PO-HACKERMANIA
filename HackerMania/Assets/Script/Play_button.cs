using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Play_button : MonoBehaviour
{
  //  private EventSystems eventController;
  //  private Button btn;  
  //  private GameManager manager;

    void Start()
    {
   //     manager = GameManager.instance;
   //     btn = GameObject.Find("BT_jouer").GetComponent<Button>();
    //    btn.onClick.AddListener(ButtonSelected);
    }

    void ButtonSelected(){
    //    Debug.Log(btn.name + "is clicked");
    //    ChangeScene(MainGame);
    }

    void ChangeScene(string _sceneName){
     //   manager.LoadScene(_sceneName);
    }

    void OnDisable(){
      //  Debug.log("Remove Listener");
      //  btn.onClick.RemoveListener(ButtonSelected);
    }
}
