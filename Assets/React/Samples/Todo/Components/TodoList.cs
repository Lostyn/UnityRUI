﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using React;
using System.Linq;

public class TodoList : RComposant {

    public struct defaultState { }
    [SerializeField] GameObject m_itemPrefab;
    [SerializeField] Transform m_grid;

    protected override void ComponentDidMount()
    {
        base.ComponentDidMount();
    }

    protected override bool ShouldComponentSubscribe()
    {
        return true;
    }

    private void ProcessTask(Task t)
    {
        Transform child = m_grid.Find(t.Id.ToString());
        if(child == null)
        {
            child = Instantiate(m_itemPrefab, m_grid, false).transform;
            child.name = t.Id.ToString();
        }

        child.GetComponentInChildren<TodoItem>().Task = t;
    }

    public override void Render()
    {
        List<Task> list = props.Get<List<Task>>("Tasks");
        foreach (Transform c in m_grid)
        {
            if (list.FindIndex(o => o.Id.ToString() == c.name) == -1)
                Destroy(c.gameObject);
        }

        list.ForEach(ProcessTask);
    }
}