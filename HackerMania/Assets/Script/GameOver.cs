using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameOver : MonoBehaviour{
public GameObject GameOverScreen;
public Image fillImage;
public bool Catch = false;
public bool isGameOverScreenActive = false;
public static GameOver instance;

private void Awake(){
    if (instance == null){
        Debug.LogWarning("Il y a plus d'une instance de GameOver dans la scène");
        return;
    }
    instance = this;
}
    // Start is called before the first frame update
    void Start(){
     SoundBar = GetComponent<Image>();
    }

    //Fonction qui s'execute lorsque le joueur se fait repèrer et attraper par le garde
    public void GetCatch (){
        Catch = true;
        GameOverMenu();
        return;
    }

    //Fonction qui s'execute lorsque le joueur se fait attraper par le garde
    public void GameOverMenu(){
		if (Catch == true){
            isGameOverScreenActive = true;
            PlayerMovement.enable = false;
            GameOverScreen.SetActive(true);
			Debug.Log("GameOver");
			return;
		}
	}
    // Update is called once per frame
    void Update(){
    if (SoundBar.fillAmount == 0){
        GetCatch();
    }
    }
}