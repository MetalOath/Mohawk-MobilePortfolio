using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour
{
    public List<GameObject> models = new List<GameObject>();
    public int currentModelIndex;
    public void ChangeModel(int newModelIndex)
    {
        models[currentModelIndex].SetActive(false);
        models[newModelIndex].SetActive(true);

        currentModelIndex = newModelIndex;
    }
    public void Next()
    {
        int nextIndex = currentModelIndex + 1;
        if (nextIndex >= models.Count)
        {
            nextIndex = 0;
        }
        ChangeModel(nextIndex);
    }
    public void Previous()
    {
        int prevIndex = currentModelIndex - 1;
        if (prevIndex < 0)
        {
            prevIndex = models.Count - 1;
        }
        ChangeModel(prevIndex);
    }
}
