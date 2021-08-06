 using UnityEngine;

public class Mouse : MonoBehaviour
{
    public Texture2D defaultTextureMouse;
    public Texture2D hoverTextureMouse;
    public CursorMode curModeMouse = CursorMode.Auto;
    public Vector2 hotSpotMouse = Vector2.zero;


    void StartMouse()
    {
        Cursor.SetCursor(defaultTextureMouse, hotSpotMouse, curModeMouse);
    }

    public void OnMouseEnter()
    {
        Debug.Log("Enter");
        Cursor.SetCursor(hoverTextureMouse, hotSpotMouse, curModeMouse);
    }

    public void OnMouseExit()
    {
        Debug.Log("Exit");
        Cursor.SetCursor(defaultTextureMouse, hotSpotMouse, curModeMouse);
    }
}
