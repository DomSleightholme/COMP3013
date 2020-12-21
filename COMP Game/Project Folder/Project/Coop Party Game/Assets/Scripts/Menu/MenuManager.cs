using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [Header("Animation")]
    public Animator SceneTransition;
    public GameObject Mask;

    [Header("Objects")]
    public GameObject SecondScreenObject;
    public GameObject FirstScreenObject;
    public GameObject OptionsObject;

    public AnimatedButton optionsButton;
    public GameObject OptionsPanel;

    private void Awake()
    {      
        SceneTransition.SetTrigger("FadeIn");

        StartCoroutine(MaskOff());
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
        SceneTransition.SetTrigger("FadeOut");

        StartCoroutine(SecondScreenFade());
    }

    public void Quit()
    {
        
    }

    public void Online()
    {
        Mask.SetActive(true);
        SceneTransition.SetTrigger("FadeOut");
    }

    public void Local()
    {
        Mask.SetActive(true);
        SceneTransition.SetTrigger("FadeOut");
    }

    public void Options()
    {
        optionsButton.HoverOff();
        Mask.SetActive(true);
        SceneTransition.SetTrigger("FadeOut");

        StartCoroutine(OptionsFade());
    }

    IEnumerator SecondScreenFade()
    {       
        yield return new WaitForSeconds(1);
        OptionsObject.SetActive(false);
        FirstScreenObject.SetActive(false);
        SecondScreenObject.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        Mask.SetActive(false);
    }

    IEnumerator OptionsFade()
    {
        yield return new WaitForSeconds(1);
        SecondScreenObject.SetActive(false);
        OptionsObject.SetActive(true);
        yield return new WaitForSeconds(1.2f);
        Mask.SetActive(false);
    }
}
