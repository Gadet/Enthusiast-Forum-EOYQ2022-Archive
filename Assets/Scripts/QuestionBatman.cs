using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class QuestionBatman : MonoBehaviour
{
    private TextMeshPro m_textMeshProTop;
    private TextMeshPro m_textMeshProBottom;
    private AudioSource m_audioSource;
    [SerializeField] private AudioSource BatmanAudio;
    [SerializeField] private AudioClip HelloChildren;
    [SerializeField] private AudioClip OhDontThink;
    [SerializeField] private AudioClip AlrightThen;
    [SerializeField] private AudioClip ImBatman;
    [SerializeField] private AudioClip HeHas7;
    [SerializeField] private AudioClip WoahWait;
    [SerializeField] private AudioClip IDidntWant;

    private void Start()
    {
        m_audioSource= GetComponent<AudioSource>();
        m_textMeshProTop = transform.GetChild(0).GetChild(0).GetComponent<TextMeshPro>();
        m_textMeshProBottom = transform.GetChild(0).GetChild(1).GetComponent<TextMeshPro>();
        m_audioSource = GetComponent<AudioSource>();
    }

    void changeTextPrompt0()
    {
        m_textMeshProTop.SetText("Greetings, children!");
        m_audioSource.clip = HelloChildren;
        m_audioSource.Play();
    }

    void changeTextPrompt1()
    {
        m_textMeshProBottom.SetText("I couldn’t help but overhear your discussion of brave and handsome heroes, and introduce myself!");
    }

    void changeTextPrompt2()
    {
        m_textMeshProTop.SetText("Oh, don’t think about it too much, I just wanted to make sure you are up to date on your knowledge of super vigilantes");
        m_textMeshProBottom.SetText("");
        m_audioSource.clip = OhDontThink;
        m_audioSource.Play();
    }

    void changeTextPrompt3()
    {
        m_textMeshProBottom.SetText("I heard the Joker made a similar entrance to your quiz last year, and I’m hoping he didn’t do anything to your brains");
    }

    void changeTextPrompt4()
    {
        m_textMeshProTop.SetText("Alright then:");
        m_textMeshProBottom.SetText("");
        m_audioSource.clip = AlrightThen;
        m_audioSource.Play();
    }

    void changeTextPrompt5()
    {
        m_textMeshProBottom.SetText("How many Phds does Bruce Banner, AKA the Hulk, have in the Marvel Cinematic Universe?");
    }

    void changeTextAnswer0()
    {
        m_textMeshProTop.SetText("I'm Batman");
        m_textMeshProBottom.SetText("");
        m_audioSource.clip = ImBatman;
        m_audioSource.Play();
    }

    void changeTextAnswer1()
    {
        m_textMeshProTop.SetText("He has 7!");
        m_audioSource.clip = HeHas7;
        m_audioSource.Play();
    }

    void changeTextAnswer2()
    {
        m_textMeshProBottom.SetText("Hey, uh, I heard about another Bruce guy who is pretty smart, he has like at least 4 of those in the older comics.");
    }

    void changeTextAnswer3()
    {
        m_textMeshProTop.SetText("Woah, wait-wait-wait-wait, I was hoping that I could… you know, stick with you guys?");
        m_textMeshProBottom.SetText("");
        m_audioSource.clip = WoahWait;
        m_audioSource.Play();
    }

    void changeTextAnswer4()
    {
        m_textMeshProBottom.SetText("It’s gotten really lonely since the Justice League kicked me out.");
    }

    void changeTextAnswer5()
    {
        m_textMeshProTop.SetText("Wha... but...");
        m_textMeshProBottom.SetText("");
        m_audioSource.clip = IDidntWant;
        m_audioSource.Play();
    }

    void changeTextAnswer6()
    {
        m_textMeshProBottom.SetText("I mean,");
    }

    void changeTextAnswer7()
    {
        m_textMeshProTop.SetText("I didn’t want to be in your stupid group anyway!");
        m_textMeshProBottom.SetText("");
    }
}
