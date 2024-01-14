using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class BodyParts
{
    public string elementName = "";
    public GameObject[] objects;
    public Button next;
    public Button previous;
    public Text elementNameDisplay;
    public int currIndex = 0;
}

public class Manager : MonoBehaviour
{
    public List<BodyParts> allElements = new List<BodyParts>();

    void Start()
    {
        InitializeElements();
        SetupElementButtons();
    }

    void InitializeElements()
    {
        foreach (BodyParts element in allElements)
        {

            foreach (GameObject obj in element.objects)
            {
                obj.SetActive(false);
            }


            element.objects[element.currIndex].SetActive(true);


            element.elementNameDisplay.text = element.objects[element.currIndex].gameObject.name;
        }
    }

    void SetupElementButtons()
    {
        foreach (BodyParts element in allElements)
        {

            element.next.onClick.AddListener(() => { ChangeElement(element, true); });


            element.previous.onClick.AddListener(() => { ChangeElement(element, false); });
        }
    }

    void ChangeElement(BodyParts element, bool increase)
    {

        element.objects[element.currIndex].SetActive(false);


        if (increase)
            element.currIndex += 1;
        else
            element.currIndex -= 1;



        if (element.currIndex > element.objects.Length - 1)
            element.currIndex = 0;
        if (element.currIndex < 0)
            element.currIndex = element.objects.Length - 1;


        element.objects[element.currIndex].SetActive(true);


        element.elementNameDisplay.text = element.objects[element.currIndex].gameObject.name;
    }
}
