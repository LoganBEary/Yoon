using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    public class KillGoal : QuestGoal
    {
        public int enemyID;

        public KillGoal(int amntNeeded, int enemyID)
        {
            currCount = 0;
            countNeeded = amntNeeded;
            completed = false;
            this.enemyID = enemyID;
        }

        void enemyKilled(int enemyID)
        {
            if(this.enemyID == enemyID)
            {
                increase(1);
            }
        }
    }