using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SlotController : MonoBehaviour
{
    public bool isSelected;
    public int[] index;
    public Image img;

    public void Awake()
    {
        img = GetComponent<Image>();
    }

    public void OnMouseDrag(BaseEventData baseEventData)
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButtonDown(0))
        {
            isSelected = true;
            img.color = Color.red;
        } else if (Input.GetMouseButton(1) || Input.GetMouseButtonDown(1))
        {
            isSelected = false;
            img.color = Color.white;
        }
    }
}
