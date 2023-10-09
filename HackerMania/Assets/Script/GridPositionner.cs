using UnityEngine;

public class GridPositionner : MonoBehaviour
{
    public float cellSize = 1f; // Taille de la cellule de la grille

    private void Start()
    {
        SnapToGrid();
    }

    private void SnapToGrid()
    {
        Vector3 currentPosition = transform.position;
        Vector3 snappedPosition = new Vector3(
            Mathf.Round(currentPosition.x / cellSize) * cellSize,
            Mathf.Round(currentPosition.y / cellSize) * cellSize,
            Mathf.Round(currentPosition.z / cellSize) * cellSize
        );
        transform.position = snappedPosition;
    }
}