using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
   private int aiScore, playerScore;
    public Text aScore, pScore;
    public Ball ball;
    public void IncresasePlayer()
    {
        ++playerScore;
        pScore.text = playerScore + "";
        Debug.Log(playerScore);
        ball.ResetPostion();
        
    }

    public void IncreaseAi()
    {
        ++aiScore;
        Debug.Log(playerScore);
        aScore.text = aiScore + "";
        ball.ResetPostion();
       
    }

   

    
}
