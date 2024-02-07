using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LensTextManipulator : MonoBehaviour
{

    [SerializeField] private QuestionStateAdvancer questionIteration;
    private TextMeshPro questionNumber;
    private TextMeshPro magnification;

    private void Start()
    {
        questionNumber = transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<TextMeshPro>();
        magnification = transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<TextMeshPro>();
        ChangeText();
    }

    void ChangeText()
    {
        questionNumber.SetText("Question " + (questionIteration.intQuestionIter + 1));
        //Set the maginification based on the question number
        string tempMagnification = "1";
        for (int i = 0; i < questionIteration.intQuestionIter; i++)
        {
            tempMagnification += "0";
        }
        magnification.SetText(tempMagnification + "x");
    }

    void Click()
    {
        GetComponent<AudioSource>().Play();
    }
}
