using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]

public class CusrorControlle : MonoBehaviour
{
  public Texture2D cursorTexture;

  void OnMouseEnter () {
	 Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.ForceSoftware);
  }

  void OnMouseExit() {
	  Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto); //curseur par défaut du système
  }
}  
