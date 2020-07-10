using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasController : MonoBehaviour
{

    public delegate void canvasDelegate();
    public static event canvasDelegate gameStart;

    enum CanvasState
    {

        StartMenu,
        Prepare,
        OnGame,
        GameOver

    }

    public static CanvasController Self;

    private void Awake()
    {
        Self = this;
    }

    private void OnDisable()
    {

        CollidersInterations.deadZoneCollider -= deadZoneCollider;
        WaitTouch.touch -= prepareTouch;


    }

    private void OnEnable()
    {

        CollidersInterations.deadZoneCollider += deadZoneCollider;
        WaitTouch.touch += prepareTouch;

    }

    public GameObject startMenuCanvas;
    public GameObject prepareCanvas;
    public GameObject onGameCanvas;
    public GameObject gameOverCanvas;

    

    void setCanvasState(CanvasState state)
    {

        switch (state) {

            case CanvasState.StartMenu:

                startMenuCanvas.SetActive(true);
                prepareCanvas.SetActive(false);
                onGameCanvas.SetActive(false);
                gameOverCanvas.SetActive(false);
                break;

            case CanvasState.Prepare:

                startMenuCanvas.SetActive(false);
                prepareCanvas.SetActive(true);
                onGameCanvas.SetActive(false);
                gameOverCanvas.SetActive(false);
                break;

            case CanvasState.OnGame:

                startMenuCanvas.SetActive(false);
                prepareCanvas.SetActive(false);
                onGameCanvas.SetActive(true);
                gameOverCanvas.SetActive(false);
                break;

            case CanvasState.GameOver:

                startMenuCanvas.SetActive(false);
                prepareCanvas.SetActive(false);
                onGameCanvas.SetActive(false);
                gameOverCanvas.SetActive(true);
                break;

        }

    }

    public void startGame()
    {
        //limpar a cena

        setCanvasState(CanvasState.Prepare);
        Score.score = 0;
        gameStart();

    }

    void deadZoneCollider()
    {

        Time.timeScale = 0;
        if (Score.score > Score.highScore)
        {

            Score.highScore = Score.score;

        }
        Score.score = 0;

        setCanvasState(CanvasState.GameOver);

    }

    void prepareTouch()
    {

        //Remontar toda a cena

        setCanvasState(CanvasState.OnGame);


    }

}
