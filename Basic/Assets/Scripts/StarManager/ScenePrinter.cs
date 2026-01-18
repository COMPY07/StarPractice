using UnityEngine;

public class ScenePrinter : MonoBehaviour
{
    [SerializeField] private GameObject starPrefab;
    [SerializeField] private float charSpacing = 0.5f;
    [SerializeField] private float lineSpacing = 0.5f;
    [SerializeField] private Vector3 startPosition = new Vector3(-8.5f, 4.5f, 0f);

    private Vector3 currentPosition;
    private Transform container;

    private void Awake()
    {
        container = new GameObject("PrintedStars").transform;
        currentPosition = startPosition;
    }

    public void Print(string parm, bool enter = true)
    {
        foreach (char c in parm)
        {
            if (c == '*')
            {
                GameObject star = Instantiate(starPrefab, currentPosition, Quaternion.identity);
                star.transform.SetParent(container);
            }

            currentPosition.x += charSpacing;
        }

        if (enter)
        {
            currentPosition.x = startPosition.x;
            currentPosition.y -= lineSpacing;
        }
    }

    public void Clear()
    {
        foreach (Transform child in container)
        {
            Destroy(child.gameObject);
        }
        currentPosition = startPosition;
    }
}
