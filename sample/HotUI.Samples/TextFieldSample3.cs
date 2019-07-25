﻿using System;
using System.Collections.Generic;

namespace HotUI.Samples
{
    public class TextFieldSample3 : View
    {
        class MyBindingObject : BindingObject 
        {
            public string Text 
            {
                get => GetProperty<string> ();
                set => SetProperty (value);
            }
        }

        [State] private readonly MyBindingObject _state = new MyBindingObject {Text = "Edit Me"};

        [Body]
        View Build() => new VStack()
        {
            new TextField(_state.TwoWayBinding(v => v.Text), "Name"),
            new HStack()
            {
                new Text("Current Value:")
                    .Color(Color.Grey),
                new Text(_state.Text),
                new Spacer()
            },
        }.FillHorizontal();
    }

}