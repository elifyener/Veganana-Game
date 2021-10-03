using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Animator animator;

    int score;
    bool animValue;
    TextMeshProUGUI scoreText;
    void Start()
    {
        scoreText = GameObject.Find("Canvas/scoreText").GetComponent<TextMeshProUGUI>();
    }

   private void OnCollisionEnter2D(Collision2D collision){
    if(collision.gameObject.tag != "Mushroom")   
    score++;
    scoreText.text = score.ToString();
    animator.SetTrigger("catchTrigger");
    Destroy(collision.gameObject);
   }
}
