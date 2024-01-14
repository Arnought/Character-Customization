using UnityEngine;
using UnityEngine.UI;

public class ModelSwitcher : MonoBehaviour
{
    public GameObject model1, model2;

    public GameObject uiModel1, uiModel2;

    private GameObject currentModel;

    private void Start()
    {
        currentModel = model1;
        model1.SetActive(true);
        uiModel1.SetActive(true);
        model2.SetActive(false);
        uiModel2.SetActive(false);
    }

    public void SwitchModel()
    {
        if (currentModel == model1)
        {
            model1.SetActive(false);
            uiModel1.SetActive(false);
            model2.SetActive(true);
            uiModel2.SetActive(true);
            currentModel = model2;
        }
        else
        {
            model1.SetActive(true);
            uiModel1.SetActive(true);
            model2.SetActive(false);
            uiModel2.SetActive(false);
            currentModel = model1;
        }
    }
}
