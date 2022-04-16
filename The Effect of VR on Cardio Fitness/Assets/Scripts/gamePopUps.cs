using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamePopUps : MonoBehaviour
{
   float timer;
   float seconds;
   float minutes;

  [SerializeField] Text myText;

   void Start() {
      timer = 0;
   }
    void Update() {
        changeText();
   }

   void changeText() {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (timer >= 60f && timer <= 61f) {
           myText.text = "1 minute down, 9 to go!";
        }
        else if (timer >= 64f && timer <= 65f) {
         myText.text = "";
        }
        else if (timer >= 180f && timer <= 181f) {
         myText.text = "3 minutes, only 7 left!";
        }
        else if (timer >= 184f && timer <= 185f) {
         myText.text = "";
        }
        else if (timer >= 300f && timer <= 301f ) {
           myText.text = "Halfway there!";
        }
        else if (timer >= 304f && timer <= 305f) {
         myText.text = "";
        }
        else if (timer >= 420f && timer <= 421f) {
           myText.text = "7 down, 3 to go!";
        }
        else if (timer >= 424f && timer <= 425f) {
         myText.text = "";
        }
        else if (timer >= 570f && timer <= 571f) {
           myText.text = "30 seconds!";
        }
        else if (timer >= 574f && timer <= 575f) {
         myText.text = "";
        }
        else if (timer >= 600f) {
           myText.text = "FINISH";
        }
        else if (timer >= 603f && timer <= 604f) {
         myText.text = "";
         Application.Quit();
        }
   }
}
