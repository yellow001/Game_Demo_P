using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YUtility.Logic {
    /// <summary>
    /// 逻辑管理类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class BaseLogicMgr<T> where T : BaseLogicMgr<T>
    {
        protected static T ins;
        protected bool inited = false;
        public static T Ins {
            get {
                if (ins == null)
                {
                    ins = new BaseLogicMgr<T>() as T;
                }
                return ins;
            }
        }

        public virtual void Init()
        {
        }
    }
}

