using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    public static int lifecount = 0;

	void OnTriggerEnter2D ()
	{
        if(lifecount < 6)
        {
            if (Timer.seconds <= 7)
            {
                Lives.CurrentLife += 1;
                lifecount += 1;
            }
        }
        
        Score.CurrentScore += 100;
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
