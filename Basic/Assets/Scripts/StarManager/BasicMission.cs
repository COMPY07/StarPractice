using UnityEngine;

public class BasicMission : MonoBehaviour
{
    private ScenePrinter printer;

    private void Awake()
    {
        printer = GetComponent<ScenePrinter>();
    }

    private void Start()
    {
        Solution();
    }
    
    public virtual void Solution()
    {
        
    }
    
    public void Print(string msg, bool enter = true)
    {
        printer.Print(msg, enter);
    }

    public void Clear()
    {
        printer.Clear();
    }
}