using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class MainMenu : MonoBehaviour
{   
    public GameObject nextScreen, player; 
    
    public void PlayGame(){
        this.gameObject.SetActive(false);
        nextScreen.SetActive(true);
    }

    public void CharSelect(Sprite character){
        PlayGame();
        player.GetComponent<SpriteRenderer>().sprite = character;
    }

    public void quit(){
        Application.Quit();
    }
}
