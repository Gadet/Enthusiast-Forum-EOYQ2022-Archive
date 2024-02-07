using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionBen : MonoBehaviour
{
    private AudioSource m_AudioSource;
    [SerializeField] private AudioClip audio_Bulb;
    [SerializeField] private AudioClip audio_Ben;
    [SerializeField] private AudioClip audio_Yes;
    [SerializeField] private AudioClip audio_No;
    [SerializeField] private AudioClip audio_Hohoho;
    [SerializeField] private AudioClip audio_Eugh;
    [SerializeField] private AudioClip audio_Hangup;
    [SerializeField] private AudioClip audio_Rant;

    private void Start()
    {
        m_AudioSource= GetComponent<AudioSource>();
    }

    protected void Bulb()
    {
        m_AudioSource.clip = audio_Bulb;
        m_AudioSource.Play();
    }

    protected void Ben()
    {
        m_AudioSource.clip = audio_Ben;
        m_AudioSource.Play();
    }

    protected void Yes()
    {
        m_AudioSource.clip = audio_Yes;
        m_AudioSource.Play();
        GetComponent<Animator>().SetInteger("Stage", 3);
    }

    protected void No()
    {
        m_AudioSource.clip = audio_No;
        m_AudioSource.Play();
    }

    protected void Hohoho()
    {
        m_AudioSource.clip = audio_Hohoho;
        m_AudioSource.Play();
        GetComponent<Animator>().SetInteger("Stage", 1);
    }

    protected void Eugh()
    {
        m_AudioSource.clip = audio_Eugh;
        m_AudioSource.Play();
    }

    protected void Rant()
    {
        m_AudioSource.clip = audio_Rant;
        m_AudioSource.Play();
        GetComponent<Animator>().SetInteger("Stage", 2);
    }

    protected void Hangup()
    {
        m_AudioSource.clip = audio_Hangup;
        m_AudioSource.Play();
    }

}
