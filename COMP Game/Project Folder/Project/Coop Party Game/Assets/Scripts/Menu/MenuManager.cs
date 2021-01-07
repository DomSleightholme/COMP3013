using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [Header("Animation")]
    public Animator SceneTransition;
    public GameObject Mask;

    [Header("Objects")]
    public GameObject FirstScreenObject;
    public GameObject SecondScreenObject;
    public GameObject OptionsObject;

    public AnimatedButton optionsButton;
    public GameObject OptionsPanel;

    bool isOnStart;
    GameManager gameManager;

    private void Awake()
    {      
        isOnStart = true;
        StartCoroutine(MaskOff());
    }

    private void Start()
    {
        SceneTransition.SetTrigger("FadeOut");
        gameManager = FindObjectOfType<GameManager>();
        FirstScreenObject.SetActive(true);
        SecondScreenObject.SetActive(false);
        OptionsObject.SetActive(false);
    }

    IEnumerator MaskOff()
    {
        yield return new WaitForSeconds(1.5f);

        Mask.SetActive(false);
    }

    public void SecondScreen()
    {
        OptionsPanel.SetActive(true);
        optionsButton.HoverOff();
        Mask.SetActive(true);
        SceneTransition.SetTrigger("FadeIn");

        StartCoroutine(SecondScreenFade());
    }

    public void Quit()
    {
        
    }

    public void Online()
    {
        Mask.SetActive(true);
        SceneTransition.SetTrigger("FadeIn");
        SceneTransition.SetBool("newScene", true);
        gameManager.isLocal = false;
        gameManager.isOnline = true;

        StartCoroutine(CoopFade());
    }

    public void Local()
    {
        Mask.SetActive(true);
        SceneTransition.SetTrigger("FadeIn");
        SceneTransition.SetBool("newScene", true);
        gameManager.isLocal = true;
        gameManager.isOnline = false;

        StartCoroutine(CoopFade());
    }

    public void Options()
    {
        optionsButton.HoverOff();
        Mask.SetActive(true);
        SceneTransition.SetTrigger("FadeIn");

        StartCoroutine(OptionsFade());
    }

    IEnumerator CoopFade()
    {
        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene("TheBoard");
    }

    IEnumerator SecondScreenFade()
    {       
        yield return new WaitForSeconds(1.5f);
        OptionsObject.SetActive(false);
        FirstScreenObject.SetActive(false);
        SecondScreenObject.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        Mask.SetActive(false);
    }

    IEnumerator OptionsFade()
    {
        yield return new WaitForSeconds(1.5f);
        SecondScreenObject.SetActive(false);
        OptionsObject.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        Mask.SetActive(false);
    }
}
