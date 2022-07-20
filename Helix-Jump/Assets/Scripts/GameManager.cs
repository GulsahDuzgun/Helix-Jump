using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//Canvaslarla UI kullanılacağı için Unity.Engine.UI kütüphanesi eklenmelidir
using UnityEngine.SceneManagement;//Sahneleme olacağı için bu Unity.Engine.SceneManagement kütüphanesi kullanılır

    public class GameManager : MonoBehaviour
    {
        private int score;
        public Text ScoreText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameScore(int ringScore)
    {
        score += ringScore;
        ScoreText.text = score.ToString();
    }
    public void RestartGame()//Oyun sonlandığında aynı oyunun devam etmesini sağlar
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

























