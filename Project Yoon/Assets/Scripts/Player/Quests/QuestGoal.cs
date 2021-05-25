using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestGoal : MonoBehaviour
{
    public int countNeeded;
    public int currCount;
    public bool completed;
    // Start is called before the first frame update
    public void increase(int amnt)
    {
        currCount = Mathf.Min(currCount + 1, countNeeded);
        if(currCount >= countNeeded && !completed)
        {
            this.completed = true;
        }
    }
}
