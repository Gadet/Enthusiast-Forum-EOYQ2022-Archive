using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class Music : MonoBehaviour
{
    [SerializeField] private TextAsset lyricDoc;
    private int lyricsIter = 1;
    protected string[] lyrics;
    private TextMeshPro lyricOld;
    private TextMeshPro lyricCurrent;
    private TextMeshPro lyricNext;
    private AudioSource m_AudioSource;
    private Animator m_Animator;

    void Start()
    {
        Transform lyricObject = transform.Find("Lyrics");
        lyricOld = lyricObject.Find("Old").GetComponent<TextMeshPro>();
        lyricCurrent = lyricObject.Find("Current").GetComponent<TextMeshPro>();
        lyricNext = lyricObject.Find("Next").GetComponent<TextMeshPro>();
        if (lyricDoc != null)
        {
            lyrics = lyricDoc.text.Split('\n');
            lyricOld.SetText(lyrics[0]);
            lyricCurrent.SetText(lyrics[1]);
            lyricNext.SetText(lyrics[2]);
        }
        m_AudioSource = GetComponent<AudioSource>();
        m_Animator = GetComponent<Animator>();
    }

    protected void playMusic()
    {
        m_AudioSource.Play();
    }

    protected void nextLyric()
    {
        m_Animator.SetTrigger("Scroll");   
    }
    protected void updateText()
    {
        lyricOld.SetText(lyrics[lyricsIter - 1]);
        lyricCurrent.SetText(lyrics[lyricsIter]);
        lyricNext.SetText(lyrics[lyricsIter + 1]);
        lyricsIter++;
    }

    protected void musicEnded()
    {
        GetComponentInParent<MusicPlaylistManager>().NextSong();
    }
}
