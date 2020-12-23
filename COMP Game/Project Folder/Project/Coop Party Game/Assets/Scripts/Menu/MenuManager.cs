using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private void Awake()
    {      
        SceneTransition.SetTrigger("FadeOut");
        isOnStart = true;
        StartCoroutine(MaskOff());
    }

    private void Start()
    {
        FirstScreenObject.SetActive(true);
        SecondScreenObject.SetActive(false);
        OptionsObject.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return) && isOnStart == true)
        {
            SecondScreen();
            isOnStart = false;

            var menuCamera = FindObjectOfType<MenuCamera>();
            menuCamera.isRotating = false;
        }
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
    }

    public void Local()
    {
        Mask.SetActive(true);
        SceneTransition.SetTrigger("FadeIn");
    }

    public void Options()
    {
        optionsButton.HoverOff();
        Mask.SetActive(true);
        SceneTransition.SetTrigger("FadeIn");

        StartCoroutine(OptionsFade());
    }

    IEnumerator SecondScreenFade()
    {       
        yield return new WaitForSeconds(0.85f);
        OptionsObject.SetActive(false);
        FirstScreenObject.SetActive(false);
        SecondScreenObject.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        Mask.SetActive(false);
    }

    IEnumerator OptionsFade()
    {
        yield return new WaitForSeconds(0.85f);
        SecondScreenObject.SetActive(false);
        OptionsObject.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        Mask.SetActive(false);
    }
}
