﻿using UnityEngine;
using UnityEngine.UI;
using System;

public static class BuyExtension
{
	public static void AddEventListener<T>(this Button button, T param, Action<T> OnClick)
	{
		button.onClick.AddListener(delegate ()
		{
			OnClick(param);
		});

	}
}
