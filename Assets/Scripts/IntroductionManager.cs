using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionManager : MonoBehaviour
{
    [SerializeField] private Camera mainCamera;
    [SerializeField] private GameObject presentation;
    private Animator m_Animator;
    // Start is called before the first frame update
    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            // Trigger the next state in the animator
            m_Animator.SetTrigger("Next State");
        }

        //Check input to restart question
        if (Input.GetButtonDown("Cancel"))
        {
            m_Animator.SetTrigger("Restart Music");
            // Cancel next state trigger if active
            m_Animator.ResetTrigger("Next State");
        }
    }

    protected void RestartMusic()
    {
        transform.Find("MusicCollection").gameObject.SetActive(true);
        GetComponentInChildren<MusicPlaylistManager>().RestartMusic();
    }

    protected void StopMusic()
    {
        transform.Find("MusicCollection").gameObject.SetActive(false);
    }

    protected void endIntro()
    {
        mainCamera.GetComponent<Animator>().SetTrigger("Family Guy");
    }
    protected void switchToPresentation()
    {
        presentation.SetActive(true);
        gameObject.SetActive(false);
    }
}
