using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Canvas canvasToHide;

    private void Start()
    {
        // Assuming you have a button on the canvas
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(HideCanvas);
        }
    }

    void HideCanvas()
    {
        if (canvasToHide != null)
        {
            canvasToHide.gameObject.SetActive(false);
        }
    }
}
