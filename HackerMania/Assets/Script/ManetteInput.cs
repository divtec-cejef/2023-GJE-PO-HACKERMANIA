using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ManetteInput : MonoBehaviour
{
    public EventSystem eventSystem;
    public Selectable firstButton;

    private void Update()
    {
        if (eventSystem.currentSelectedGameObject == null && Input.GetAxisRaw("Vertical") > 0)
        {
            eventSystem.SetSelectedGameObject(firstButton.gameObject);
        }
    }
}
