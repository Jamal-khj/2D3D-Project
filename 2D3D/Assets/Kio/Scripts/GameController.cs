using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting.Dependencies.Sqlite;

public class GameController : MonoBehaviour
{
    public List<Button> puzzleButtons = new List<Button>();
    public Sprite[] puzzleSprites;
    public List<Sprite> puzzleSpriteList = new List<Sprite>();

    [SerializeField] private Sprite bgImage;
    [SerializeField] private GameObject winScreen;
    [SerializeField] private GameObject gameOver;
    [SerializeField] private TMP_Text wrongGuessCountText;
    [SerializeField] private AudioSource cardFlipSFX;
    [SerializeField] private AudioSource rightSFX;
    [SerializeField] private AudioSource wrongSFX;

    private bool firstGuess, secondGuess;


    private int wrongGuessCount;
    private int correctGuessCount;
    private int gameGuesses;
    private int firstGuessIndex, secondGuessIndex;

    private string firstGuessPuzzle, secondGuessPuzzle;

    private void Awake()
    {
        puzzleSprites = Resources.LoadAll<Sprite>("Sprites/Card");
    }

    private void Start()
    {
        GetButtons();
        AddListeners();
        AddGamePuzzle();
        Shuffle(puzzleSpriteList);
        gameGuesses = puzzleSpriteList.Count / 2;
    }

    private void Update()
    {
        print("gameguesses: " + gameGuesses);
        print("correct guesses: " + correctGuessCount);
        print("wrong guesses: " + wrongGuessCount);
        wrongGuessCountText.text = "Wrong Guesses: " + wrongGuessCount;
    }

    void GetButtons()
    {
        GameObject[] objects = GameObject.FindGameObjectsWithTag("PuzzleButton");

        for(int i = 0; i < objects.Length; i++)
        {
            puzzleButtons.Add(objects[i].GetComponent<Button>());
            puzzleButtons[i].image.sprite = bgImage;
        }
    }

    void AddGamePuzzle()
    {
        int puzzleLooper = puzzleButtons.Count;
        int index = 0;

        for(int i = 0; i < puzzleLooper; i++)
        {
            if(index == puzzleLooper / 2)
            {
                index = 0;
            }

            puzzleSpriteList.Add(puzzleSprites[index]);

            index++;
        }
    }

    void AddListeners()
    {
        foreach (Button btn in puzzleButtons)
        {
            btn.onClick.AddListener(() => PickPuzzle());
        }
    }

    public void PickPuzzle()
    {
        string pieceName = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        if (!firstGuess)
        {
            firstGuess = true;

            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

            firstGuessPuzzle = puzzleSpriteList[firstGuessIndex].name;

            puzzleButtons[firstGuessIndex].image.sprite = puzzleSpriteList[firstGuessIndex];

            puzzleButtons[firstGuessIndex].interactable = false;

            cardFlipSFX.Play();
        }
        else if (!secondGuess)
        {
            secondGuess = true;

            secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

            secondGuessPuzzle = puzzleSpriteList[secondGuessIndex].name;

            puzzleButtons[secondGuessIndex].image.sprite = puzzleSpriteList[secondGuessIndex];

            puzzleButtons[secondGuessIndex].interactable = false;

            StartCoroutine(CheckIfThePuzzlesMatch());

            cardFlipSFX.Play();
        }
    }

    IEnumerator CheckIfThePuzzlesMatch()
    {
        yield return new WaitForSeconds(0.2f);

        if(firstGuessPuzzle == secondGuessPuzzle)
        {
            yield return new WaitForSeconds(0.5f);

            rightSFX.Play();

            puzzleButtons[firstGuessIndex].interactable = false;
            puzzleButtons[secondGuessIndex].interactable = false;

            puzzleButtons[firstGuessIndex].image.color = new Color(0, 0, 0);
            puzzleButtons[secondGuessIndex].image.color = new Color(0, 0, 0);

            CheckIfMinigameIsFinished();
        }
        else
        {
            yield return new WaitForSeconds(1f);

            wrongSFX.Play();
            cardFlipSFX.Play();

            puzzleButtons[firstGuessIndex].interactable = true;
            puzzleButtons[secondGuessIndex].interactable = true;

            puzzleButtons[firstGuessIndex].image.sprite = bgImage;
            puzzleButtons[secondGuessIndex].image.sprite = bgImage;

            wrongGuessCount++;
            if(wrongGuessCount >= 3)
            {
                GameOver();
            }
        }

        yield return new WaitForSeconds(0.5f);

        firstGuess = secondGuess = false;
    }

    void GameOver()
    {
        puzzleButtons[firstGuessIndex].interactable = false;
        puzzleButtons[secondGuessIndex].interactable = false;
        Debug.Log("Game Over!");
        gameOver.SetActive(true); 
    }

    void CheckIfMinigameIsFinished()
    {
        correctGuessCount++;

        if(correctGuessCount == gameGuesses)
        {
            Debug.Log("Minigame finished!");
            winScreen.SetActive(true);
        }

    }

    void Shuffle(List<Sprite> list)
    {
        for(int i = 0; i < list.Count; i++)
        {
            Sprite temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }
    }
}
