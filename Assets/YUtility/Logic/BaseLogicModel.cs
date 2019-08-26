using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YUtility.Logic {
    /// <summary>
    /// 逻辑model类
    /// </summary>
    public class BaseLogicModel
    {
        /// <summary>
        /// 事件
        /// </summary>
        public Dictionary<string, Action> m_EventDic;

        public void AddEvent(string eventName,Action callBack) {
            if (m_EventDic == null) {
                m_EventDic = new Dictionary<string, Action>();
            }
            if (m_EventDic.ContainsKey(eventName))
            {
                m_EventDic[eventName] += callBack;
            }
            else {
                m_EventDic[eventName] = callBack;
            }
        }

        public void AddEvent(Enum eName, Action callBack) {
            AddEvent(eName.ToString(), callBack);
        }

        public void RefreshEvent(string eventName) {
            if (m_EventDic == null)
            {
                return;
            }
            if (m_EventDic.ContainsKey(eventName))
            {
                m_EventDic[eventName]();
            }
        }

        public void RefreshEvent(Enum eName) {
            RefreshEvent(eName.ToString());
        }

        public void RemoveEvent(string eventName,Action callBack) {
            if (m_EventDic == null)
            {
                return;
            }
            if (m_EventDic.ContainsKey(eventName))
            {
                m_EventDic[eventName] -= callBack;
            }
        }

        public void RemoveEvent(Enum eName,Action callBack) {
            RemoveEvent(eName.ToString(),callBack);
        }

        public void RemoveAllCallBack(string eventName) {
            if (m_EventDic == null)
            {
                return;
            }
            if (m_EventDic.ContainsKey(eventName))
            {
                m_EventDic.Remove(eventName);
            }
        }

        public void RemoveAllCallBack(Enum eName) {
            RemoveAllCallBack(eName.ToString());
        }

        public void ClearAllEvent() {
            if (m_EventDic == null)
            {
                return;
            }
            m_EventDic.Clear();
        }
    }
}

