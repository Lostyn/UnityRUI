﻿using System;

namespace Rednity.TodoSample
{
    public class TodoActionCreators
    {

        public static ExpendoObject ToggleItem(Guid todoId)
        {
            ExpendoObject action = new ExpendoObject();
            action["type"] = TodoActionTypes.TOGGLE;
            action["id"] = todoId;

            return action;
        }

        public static ExpendoObject RemoveItem(Guid todoId)
        {
            ExpendoObject action = new ExpendoObject();
            action["type"] = TodoActionTypes.REMOVE;
            action["id"] = todoId;

            return action;
        }

        public static ExpendoObject AddItem(string label)
        {
            ExpendoObject action = new ExpendoObject();
            action["type"] = TodoActionTypes.ADD;
            action["label"] = label;

            return action;
        }

    }
}