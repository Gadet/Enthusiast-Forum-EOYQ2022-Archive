using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlaylistManager : MonoBehaviour
{
    [SerializeField] private int playlistIndex = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void RestartMusic()
    {
        transform.GetChild(playlistIndex).gameObject.SetActive(false);
        playlistIndex = 0;
        transform.GetChild(playlistIndex).gameObject.SetActive(true);
    }

    public void NextSong()
    {
        transform.GetChild(playlistIndex).gameObject.SetActive(false);
        playlistIndex++;
        if (playlistIndex >= transform.childCount)
        {
            return;
        }
        transform.GetChild(playlistIndex).gameObject.SetActive(true);
    }
}
