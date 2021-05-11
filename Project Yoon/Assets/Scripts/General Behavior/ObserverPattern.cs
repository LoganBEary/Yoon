using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ObserverPattern
{
    public class Subject
    {
        List<Observer> m_observers = new List<Observer>();

        public void Notify()
        {
            for (int i = 0; i < m_observers.Count; i++)
            {
                m_observers[i].OnNotify();
            }
        }

        public void AddObserver(Observer observer)
        {
            m_observers.Add(observer);
        }
    }

    public abstract class Observer
    {
        public abstract void OnNotify();
    }

    public class UI_Observer : Observer
    {
        public UIQuestBehavior questBehavior;

        public UI_Observer(UIQuestBehavior q)
        {
            this.questBehavior = q;
        }

        public override void OnNotify()
        {
            PauseManager pauseManager = GameObject.Find("Pause Manager").GetComponent<PauseManager>();
            questBehavior.behave(pauseManager);
        }
    }

    public abstract class Behavior
    {
        public abstract void behave(PauseManager pauseManager);
    }

    public class UIQuestBehavior : Behavior
    {
        public int coinReward;
        public float xpReward;

        public UIQuestBehavior(int coins, float xp)
        {
            this.coinReward = coins;
            this.xpReward = xp;
        }

        public override void behave(PauseManager pauseManager)
        {
            pauseManager.CompletedQuest(coinReward, xpReward);
        }
    }
}
