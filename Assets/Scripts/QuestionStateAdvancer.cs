using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class QuestionStateAdvancer : MonoBehaviour
{
    [SerializeField] private Animator animMicroscope;
    public int intQuestionIter = 0;
    public Animator animCurrent;
    private bool exiting = false;
    private Animator m_Animator;

    // Start is called before the first frame update
    void Start()
    {       
        m_Animator= GetComponent<Animator>();
        animCurrent = transform.GetChild(intQuestionIter).GetComponent<Animator>();
        transform.GetChild(intQuestionIter).gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        AnimatorStateInfo l_AnimState = animCurrent.GetCurrentAnimatorStateInfo(0);
        // Check input for advancing state and if the animation is done
        if (Input.GetButtonDown("Jump") && l_AnimState.normalizedTime >= 1)
        {
            // Trigger the next state in the question's animator
            animCurrent.SetTrigger("Next State");
        }

        //Check input to restart question
        if (Input.GetButtonDown("Cancel"))
        {
            animCurrent.SetTrigger("Restart");
            // Cancel next state trigger if active
            animCurrent.ResetTrigger("Next State");
        }

        // Check if the question is at the end of the state machine
        if (l_AnimState.IsName("Exit State") && !exiting)
        {
            exiting = true;
            // Trigger the transition
            animMicroscope.SetTrigger("Rotate");
            m_Animator.SetTrigger("Transition");
            // Set the referenced animator to the next question
            animCurrent.ResetTrigger("Restart");         
        }
    }

    public void restartQuestions()
    {

    }

    public void NextQuestion()
    {
        exiting = false;
        transform.GetChild(intQuestionIter).gameObject.SetActive(false);
        intQuestionIter++;
        transform.GetChild(intQuestionIter).gameObject.SetActive(true);
        animCurrent = transform.GetChild(intQuestionIter).GetComponent<Animator>();
    }
}
