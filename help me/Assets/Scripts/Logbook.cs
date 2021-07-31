using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Logbook : MonoBehaviour
{
    public RhythmGameMapper rhythmGameMapper;

    public GameObject pauseTab;
    public GameObject birdsTab;

    public Animator bookLog;

    public AudioSource audioSource;

    public Animator black;

    public AudioClip buttonClick1;
    public AudioClip buttonClick2;
    public AudioClip buttonClick3;

    public AudioClip BlueJay;

    public AudioClip cardinal;

    public AudioClip bullFinch;

    public TextMeshProUGUI highScoreText;

    public GameObject GameOverScreen;

    public AudioClip parrot;

    // Start is called before the first frame update
    void Start()
    {
        rhythmGameMapper = GameObject.Find("Rhythm Game Mapper").GetComponent<RhythmGameMapper>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResumeGame()
    {
        var randomButtonClick = Random.Range(0 , 2);
        switch(randomButtonClick)
        {
            case 0:
            audioSource.PlayOneShot(buttonClick1, 1f);
            break; 

            case 1:
            audioSource.PlayOneShot(buttonClick2, 1f);
            break;

            case 2:
            audioSource.PlayOneShot(buttonClick3, 1f);
            break;
        }
       bookLog.SetBool("Enter", false);
       rhythmGameMapper.Resume();
    }

    public void ReturnToMainMenu()
    {
        var randomButtonClick = Random.Range(0 , 2);
        switch(randomButtonClick)
        {
            case 0:
            audioSource.PlayOneShot(buttonClick1, 1f);
            break; 

            case 1:
            audioSource.PlayOneShot(buttonClick2, 1f);
            break;

            case 2:
            audioSource.PlayOneShot(buttonClick3, 1f);
            break;
        }
        StartCoroutine(ReturnToMenu());
        
    }

    public void RestartGame()
    {
        StartCoroutine(restart());
    }

    public void SwitchToPauseTab()
    {
        var randomButtonClick = Random.Range(0 , 2);
        switch(randomButtonClick)
        {
            case 0:
            audioSource.PlayOneShot(buttonClick1, 1f);
            break; 

            case 1:
            audioSource.PlayOneShot(buttonClick2, 1f);
            break;

            case 2:
            audioSource.PlayOneShot(buttonClick3, 1f);
            break;
        }
        pauseTab.SetActive(true);
        birdsTab.SetActive(false);
    }

    public void SwitchToBirdsTab()
    {
        var randomButtonClick = Random.Range(0 , 2);
        switch(randomButtonClick)
        {
            case 0:
            audioSource.PlayOneShot(buttonClick1, 1f);
            break; 

            case 1:
            audioSource.PlayOneShot(buttonClick2, 1f);
            break;

            case 2:
            audioSource.PlayOneShot(buttonClick3, 1f);
            break;
        }
        pauseTab.SetActive(false);
        birdsTab.SetActive(true);
    }

    public void BlueJay2()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(BlueJay, 1f);
        }
    }

    public void RedBirb2()
    {
         if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(cardinal, 1f);
        }
    }

    public void BullFinch2()
    {
         if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(bullFinch, 1f);
        }
    }

    public void Macaw2()
    {
          if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(parrot, 1f);
        }
    }

    IEnumerator ReturnToMenu()
    {
        GameOverScreen.transform.localScale = new Vector3(0, 0,0);
        black.SetBool("FadeOut", true);
        rhythmGameMapper.Resume22();
        yield return new WaitForSecondsRealtime(1);
        SceneManager.LoadScene("Menu");
        Debug.Log("mattress");
    }

    IEnumerator restart()
    {
        GameOverScreen.transform.localScale = new Vector3(0, 0,0);
        black.SetBool("FadeOut", true);
        rhythmGameMapper.Resume22();
        yield return new WaitForSecondsRealtime(1f);
        SceneManager.LoadScene("GamePlay");
    }
}
