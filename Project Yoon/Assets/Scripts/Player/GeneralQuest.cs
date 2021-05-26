using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class GeneralQuest
{
    // Start is called before the first frame update
        public int questNum;
        public bool isActive;
        public bool isComplete;
        public string title;
        public string description;
        public int yoodlesRewarded;
        public int expRewarded;
}
