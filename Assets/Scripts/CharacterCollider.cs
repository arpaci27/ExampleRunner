using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class CharacterCollider : MonoBehaviour
{
    private CharacterMoveController characterMoveController;
    public Text ScoreText;
    public int score = 0;
    public int CharacterHealth = 3;
    public GameObject gameoverCanvas;

    private void Start()
    {
        characterMoveController = GetComponent<CharacterMoveController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Diamond")
        {
            Destroy(other.gameObject);
            score++;
        }

        if (other.gameObject.tag == "Block")
        {
            CharacterHealth--;
        }

        if (other.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(1);
        }
    }

    private void Update()
    {
        ScoreText.text = score.ToString();
        if (CharacterHealth == 0)
        {
            gameoverCanvas.SetActive(true);
            //Time.timeScale = 0;
            characterMoveController.moveSpeed = 0;
            SceneManager.LoadScene(0);
        }
        
    }
}
